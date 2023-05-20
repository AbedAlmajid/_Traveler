using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Role : IdentityRole
    {
        public string RoleId { get; set; }

        [Required(ErrorMessage = "Enter Role Name")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}
