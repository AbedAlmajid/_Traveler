using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Partner : CommonProp
    {
        [Key]
        public int PartnerId { get; set; }

        [Required(ErrorMessage = "Enter Partner Name!")]
        [Display(Name = "Partner Name")]
        public string PartnerName { get; set; }

        [Required(ErrorMessage = "Enter Partner Jop!")]
        [Display(Name = "Partner Jop")]
        public string PartnerJop { get; set; }

        [Required(ErrorMessage = "Select Partner Image!")]
        [Display(Name = "Partner Image")]
        public string PartnerImg { get; set; }
    }
}
