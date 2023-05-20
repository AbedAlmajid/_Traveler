using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoTraveler.Data;
using DemoTraveler.Models;

namespace DemoTraveler.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class UserTicketsController : Controller
    {
        private readonly AppDbContext _context;

        public UserTicketsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/UserTickets
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.UserTickets.Include(u => u.ApplicationUser).Include(u => u.Ticket);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Administrator/UserTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userTicket = await _context.UserTickets
                .Include(u => u.ApplicationUser)
                .Include(u => u.Ticket)
                .FirstOrDefaultAsync(m => m.UserTicketId == id);
            if (userTicket == null)
            {
                return NotFound();
            }

            return View(userTicket);
        }

        // GET: Administrator/UserTickets/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "ArriveTime");
            return View();
        }

        // POST: Administrator/UserTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserTicketId,ApplicationUserId,TicketId")] UserTicket userTicket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userTicket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", userTicket.ApplicationUserId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "ArriveTime", userTicket.TicketId);
            return View(userTicket);
        }

        // GET: Administrator/UserTickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userTicket = await _context.UserTickets.FindAsync(id);
            if (userTicket == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", userTicket.ApplicationUserId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "ArriveTime", userTicket.TicketId);
            return View(userTicket);
        }

        // POST: Administrator/UserTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserTicketId,ApplicationUserId,TicketId")] UserTicket userTicket)
        {
            if (id != userTicket.UserTicketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userTicket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserTicketExists(userTicket.UserTicketId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", userTicket.ApplicationUserId);
            ViewData["TicketId"] = new SelectList(_context.Tickets, "TicketId", "ArriveTime", userTicket.TicketId);
            return View(userTicket);
        }

        // GET: Administrator/UserTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userTicket = await _context.UserTickets
                .Include(u => u.ApplicationUser)
                .Include(u => u.Ticket)
                .FirstOrDefaultAsync(m => m.UserTicketId == id);
            if (userTicket == null)
            {
                return NotFound();
            }

            return View(userTicket);
        }

        // POST: Administrator/UserTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userTicket = await _context.UserTickets.FindAsync(id);
            _context.UserTickets.Remove(userTicket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserTicketExists(int id)
        {
            return _context.UserTickets.Any(e => e.UserTicketId == id);
        }
    }
}
