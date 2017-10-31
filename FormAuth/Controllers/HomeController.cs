using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormAuth.Models;

namespace FormAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var product = GetProductDetails();
            return View(product);
        }

        public ActionResult About()
        {
            var product = GetProductDetails();
            return PartialView(product);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [NonAction]
        public Product GetProductDetails()
        {
            return new Product()
            {
                Address = "pune",
                Id = 1,
                Name = "samsung",
                Detail = new ProductDetail()
                {
                    productdetailid = 3,
                    RRP = 10,
                    Supplier = "addecco"
                }

            };
        }
    }
}