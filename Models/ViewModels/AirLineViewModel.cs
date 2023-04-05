using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class AirLineViewModel
    {
        [Required(ErrorMessage = "Enter AirLine Name!")]
        [Display(Name = "AirLine Name")]
        public string AirLineName { get; set; }

        [Required(ErrorMessage = "Enter Location!")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Enter Phone Number!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        public IFormFile AirlineImage { get; set; }
    }
}
