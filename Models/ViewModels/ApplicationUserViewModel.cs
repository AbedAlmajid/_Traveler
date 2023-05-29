using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class ApplicationUserViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Country Name")]
        [Required(ErrorMessage = "Enter Country Name")]
        public string CountryName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Miss Match Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
