using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Enter User Name!")]
        [EmailAddress]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password!")]
        [DataType(DataType.Password)]
        [Compare("Password" ,ErrorMessage ="Miss Match Password" )]
        [Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter phone Number!")]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
