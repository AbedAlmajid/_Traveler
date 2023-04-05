using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class AboutUs : CommonProp
    {
        [Key]
        public Guid AboutUsId { get; set; }

        [Required(ErrorMessage ="Enter Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Description!")]
        [Display(Name = "About Us Description")]
        public string AboutUsDescription { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Image")]
        public string AboutImg1 { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Image")]
        public string AboutImg2 { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name ="Image")]
        public string AboutImg3 { get; set; }
    }
}
