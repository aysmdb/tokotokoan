using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toko_Tokoan.Models;
using Toko_Tokoan.Models.ViewModels;

namespace Toko_Tokoan.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index(string category)
        {
            ProductListViewModel products = new ProductListViewModel();

            products.Products = db.Products
                .Where(
         p => category == null || p.Category == category
                    )
                    .AsEnumerable();

            return View(products);
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