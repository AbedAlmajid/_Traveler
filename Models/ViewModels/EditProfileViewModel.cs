using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class EditProfileViewModel
    {
        [Required(ErrorMessage = "Enter User Name!")]
        [EmailAddress]
        public string UserName { get; set; }

    }
}
