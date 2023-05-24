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
using Microsoft.AspNetCore.Identity;


namespace DemoTraveler.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        public HomeController(AppDbContext _db , UserManager<ApplicationUser> _userManager)
        {
            db = _db;
            userManager = _userManager;
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
            var tickets = db.Tickets.Where(x => x.Travel.TravelId == Id).
                Include(x => x.Travel).
                Include(x => x.TicketType).
                Include(x => x.FlightType).ToList();
            return View(tickets);
        }

        



        [HttpGet]
        public IActionResult Booking(int Id)
        {
            var ticket = db.Tickets.Where(x => x.TicketId == Id).SingleOrDefault();
            var model = new BookingViewModel
            {
                TicketId = ticket.TicketId
            };

            ViewData["TicketId"] = new SelectList(db.Tickets, "TicketId", "ToCountry");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Booking(BookingViewModel booking, TicketViewModel ticket, UserTicketViewModel userTicket)
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
                    IsActive = true,
                    IsDeleted = false,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                };
                try
                {
                    db.Bookings.Add(bb);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError(string.Empty, "Error occurred while saving the booking.");
                    return View(booking);
                }


                ApplicationUser user = await userManager.GetUserAsync(User);

                UserTicket userTickete = new UserTicket
                {
                    ApplicationUserId = user.UserName,
                    TicketId = ticket.TicketId,
                    BookingId = bb.BookingId
                };

                db.UserTickets.Add(userTickete);
                db.SaveChanges();

                return RedirectToAction("Payment", new { Id = bb.BookingId , userTicket.UserTicketId });

            }
            else
            {
                ModelState.AddModelError("", "Booking Is Not Valid Now");
                return View(booking);
            }
        }


        [HttpGet]
        public IActionResult Payment(int Id)
        {
            PaymentViewModel model = new PaymentViewModel
            {
                BookingId = Id
            };
            return View(model);
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
                var ticket = db.Bookings.Where(x => x.BookingId == payment.BookingId).SingleOrDefault();
                ticket.Status = true;
                db.Bookings.Update(ticket);
                await db.SaveChangesAsync();
                ViewBag.ShowModel = true;
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
