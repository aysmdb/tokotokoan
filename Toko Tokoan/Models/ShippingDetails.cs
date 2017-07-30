using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Toko_Tokoan.Models
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter province name.")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Please enter city name.")]
        public string City { get; set; }
        
        public int ZIP { get; set; }
    }
}