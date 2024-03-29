﻿using FoodNStuffMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodNStuffMVC.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Product
        public ActionResult Index()
        {
            List<Product> productList = _db.Products.ToList();
            List<Product> orderedList = productList.OrderBy(prod => prod.ProductName).ToList();
            return View(orderedList);
        }
        //GET: Product/Create
        public ActionResult Create()
        {

            return View();
        }



            //POST: Product/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
        public ActionResult Create(Product product) {
            if (!ModelState.IsValid)
            {

            return View(product);//view calls the method it's in
                
            }
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
    }

