using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class TicketType : CommonProp
    {
        [Key]
        public int TicketTypeId { get; set; }

        [Required]
        [Display(Name = "Type Ticket")]
        public string TypeTicket { get; set; }

        public IList<Ticket> Tickets { get; set; }

    }
}

