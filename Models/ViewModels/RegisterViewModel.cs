using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class RegisterViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter First Name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Enter Your Birth Day!")]
        [Display(Name ="Birth Day")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage = "Select Your Gender!")]
        public bool Gender { get; set; }

        [Required(ErrorMessage ="Enter User Name!")]
        [EmailAddress]
        public string Email { get; set; }

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
