using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class CountryViewModel : CommonProp
    {
        [Required(ErrorMessage = "Input Country Name")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}
