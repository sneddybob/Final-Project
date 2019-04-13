using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finalizer.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<RegisteredUser> _userManager;

        public SearchController(ApplicationDbContext context, UserManager<RegisteredUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }

        //public IActionResult Index()
        //{
            
        //    return View();
        //}

        
        public IActionResult Index(string searchTerm)
        {
            if (ViewData["searchTerm"] != null)
            {

                ViewData["searchTerm"] = searchTerm;
                IEnumerable<Product> productToFind = _context.Products
                   .Include(product => product.Reviews)
                   .Include(product => product.ProductColors)
                   .Include(product => product.ProductImages)
                   .Include(product => product.Category).Where(product => product.Name.Contains(searchTerm) || product.Description.Contains(searchTerm));

                return View(productToFind);
            }
            else
            {
                ViewData["searchTerm"] = "nothing entered...";
                IEnumerable<Product> productToFind = _context.Products
                   .Include(product => product.Reviews)
                   .Include(product => product.ProductColors)
                   .Include(product => product.ProductImages)
                   .Include(product => product.Category).Where(product => product.Name.Contains(searchTerm) || product.Description.Contains(searchTerm));

                return View(productToFind);
            }

           
        }

    }
}