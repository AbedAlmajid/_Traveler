using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class FlightTypeViewModel
    {

        [Key]
        public int FlightTypeId { get; set; }

        [Required]
        [Display(Name = "Flight Type")]
        public string TypeFlight { get; set; }

        public IList<Ticket> Tickets { get; set; }
    }
}
