using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Finalizer.Models;
using Finalizer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finalizer.Controllers
{
    public class CheckoutController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;

        public CheckoutController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CheckoutViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                RegisteredUser registeredUser = null;
                if (User.Identity.IsAuthenticated)
                {
                    registeredUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
                }

                Cart cart = CartService.GetCart( _context, Request, Response, registeredUser);

                if (cart.CartItems.Count > 0)
                {

                        //TODO: Get a lot more info here, validate credit card + address, save it to a database

                        Order order = new Order();
                        order.ID = Guid.NewGuid().ToString().Substring(0, 8);
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

                        return RedirectToAction("index", "receipt", new { id = order.ID });
                    }
                    ModelState.AddModelError("cart", "There was a problem processing your cart");
                

            }
            return View(model);
        }
    }
}