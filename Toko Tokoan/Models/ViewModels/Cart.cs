using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toko_Tokoan.Models.ViewModels
{
    public class CartLine
    {
        public Product Products { get; set; }

        public int Quantity { get; set; }
    }

    public class Cart
    {
        private List<CartLine> lineCollection =
            new List<CartLine>();

        public List<CartLine> Lines
        {
            get { return lineCollection; }
        }

        public void AddItem(Product product)
        {
            CartLine cart = lineCollection
                .Where(x => x.Products.Id == product.Id)
                .FirstOrDefault();

            if (cart == null)
            {
                lineCollection.Add(new CartLine
                {
                    Products = product,
                    Quantity = 1
                });
            } else
            {
                cart.Quantity += 1;
            }
        }

        public decimal ComputeTotal()
        {
            return 
                lineCollection.Sum(
                    x => x.Quantity * x.Products.Price);
        }
    }
}