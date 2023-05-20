using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoTraveler.Data;
using DemoTraveler.Models;
using Microsoft.AspNetCore.Hosting;
using DemoTraveler.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Identity;

namespace DemoTraveler.Areas.AirCompany.Controllers
{
    [Area("AirCompany")]
    public class TicketsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public TicketsController(AppDbContext context , IWebHostEnvironment hostEnvironment,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string toCountry)
        {
            ViewData["CurrentFilter"] = toCountry;

            var loggedInUser = await _userManager.GetUserAsync(HttpContext.User);
            var tickets = from t in _context.Tickets
                          select t;

            if (!String.IsNullOrEmpty(toCountry))
            {
                tickets = tickets.Where(t => t.ToCountry.Contains(toCountry));
            }

            var ticket = await _context.Tickets.Where(t => t.ApplicationUserId == loggedInUser.Id).ToListAsync();
            return View(ticket);
        }

        // GET: AirCompany/Tickets
        //public async Task<IActionResult> Index()
        //{
        //    var appDbContext = _context.Tickets.Include(t => t.FlightType).Include(t => t.TicketType).Include(t => t.Travel);
        //    return View(await appDbContext.ToListAsync());
        //}

        // GET: AirCompany/Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.FlightType)
                .Include(t => t.TicketType)
                .Include(t => t.Travel)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: AirCompany/Tickets/Create
        public IActionResult Create()
        {
            ViewData["FlightTypeId"] = new SelectList(_context.FlightTypes, "FlightTypeId", "TypeFlight");
            ViewData["TicketTypeId"] = new SelectList(_context.TicketTypes, "TicketTypeId", "TypeTicket");
            ViewData["TravelId"] = new SelectList(_context.Travels, "TravelId", "TravelName");
            return View();
        }

        // POST: AirCompany/Tickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketViewModel ticket)
        {
            if (ModelState.IsValid)
            {
                string imgName = UploadNewImage(ticket);

                Ticket tt = new Ticket
                {
                    FlyBrand = imgName,
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
                    FlightTypeId = ticket.FlightTypeId
                };

                _context.Add(tt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FlightTypeId"] = new SelectList(_context.FlightTypes, "FlightTypeId", "TypeFlight", ticket.FlightTypeId);
            ViewData["TicketTypeId"] = new SelectList(_context.TicketTypes, "TicketTypeId", "TypeTicket", ticket.TicketTypeId);
            ViewData["TravelId"] = new SelectList(_context.Travels, "TravelId", "Travel", ticket.TravelId);
            return View(ticket);
        }

        public string UploadNewImage(TicketViewModel model)
        {
            string newFullImageName = null;
            if (model.FlyBrand != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.FlyBrand.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.FlyBrand.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        // GET: AirCompany/Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["FlightTypeId"] = new SelectList(_context.FlightTypes, "FlightTypeId", "TypeFlight", ticket.FlightTypeId);
            ViewData["TicketTypeId"] = new SelectList(_context.TicketTypes, "TicketTypeId", "TypeTicket", ticket.TicketTypeId);
            ViewData["TravelId"] = new SelectList(_context.Travels, "TravelId", "TravelImg", ticket.TravelId);
            return View(ticket);
        }

        // POST: AirCompany/Tickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,TicketViewModel ticket)
        {
            string imgName = UploadNewImage(ticket);

            if (id != ticket.TicketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var ti = await _context.Tickets.FindAsync(id);
                if (ti == null)
                {
                    return NotFound();
                }

                ti.FlyBrand = imgName;
                ti.BrandName = ticket.BrandName;
                ti.FromCountry = ticket.FromCountry;
                ti.ToCountry = ticket.ToCountry;
                ti.FromAirport = ticket.FromAirport;
                ti.ToAirport = ticket.ToAirport;
                ti.DepartTime = ticket.DepartTime;
                ti.ArriveTime = ticket.ArriveTime;
                ti.DepartDate = ticket.DepartDate;
                ti.FlightDuration = ticket.FlightDuration;
                ti.Weight = ticket.Weight;
                ti.Price = ticket.Price;
                ti.TravelId = ticket.TravelId;
                ti.TicketTypeId = ticket.TicketTypeId;
                ti.FlightTypeId = ticket.FlightTypeId;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FlightTypeId"] = new SelectList(_context.FlightTypes, "FlightTypeId", "TypeFlight", ticket.FlightTypeId);
            ViewData["TicketTypeId"] = new SelectList(_context.TicketTypes, "TicketTypeId", "TypeTicket", ticket.TicketTypeId);
            ViewData["TravelId"] = new SelectList(_context.Travels, "TravelId", "TravelName", ticket.TravelId);
            return View(ticket);
        }

        // GET: AirCompany/Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.FlightType)
                .Include(t => t.TicketType)
                .Include(t => t.Travel)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: AirCompany/Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.TicketId == id);
        }
    }
}
