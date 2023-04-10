using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Travel : CommonProp
    {
        [Key]
        public int TravelId { get; set; }

        [Required(ErrorMessage ="Enter Travel Name!")]
        [Display(Name ="Travel Name")]
        public string TravelName { get; set; }

        [Required(ErrorMessage ="Select Travel Image")]
        [Display(Name ="Travel Image")]
        public string TravelImg { get; set; }

        public IList<Tickets> Tickets { get; set; }
    }
}
