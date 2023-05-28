using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class UserPackage
    {
        public int UserPackageId { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int BookingPackageId { get; set; }
        public BookingPackage BookingPackage { get; set; }

        public int PackageId { get; set; }
        public Package Package { get; set; }

    }
}
