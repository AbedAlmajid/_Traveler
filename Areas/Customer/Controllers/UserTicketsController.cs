using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoTraveler.Data;
using DemoTraveler.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace DemoTraveler.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UserTicketsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private UserManager<ApplicationUser> _userManager;
        public UserTicketsController(AppDbContext context , 
            IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyTicket(int ticketId, int bookingId)
        {
            // Retrieve the authenticated user
            var user = await _userManager.GetUserAsync(User);

            // Retrieve the ticket and booking based on the provided IDs
            var ticket = await _context.Tickets.FindAsync(ticketId);
            var booking = await _context.Bookings.FindAsync(bookingId);

            // Create a new UserTicket object
            var userTicket = new UserTicket
            {
                ApplicationUser = user,
                Ticket = ticket,
                Booking = booking
            };

            // Save the UserTicket object to the database
            _context.UserTickets.Add(userTicket);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "UserTicket");
        }
    }
}
