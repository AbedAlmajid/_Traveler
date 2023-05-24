using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class UserTicketViewModel
    {
        public int UserTicketId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        [Required]
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
