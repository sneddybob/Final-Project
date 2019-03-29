using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Finalizer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Finalizer.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;

        public ShopController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            //If my database's categories table is empty, add mock data here:
            //if (!_context.Categories.Any())
            //{
            //    _context.Categories.AddRange(MockShopData.categories);
            //    _context.SaveChanges();
            //}

            //Instead of returning mock category data, return the DbContext's Categories property
            return View(_context.Categories.Include(x => x.Products).ThenInclude(x => x.ProductImages));
        }
        public IActionResult Details(int? id)
        {
            Product productToFind = _context.Products
               .Include(product => product.Reviews)
               .Include(product => product.ProductColors)
               .Include(product => product.ProductImages)
               .Include(product => product.Category).Single(product => product.ID == id);


            return View(productToFind);
        }
        [HttpPost]
        public IActionResult Details(int id, int color)//add back in price if needed
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