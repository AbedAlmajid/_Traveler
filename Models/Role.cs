using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Role : CommonProp
    {
        [Key]
        [Display(Name = "Role ID")]
        public Guid RoleId { get; set; }

        [Display(Name = "Role Name")]
        [Required(ErrorMessage = "Enter Role Name")]
        public string RoleName { get; set; }
    }
}
