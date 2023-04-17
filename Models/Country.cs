using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Country : CommonProp
    {
        [Key]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Input Country Name")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
        
    }
}
