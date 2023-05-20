using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class TicketTypeViewModel
    {
        [Key]
        public int TicketTypeId { get; set; }

        [Required]
        [Display(Name ="Type Ticket")]
        public string TypeTicket { get; set; }

        public IList<Ticket> Tickets { get; set; }
    }
}
