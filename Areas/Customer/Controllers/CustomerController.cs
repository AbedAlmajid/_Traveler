using DemoTraveler.Data;
using DemoTraveler.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Areas.Customer.Controllers
{

    [Area("Customer")]
    public class CustomerController : Controller
    {
        private readonly AppDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        public CustomerController(AppDbContext _db, UserManager<ApplicationUser> _userManager)
        {
            db = _db;
            userManager = _userManager;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult UserTicket()
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
            var userTicket = db.UserTickets.Where(u => u.ApplicationUser.Id == userId).Include(a => a.ApplicationUser).
                Include(b => b.Booking).
                Include(t => t.Ticket).ThenInclude(tt => tt.TicketType).
                Include(t => t.Ticket).ThenInclude(ft => ft.FlightType).
                ToList();
            return View(userTicket);
        }

        [HttpGet]
        public IActionResult UserPackage()
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
            var userTicket = db.UserPackages.Where(u => u.ApplicationUser.Id == userId).Include(t => t.ApplicationUser).
                Include(t => t.BookingPackage).
                Include(t => t.Package).ToList();
            return View(userTicket);
        }
    }
}
