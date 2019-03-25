using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalizer.Models
{
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "Please fill out the name field.")]
        [Display(Name = "Your Name")]
        public string ContactName { get; set; }

        [Display(Name = "Your Email")]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Phone]
        [RegularExpression(@"^([\+]?[0-9]{1,3}[\s.-][0-9]{1,12})([\s.-]?[0-9]{1,4}?)$")]
        public string ContactPhoneNumber { get; set; }

        [Display(Name = "Street Address 1")]
        public string ShippingStreet1 { get; set; }

        [Display(Name = "Street Address 2")]
        public string ShippingStreet2 { get; set; }

        [Display(Name = "City")]
        public string ShippingCity { get; set; }

        [Display(Name = "Region")]
        public string ShippingRegion { get; set; }

        [Display(Name = "Locale")]
        public string ShippingLocale { get; set; }

        [Display(Name = "Country")]
        public string ShippingCountry { get; set; }

        [Display(Name = "Postal Code")]
        public string ShippingPostalCode { get; set; }


    }
}
