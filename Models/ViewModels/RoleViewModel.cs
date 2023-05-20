using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class RoleViewModel
    {
        public string RoleId { get; set; }

        [Required(ErrorMessage ="Enter Role Name")]
        [Display(Name = "Role Name")]
        public string Name { get; set; }
    }
}
