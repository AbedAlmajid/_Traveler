﻿using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Booking : CommonProp
    {
        [Key]
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Input First Name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Input Last Name!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Input National Number")]
        [Display(Name = "National Number")]
        public string NationalNumber { get; set; }

        [Required(ErrorMessage = "Input Phone Number!")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Input Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Input Zip Code")]
        public string ZipCode { get; set; }

        public bool Status { get; set; } = false;

        [Required(ErrorMessage = "Input Passport Number")]
        [Display(Name = "Passport Number")]
        public string PassportNumber { get; set; }

        public string UserId { get; set; }

        public int TicketId { get; set; }

        public ICollection<UserTicket> UserTicket { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
