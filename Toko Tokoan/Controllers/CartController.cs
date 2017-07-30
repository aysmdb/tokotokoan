using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toko_Tokoan.Models;
using Toko_Tokoan.Models.ViewModels;

namespace Toko_Tokoan.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }

        // GET: Cart
        public ActionResult Index(string returnUrl)
        {
            return View(
                new CartIndexViewModel
                {
                    Cart = GetCart(),
                    ReturnUrl = returnUrl
                }
                );
        }

        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Completed");
            }

            return View();
        }

        public ActionResult Completed()
        {
            return View();
        }

        public RedirectToRouteResult AddToCart(int productId, 
            string returnUrl)
        {
            Product product = db.Products
                .Where(x => x.Id == productId)
                .FirstOrDefault();

            if (product != null)
            {
                GetCart().AddItem(product);
                
            }

            return RedirectToAction("Index",
                    new { @returnUrl = returnUrl });
        }
    }
}