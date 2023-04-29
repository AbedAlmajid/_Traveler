using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter User Name!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
