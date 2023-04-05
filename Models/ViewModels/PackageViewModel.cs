using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class PackageViewModel : CommonProp
    {
        public Guid CountryId { get; set; }
        public Country CountryName { get; set; }

        [Required(ErrorMessage = "Enter Duration!")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Enter How many Person For this package!")]
        public int Person { get; set; }

        [Required(ErrorMessage = "Enter Country Description!")]
        [Display(Name = "Country Description")]
        [DataType(DataType.MultilineText)]
        public string CountryDesc { get; set; }

        [Required(ErrorMessage = "Enter Prize!")]
        public int Prize { get; set; }

        [Required(ErrorMessage = "Enter Hotel Stars!")]
        [Display(Name = "Hotel Stars")]
        public int HotelStars { get; set; }

        [Required(ErrorMessage = "Select Country Image!")]
        [Display(Name = "Country Image")]
        public IFormFile CountryImg { get; set; }

    }
}
