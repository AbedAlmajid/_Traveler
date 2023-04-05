using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class ClientViewModel : CommonProp
    {
        [Required(ErrorMessage = "Enter Client Name!")]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Enter Client Description!")]
        [Display(Name = "Client Description")]
        public string ClientDesc { get; set; }

        [Required(ErrorMessage = "Select Client Image!")]
        [Display(Name = "Client Image")]
        public IFormFile ClientImg { get; set; }
    }
}
