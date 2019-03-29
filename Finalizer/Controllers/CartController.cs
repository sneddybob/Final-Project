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
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;

        public CartController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
            
        }

        public IActionResult Index()
        {
            RegisteredUser registeredUser = null;
            if (User.Identity.IsAuthenticated)
            {
                registeredUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            }

            Cart cart = CartService.GetCart(_context, Request, Response, registeredUser);

            return View(cart);

        }
        [HttpPost]
        public IActionResult Index(int cartItemId, int quantity)
        {
            CartItem cartItem = _context.CartItems.Find(cartItemId);
            cartItem.Quantity = quantity;

            if (quantity == 0)
            {
                _context.CartItems.Remove(cartItem);
            }

            _context.SaveChanges();


            return RedirectToAction("index");
        }
        public IActionResult Count()
        {
            RegisteredUser registeredUser = null;
            if (User.Identity.IsAuthenticated)
            {
                registeredUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            }

            Cart cart = CartService.GetCart(_context, Request, Response, registeredUser);
       
            return Json(cart.CartItems.Sum(x => x.Quantity));
        }
    }
}