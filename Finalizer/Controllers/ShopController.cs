﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalizer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finalizer.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            //If my database's categories table is empty, add mock data here:
            if (!_context.Categories.Any())
            {
                _context.Categories.AddRange(MockShopData.categories);
                _context.SaveChanges();
            }

            //Instead of returning mock category data, return the DbContext's Categories property
            return View(_context.Categories.Include(x => x.Products).ThenInclude(x => x.ProductImages));
        }
        public IActionResult Details(int? id)
        {
            Product productToFind = _context.Products.Find(id);


            return View (productToFind);
        }

        [HttpPost]
            public IActionResult Details(int id, int color, int size)
            {
                //TODO: I need to add a bunch of other "logic" here to add the item to a cart
                Response.Cookies.Append("Guitar Info", id + "|" + color + "|" + size);

                return RedirectToAction("Index", "Cart");
            }
        }
}