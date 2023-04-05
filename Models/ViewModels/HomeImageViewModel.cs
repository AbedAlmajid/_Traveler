using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class HomeImageViewModel : CommonProp
    {
        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "First Image")]
        public IFormFile Imagea { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Second Image")]
        public IFormFile Imageb { get; set; }
    }
}
