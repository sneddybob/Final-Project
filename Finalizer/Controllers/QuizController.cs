using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finalizer.Controllers
{
    public class QuizController : Controller
    {
        private ApplicationDbContext _context;

        public QuizController(ApplicationDbContext context)
        {
            this._context = context;
        }



        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int Radios1, int Radios2, int Radios3, int Radios4)
        {

            //if(Radios1 + Radios2 == 5)
            //{

            //}
            return RedirectToAction("Results", new { id = ((Radios1+Radios2+Radios3+Radios4)/4)});
        }


        public IActionResult Results(int? id)
        {
            Product productToFind = _context.Products.Include(x => x.ProductImages)
                .Include(x => x.Reviews).Single(x => x.ID == id);


            return View(productToFind);

        }
    }
}