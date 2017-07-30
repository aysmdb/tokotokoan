using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toko_Tokoan.Models;
using Toko_Tokoan.Models.ViewModels;

namespace Toko_Tokoan.Controllers
{
    public class NavController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories =
                db.Products
                .Select(x => x.Category)
                .Distinct()
                .AsEnumerable();

            return PartialView(categories);
        }
    }
}