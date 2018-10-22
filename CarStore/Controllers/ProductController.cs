using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarStore.Models;


namespace CarStore.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products;


        public ProductController()
        {
            //for now use a list to mock up product data

            _products = new List<Product>();
            _products.Add(new Product
            {
                ID = 1,
                Name = "SUV",
                Description = "An off road SUV",
                Image = "/images/suv.jpeg",
                Price = 50000m
            });

            _products.Add(new Product
            {
                ID = 2,
                Name = "Mini Van",
                Description = "Van for soccer moms",
                Image = "/images/van.jpeg",
                Price = 25000m


            });


            _products.Add(new Product
            {
                ID = 3,
                Name = "Sports Car",
                Description = "Sports Car with lots of power",
                Image= "/images/lambo.jpeg",
                Price = 75000m


            });

        }

        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Product p = _products.Single(x => x.ID == id.Value);
                return View(p);
            }

            return NotFound();
        }


        public IActionResult Index()
        {
            return View(_products);
        }
    }
}