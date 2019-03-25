using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Microsoft.AspNetCore.Mvc;

namespace Finalizer.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(int? id)
        {
            Product productToFind = null;
            foreach (var category in MockShopData.categories)
            {
                foreach (var product in category.Products)
                {
                    if (product.ID == id)
                    {
                        productToFind = product;
                    }
                }
            }

            return View(productToFind);
        }
    }
}