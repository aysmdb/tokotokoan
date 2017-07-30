using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toko_Tokoan.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}