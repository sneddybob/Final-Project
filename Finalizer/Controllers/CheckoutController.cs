﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finalizer.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CheckoutViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                Console.WriteLine("Processing an order from " + model.ContactEmail);
                //TODO: Get a lot more info here, validate credit card + address, save it to a database

                return RedirectToAction("index", "receipt");
            }
            ModelState.AddModelError("Form Incomplete", "Please fill out the required fields.");
            return View(model);
        }
    }
}