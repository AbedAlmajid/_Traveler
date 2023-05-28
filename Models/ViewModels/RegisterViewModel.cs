using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class RegisterViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Enter First Name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Last Name!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Your Birth Day!")]
        [Display(Name = "Birth Day")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage = "Select Your Gender!")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Enter Email !")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter phone Number!")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(100, ErrorMessage = "Password at least 8 Charachter", MinimumLength = 8)]
        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,11}", ErrorMessage = "Invalid password format")]
        [Required(ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Miss Match Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


        public string RoleId { get; set; }
        public SelectList Roles { get; set; }
    }

        
    }
