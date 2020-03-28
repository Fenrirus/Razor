using Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        private Product myProduct = new Product()
        {
            ProductId = 1,
            Name = "Kajak",
            Description = "Jednoosobowa łodka",
            Category = "Sporty Wodne",
            Price = 275M,
        };

        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name = "Kajak", Price=275m},
                new Product {Name = "Kamizelka", Price = 48.95m},
                new Product {Name = "Pilka", Price = 19.50m},
                new Product {Name = "Flaga narożna", Price = 34.95m}
            };
            return View(array);
        }
    }
}