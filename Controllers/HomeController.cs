using DemoTraveler.Data;
using DemoTraveler.Models;
using DemoTraveler.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace DemoTraveler.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destination()
        {
            return View();
        }

        public IActionResult TourPackage()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contact)
        {
            Contact cc = new Contact
            {
                FullName = contact.FullName,
                Email = contact.Email,
                Subject = contact.Subject,
                Message = contact.Message,
                IsActive = true,
                IsDeleted = false,
                ModificationDate = DateTime.Now,
                CreationDate = DateTime.Now
            };
            db.Contacts.Add(cc);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Client()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Ticket(int Id)
        {
            var tickets = db.Tickets.Where(x => x.Travel.TravelId == Id).ToList();
            return View(tickets);
        }

        [HttpGet]

        public IActionResult Booking(int Id)
        {
            var ticket = db.Tickets.Where(x => x.TicketId == Id).SingleOrDefault();
            ViewData["TicketId"] = new SelectList(db.Tickets, "TicketId", "ToCountry");
            return View();
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Booking(BookingViewModel booking)
        {
            if (ModelState.IsValid)
            {
                Booking bb = new Booking
                {
                    FirstName = booking.FirstName,
                    LastName = booking.LastName,
                    NationalNumber = booking.NationalNumber,
                    PhoneNumber = booking.PhoneNumber,
                    Address = booking.Address,
                    ZipCode = booking.ZipCode,
                    PassportNumber = booking.PassportNumber,
                    TicketId = booking.TicketId,
                    IsActive = true,
                    IsDeleted = false,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                };
                db.Add(bb);
                await db.SaveChangesAsync();
                return RedirectToAction("Payment");

            }
            ViewData["TicketId"] = new SelectList(db.Tickets, "TicketId", "Ticket", booking.TicketId);
            return View(booking);
        }


        [HttpGet]
        public IActionResult Payment(int Id)
        {
            var ticket = db.Bookings.Where(x => x.BookingId == Id).SingleOrDefault();
            return View(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> Payment(PaymentViewModel payment)
        {
            if (ModelState.IsValid)
            {
               
                Payment cc = new Payment
                {
                    CardNumber = payment.CardNumber,
                    CardHolder = payment.CardHolder,
                    ExpirationDate = payment.ExpirationDate,
                    CCV = payment.CCV
                };

                db.Add(cc);
                await db.SaveChangesAsync();
                return RedirectToAction("Index" , "Home");
            }
            return View(payment);
        }

        public IActionResult Package(int Id)
        {
            var package = db.Bookings.Where(b => b.BookingId == Id).SingleOrDefault();
            return View(package);
        }



        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                });

            return LocalRedirect(returnUrl);
        }

        public IActionResult SearchTravel(string txtName)
        {
            string selectedTravel = Request.Form["txtName"];
            ViewData["TravelId"] = new SelectList(db.Travels, "TravelId", "Travel");
            var travel = db.Travels.Where(t => t.TravelName.Contains(txtName)).ToList();
            return View(travel);
        }

    }



}
