using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class AboutUsViewModel : CommonProp
    {
        [Key]
        public int AboutUsId { get; set; }

        [Required(ErrorMessage = "Enter Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Description!")]
        [Display(Name = "About Us Description")]
        public string AboutUsDescription { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Image")]
        public IFormFile AboutImg1 { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Image")]
        public IFormFile AboutImg2 { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Image")]
        public IFormFile AboutImg3 { get; set; }
    }
}
