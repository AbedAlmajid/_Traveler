using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Payment
    {
        [Key]
        public int CardId { get; set; }

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
    }
}
