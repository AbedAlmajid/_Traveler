using DemoTraveler.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models
{
    public class Contact : CommonProp
    {
        [Key]
        public Guid ContactId { get; set; }

        [Required(ErrorMessage ="Enter Full Name!")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Enter your Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Subject!")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Enter Message!")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
