using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class User : CommonProp
    {
        [Key]
        [Display(Name = "User ID")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Enter User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        public string PhoneNumber { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
