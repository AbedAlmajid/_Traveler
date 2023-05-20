using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class UserTicketViewModel
    {
        public int UserTicketId { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
