using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Models.ViewModels
{
    public class BookingPackageViewModel
    {
        [Key]
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Input First Name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Input Last Name!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Input National Number")]
        [Display(Name = "National Number")]
        public string NationalNumber { get; set; }

        [Required(ErrorMessage = "Input Phone Number!")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Input Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Input Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Input Passport Number")]
        [Display(Name = "Passport Number")]
        public string PassportNumber { get; set; }

        public bool Status { get; set; } = false;








        [Required(ErrorMessage = "Enter Country Name!")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }


        [Required(ErrorMessage = "Enter Duration!")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Enter How many Person For this package!")]
        public int Person { get; set; }

        [Required(ErrorMessage = "Enter Country Description!")]
        [Display(Name = "Country Description")]
        [DataType(DataType.MultilineText)]
        public string CountryDesc { get; set; }

        [Required(ErrorMessage = "please Enter Brand Name!")]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "Enter Prize!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Enter Hotel Stars!")]
        [Display(Name = "Hotel Stars")]
        public int HotelStars { get; set; }

        [Required(ErrorMessage = "Select Depart Date!")]
        [Display(Name = "Depart Date")]
        public DateTime DepartDate { get; set; }


        [Required(ErrorMessage = "Select Return Date!")]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        public string UserId { get; set; }

        public int PackageId { get; set; }

        public ICollection<UserPackage> UserPackage { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
