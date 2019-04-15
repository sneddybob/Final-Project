using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Finalizer.Models;
using Finalizer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SendGrid;
using SmartyStreets;
using SmartyStreets.USStreetApi;

namespace Finalizer.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;
        private IEmailSender _emailSender;
        private ClientBuilder _smartyCall; //Smarty Streets
        private Braintree.IBraintreeGateway _braintreeGateway;

        public CheckoutController(ApplicationDbContext context, UserManager<RegisteredUser> userManager, 
            IEmailSender emailSender, ClientBuilder smartyCall, Braintree.IBraintreeGateway braintreeGateway)
        {
            this._context = context;
            this._userManager = userManager;
            this._emailSender = emailSender;
            this._smartyCall = smartyCall;
            this._braintreeGateway = braintreeGateway;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["clientToken"] = await _braintreeGateway.ClientToken.GenerateAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CheckoutViewModel model, string braintreeNonce)
        {
            var orderID = Guid.NewGuid().ToString().Substring(0, 8);

            //var client = new ClientBuilder(authId, authToken)
            // uncomment this line to point to the specified proxy.
            var client = _smartyCall.BuildUsStreetApiClient();

            var lookup = new Lookup
            {
                InputId = orderID, // Optional ID from you system
                Addressee = model.ContactName,
                Street = model.ShippingStreet1,
                Street2 = model.ShippingStreet2,
                City = model.ShippingCity,
                State = model.ShippingLocale,
                ZipCode = model.ShippingPostalCode,
                MatchStrategy = Lookup.STRICT // STRICT matches exact, RANGE matches any valid street number, INVALID is wildcard
            };
            try
            {
                client.Send(lookup);
            }
            catch (SmartyException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            var candidates = lookup.Result;

            if (candidates.Count == 0)
            {
                ModelState.AddModelError("cart", "There was a problem with your address.");
                Console.WriteLine("No candidates. This means the address is not valid.");

            }

            if (candidates.Count > 0)
            {
                ViewData["clientToken"] = await _braintreeGateway.ClientToken.GenerateAsync();
                if (string.IsNullOrEmpty(braintreeNonce))
                {
                    this.ModelState.AddModelError("nonce", "We're unable to validate this credit card");

                }

                if (this.ModelState.IsValid)
                {
                    RegisteredUser registeredUser = null;
                    if (User.Identity.IsAuthenticated)
                    {
                        registeredUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
                    }

                    Cart cart = CartService.GetCart(_context, Request, Response, registeredUser);

                    if (cart.CartItems.Count > 0)
                    {
                        Braintree.TransactionRequest transactionRequest = new Braintree.TransactionRequest();
                        transactionRequest.PaymentMethodNonce = braintreeNonce;
                        transactionRequest.PurchaseOrderNumber = orderID;
                        transactionRequest.Amount = cart.CartItems.Sum(x => x.Quantity * x.Product.Price);
                        transactionRequest.ShippingAddress = new Braintree.AddressRequest
                        {
                            StreetAddress = model.ShippingStreet1,
                            ExtendedAddress = model.ShippingStreet2,
                            PostalCode = model.ShippingPostalCode,
                            //CountryName = model.ShippingCountry,  //This thing is picky about casing
                            FirstName = model.ContactName.Split(' ').First(),
                            LastName = model.ContactName.Contains(' ') ? string.Join(' ', model.ContactName.Split(' ').Skip(1)) : "",
                            Locality = model.ShippingCity,
                            Region = model.ShippingRegion
                        };
                        transactionRequest.Customer = new Braintree.CustomerRequest
                        {
                            Email = registeredUser != null ? registeredUser.Email : model.ContactEmail,
                        };
                        transactionRequest.LineItems = cart.CartItems.Select(x => new Braintree.TransactionLineItemRequest
                        {
                            Name = x.Product.Name,
                            Description = x.Product.Description,
                            ProductCode = x.ProductID.ToString(),
                            Quantity = x.Quantity,
                            UnitAmount = x.Product.Price,
                            TotalAmount = x.Product.Price * x.Quantity,
                            LineItemKind = Braintree.TransactionLineItemKind.DEBIT
                        }).ToArray();

                        Braintree.Result<Braintree.Transaction> transactionResult = _braintreeGateway.Transaction.Sale(transactionRequest);
                        if (transactionResult.IsSuccess())
                        {

                            var firstCandidate = candidates[0];

                            Console.WriteLine("Address is valid. (There is at least one candidate)\n");
                            Console.WriteLine("ZIP Code: " + firstCandidate.Components.ZipCode);
                            Console.WriteLine("City: " + firstCandidate.Components.CityName);
                            Console.WriteLine("Street: " + firstCandidate.Components.StreetName);


                            //TODO: Get a lot more info here, validate credit card + address, save it to a database

                            Order order = new Order();
                            order.ID = orderID;
                            order.OrderDate = DateTime.Now.ToString();
                            order.ContactEmail = model.ContactEmail;
                            order.ContactName = model.ContactName;
                            order.ContactPhoneNumber = model.ContactPhoneNumber;
                            order.ShippingCity = model.ShippingCity;
                            order.ShippingCountry = model.ShippingCountry;
                            order.ShippingPostalCode = model.ShippingPostalCode;
                            order.ShippingRegion = model.ShippingRegion;
                            order.ShippingStreet1 = model.ShippingStreet1;
                            order.ShippingStreet2 = model.ShippingStreet2;


                            order.OrderItems = cart.CartItems.Select(ci => new OrderItem
                            {
                                ProductID = ci.ProductID,
                                Color = ci.ProductColor != null ? ci.ProductColor.Color : null,
                                Description = ci.Product.Description,
                                Name = ci.Product.Name,
                                Price = ci.Product.Price,
                                Quantity = ci.Quantity,
                            }).ToArray();

                            _context.CartItems.RemoveRange(cart.CartItems);
                            _context.Carts.Remove(cart);
                            Response.Cookies.Delete("FinalizerCartInfo");
                            _context.Orders.Add(order);
                            if (registeredUser != null)
                            {
                                order.RegisteredUser = registeredUser;
                            }
                            _context.SaveChanges();
                            await _emailSender.SendEmailAsync(model.ContactEmail, "Receipt for order #" + order.ID, order.ContactName+" thanks for your order!  Your order will be sent to "+order.ShippingStreet1+".");
                            return RedirectToAction("index", "receipt", new { id = order.ID });
                        }
                        ModelState.AddModelError("cart", "There was a problem processing your cart");
                    }
                }
            }
            return View(model);
        }
    }
}