using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class PaymentPackage
    {
        [Key]
        public int CardPackageId { get; set; }

        [Required(ErrorMessage = "Enter Card Number!")]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Enter Card Holder!")]
        [Display(Name = "Card Holder")]
        public string CardHolder { get; set; }

        [Required(ErrorMessage = "Enter Expiration Date!")]
        [Display(Name = "Expiration Date")]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "Enter CVV!")]
        public string CCV { get; set; }

        public int? BookingPackageId { get; set; }
        public BookingPackage BookingPackage { get; set; }

        public int? PackageId { get; set; }
        public Package Package { get; set; }
    }
}
