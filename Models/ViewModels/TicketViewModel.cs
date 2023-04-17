using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class TicketViewModel
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "please select Fly Brand!")]
        [Display(Name = "Fly Brand Image")]
        public IFormFile FlyBrand { get; set; }

        [Required(ErrorMessage = "please Enter Brand Name!")]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "Enter From Country!")]
        [Display(Name = "From Country")]
        public string FromCountry { get; set; }

        [Required(ErrorMessage = "Enter To Country!")]
        [Display(Name = "To Country")]
        public string ToCountry { get; set; }

        [Required(ErrorMessage = "Enter From Airport!")]
        [Display(Name = "From Airport")]
        public string FromAirport { get; set; }

        [Required(ErrorMessage = "Enter  To Airport Name!")]
        [Display(Name = "To Airport Name")]
        public string ToAirport { get; set; }

        [Required(ErrorMessage = "Enter Depart Time!")]
        [Display(Name = "Depart Time")]
        public string DepartTime { get; set; }

        [Required(ErrorMessage = "Enter Arrive Time!")]
        [Display(Name = "Arrive Time")]
        public string ArriveTime { get; set; }

        [Required(ErrorMessage = "Enter Depart Date!")]
        [Display(Name = "Depart Date")]
        public string DepartDate { get; set; }

        [Required(ErrorMessage = "Enter Flight Duration!")]
        [Display(Name = "Flight Duration")]
        public string FlightDuration { get; set; }

        [Required(ErrorMessage = "Enter Weight!")]
        [Display(Name = "Weight")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Enter  Price!")]
        [Display(Name = "Price")]
        public decimal? Price { get; set; }

        public int TravelId { get; set; }
        public Travel Travel { get; set; }

        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

        public int FlightTypeId { get; set; }
        public FlightType FlightType { get; set; }

        public IList<Booking> Bookings { get; set; }
    }
}
