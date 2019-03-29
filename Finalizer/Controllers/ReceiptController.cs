using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Finalizer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finalizer.Controllers
{
    public class ReceiptController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;

        public ReceiptController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }
        public IActionResult Index(string id)
        {
            Order orderToFind = _context.Orders
               .Include(o => o.OrderItems).First(o => o.ID == id);

            return View(orderToFind);
        }
        //[HttpPost]
        //public IActionResult Index(ReceiptViewModel model)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        RegisteredUser registeredUser = null;
        //        if (User.Identity.IsAuthenticated)
        //        {
        //            registeredUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
        //        }
        //    }
        //    return View(model);
        //}
    }
}