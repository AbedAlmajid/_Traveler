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

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            string userId = userManager.GetUserId(User);

            if (userId == null)
            {
                return NotFound();
            }

            var ticket = db.Tickets.FirstOrDefault(t => t.TicketId == Id);
            if (ticket == null)
            {
                return NotFound();
            }
            var bookingViewModel = new BookingViewModel
            {
                UserId = userId,
                TicketId = ticket.TicketId,
                BrandName = ticket.BrandName,
                FromCountry = ticket.FromCountry,
                ToCountry = ticket.ToCountry,
                FromAirport = ticket.FromAirport,
                ToAirport = ticket.ToAirport,
                DepartTime = ticket.DepartTime,
                ArriveTime = ticket.ArriveTime,
                DepartDate = ticket.DepartDate,
                FlightDuration = ticket.FlightDuration,
                Weight = ticket.Weight,
                Price = ticket.Price,
                TravelId = ticket.TravelId,
                TicketTypeId = ticket.TicketTypeId,
                FlightTypeId = ticket.FlightTypeId,

            };
            return View(bookingViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Booking(BookingViewModel booking, int Id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            string userId = userManager.GetUserId(User);

            if (userId == null)
            {
                return NotFound();
            }
            else
            {
            if (ModelState.IsValid)
            {
                
                Booking bb = new Booking
                {
                    UserId = userId,
                    TicketId  = Id,
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
                  db.Bookings.Add(bb);
                 await db.SaveChangesAsync();

                    UserTicket userTicket = new UserTicket
                    {
                        ApplicationUserId = userId,
                        TicketId = Id,
                        BookingId = bb.BookingId
                    };

                    db.UserTickets.Add(userTicket);
                    db.SaveChanges();

                    return RedirectToAction("Payment", new { Id = bb.BookingId });
            }
            else
            {
                ModelState.AddModelError("Address", "Booking Is Not Valid Now");
                return View(booking);
            }
            }
        }

        [HttpGet]
        public IActionResult Package(int Id)
        {
            var package = db.BookingPackages.Where(b => b.BookingPackageId == Id).SingleOrDefault();
            return View(package);
        }

        [HttpGet]
        public IActionResult BookingPackage(int Id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (User.IsInRole("Customer"))
            {
                string userId = userManager.GetUserId(User);

                if (userId == null)
                {
                    return NotFound();
                }
                var package = db.Packages.FirstOrDefault(t => t.PackageId == Id);
                if (package == null)
                {
                    return NotFound();
                }
                BookingPackageViewModel bookingPackageViewModel = new BookingPackageViewModel
                {
                    UserId = userId,
                    PackageId = Id,
                    BrandName = package.BrandName,
                    CountryName = package.CountryName,
                    Duration = package.Duration,
                    Person = package.Person,
                    CountryDesc = package.CountryDesc,
                    Price = package.Price,
                    HotelStars = package.HotelStars,
                    DepartDate = package.DepartDate,
                    ReturnDate = package.ReturnDate
                };
                return View(bookingPackageViewModel);
            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> BookingPackage(BookingPackageViewModel booking, int Id)
        {
            
            string userId = userManager.GetUserId(User);

            if (userId == null)
            {
                return NotFound();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    BookingPackage bb = new BookingPackage
                    {
                        UserId = userId,
                        PackageId = Id,
                        FirstName = booking.FirstName,
                        LastName = booking.LastName,
                        NationalNumber = booking.NationalNumber,
                        PhoneNumber = booking.PhoneNumber,
                        Address = booking.Address,
                        ZipCode = booking.ZipCode,
                        PassportNumber = booking.PassportNumber
                    };
                    db.BookingPackages.Add(bb);
                    await db.SaveChangesAsync();

                    UserPackage userPackage = new UserPackage
                    {
                        ApplicationUserId = userId,
                        PackageId = Id,
                        BookingPackageId = bb.BookingPackageId
                    };

                    db.UserPackages.Add(userPackage);
                    db.SaveChanges();

                    return RedirectToAction("PaymentPackage", new { Id = bb.BookingPackageId });
                }
                else
                {
                    ModelState.AddModelError("Address", "Booking Is Not Valid Now");
                    return View(booking);
                }
            }
        }



        [HttpGet]
        public IActionResult PaymentPackage(int Id)
        {
            PaymentPackageViewModel model = new PaymentPackageViewModel
            {
                BookingPackageId = Id
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PaymentPackage(PaymentPackageViewModel payment)
        {
            if (ModelState.IsValid)
            {

                PaymentPackage cc = new PaymentPackage
                {
                    CardNumber = payment.CardNumber,
                    CardHolder = payment.CardHolder,
                    ExpirationDate = payment.ExpirationDate,
                    CCV = payment.CCV
                };

                db.Add(cc);
                var package = db.BookingPackages.Where(x => x.BookingPackageId == payment.BookingPackageId).SingleOrDefault();
                if (package == null)
                {
                    ModelState.AddModelError(string.Empty , "Choose your Destination First");
                }
                else
                {
                    package.Status = true;
                    db.BookingPackages.Update(package);
                    await db.SaveChangesAsync();
                    ViewBag.ShowModel = true;
                }
                ViewBag.ShowModel = false;
                return RedirectToAction("Index", "Home");
            }
            return View(payment);
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
            }
            return View(payment);
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
            if (txtName == null)
            {
                return View(travel);
            }
            return View(travel);
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

    }



}
