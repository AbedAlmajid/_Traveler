using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Airline
    {
        [Key]
        public int AirlineId { get; set; }

        [Required(ErrorMessage = "Enter AirLine Name!")]
        [Display(Name = "AirLine Name")]
        public string AirLineName { get; set; }

        [Required(ErrorMessage = "Enter Location!")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Enter Phone Number!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        public string AirlineImage { get; set; }
    }
}
