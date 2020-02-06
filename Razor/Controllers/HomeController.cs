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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}