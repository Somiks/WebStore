using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore6.Models;

namespace WebStore6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product()
            {
                Name = "Hello world"
            };
            return View(product);
        }
    }
}