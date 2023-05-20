using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class UserRoleViewModel 
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public SelectList Users { get; set; }
        public SelectList Roles { get; set; }
    }
}
