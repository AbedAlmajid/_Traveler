using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Gender { get; set; }
        public string City { get; set; }
    }
}
