using DemoTraveler.Models.SharedProp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class GuideViewModel : CommonProp
    {
        [Required(ErrorMessage = "Enter Guide Name!")]
        [Display(Name = "Guide Name")]
        public string GuideName { get; set; }

        [Required(ErrorMessage = "Enter Guide Job!")]
        [Display(Name = "Guide Job")]
        public string GuideJob { get; set; }

        [Required(ErrorMessage = "Select Guide Image!")]
        [Display(Name = "Guide Image")]
        public IFormFile GuideImg { get; set; }

        [Required(ErrorMessage = "Enter Guide Twitter!")]
        [Display(Name = "Twitter")]
        public string GuideTwitter { get; set; }

        [Required(ErrorMessage = "Enter Guide Facebook!")]
        [Display(Name = "Facebook")]
        public string GuideFacebook { get; set; }

        [Required(ErrorMessage = "Enter Guide Instagram!")]
        [Display(Name = "Instagram")]
        public string GuideInstagram { get; set; }

        [Required(ErrorMessage = "Enter Guide Linkdin!")]
        [Display(Name = "Linkdin")]
        public string GuideLinkdin { get; set; }
    }
}
