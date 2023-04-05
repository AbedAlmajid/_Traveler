using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class TravelViewModel : CommonProp
    {
        [Key]
        public Guid TravelId { get; set; }

        [Required(ErrorMessage = "Enter Travel Name!")]
        [Display(Name = "Travel Name")]
        public string TravelName { get; set; }

        [Required(ErrorMessage = "Select Travel Image")]
        [Display(Name = "Travel Image")]
        public IFormFile TravelImg { get; set; }
    }
}
