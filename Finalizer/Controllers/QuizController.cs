using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Finalizer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finalizer.Controllers
{
    public class QuizController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;

        public QuizController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int Radios1, int Radios2, int Radios3, int Radios4)
        {
            
            var localID = (Radios1 + Radios2 + Radios3 + Radios4);
            if(localID == 0)
            {
                localID = 1;
            }
            else
            {
                localID = (localID / 4);
            }


            return RedirectToAction("Results", new { id = localID });
        }


        public IActionResult Results(int? id)
        {
           
            Product productToFind = _context.Products
               .Include(product => product.Reviews)
               .Include(product => product.ProductColors)
               .Include(product => product.ProductImages)
               .Include(product => product.Category).Single(product => product.ID == id);


            return View(productToFind);

        }
        [HttpPost]
        public IActionResult Results(int id, int color)//add back in price if needed
        {
            RegisteredUser registeredUser = null;
            if (User.Identity.IsAuthenticated)
            {
                registeredUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            }

            Cart cart = CartService.GetCart(_context, Request, Response, registeredUser);


            //If the user has previously added this item to the cart, try to find it:
            CartItem item = cart.CartItems
                .FirstOrDefault(ci => ci.ProductID == id &&
                ci.ProductColor.ID == color);

            //Otherwise, this is the first time this product has been added
            //Create a new line item and look up details from the Product table
            if (item == null)
            {
                Product product = _context.Products
                    .Include(p => p.ProductColors)
                    .FirstOrDefault(p => p.ID == id);
                item = new CartItem
                {
                    ProductID = product.ID,
                    ProductColor = product.ProductColors.FirstOrDefault(c => c.ID == color),
                    Quantity = 0
                };
                cart.CartItems.Add(item);
            }

            //Add 1 to the quantity.
            item.Quantity++;

            //This command Inserts/Updates/Deletes all of the information from SQL
            //Until you call Save, all of your changes are "queued"
            _context.SaveChanges();

            //Go to the cart page-- when you get there, you should be able to use
            //the cart cookie to fetch the cart.
            return RedirectToAction("Index", "Cart");
        }
    }
}