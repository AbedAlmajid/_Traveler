using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class HomeImage : CommonProp
    {
        [Key]
        public Guid ImageId { get; set; }

        [Required(ErrorMessage ="Select Image!")]
        [Display(Name ="First Image")]
        public string Imagea { get; set; }

        [Required(ErrorMessage = "Select Image!")]
        [Display(Name = "Second Image")]
        public string Imageb { get; set; }
    }
}
