using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Enter First Name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Your Birth Day!")]
        [Display(Name = "Birth Day")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage = "Select Your Gender!")]
        public bool Gender { get; set; }

        public IList<Ticket> Tickets { get; set; }
    }
}
