using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoTraveler.Data;
using DemoTraveler.Models;
using DemoTraveler.Models.ViewModels;

namespace DemoTraveler.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class TicketTypesController : Controller
    {
        private readonly AppDbContext _context;

        public TicketTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/TicketTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TicketTypes.ToListAsync());
        }

        // GET: Administrator/TicketTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketType = await _context.TicketTypes
                .FirstOrDefaultAsync(m => m.TicketTypeId == id);
            if (ticketType == null)
            {
                return NotFound();
            }

            return View(ticketType);
        }

        // GET: Administrator/TicketTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/TicketTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketTypeViewModel ticketType)
        {
            if (ModelState.IsValid)
            {
                TicketType ti = new TicketType
                {
                    TypeTicket = ticketType.TypeTicket
                };

                _context.Add(ti);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketType);
        }

        // GET: Administrator/TicketTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketType = await _context.TicketTypes.FindAsync(id);
            if (ticketType == null)
            {
                return NotFound();
            }
            return View(ticketType);
        }

        // POST: Administrator/TicketTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TicketTypeViewModel ticketType)
        {
            if (id != ticketType.TicketTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var ti = await _context.TicketTypes.FindAsync(id);
                if (ti == null)
                {
                    return NotFound();
                }
                ti.TypeTicket = ticketType.TypeTicket;
                ti.CreationDate = DateTime.Now;
                ti.ModificationDate = DateTime.Now;
                ti.IsActive = true;
                ti.IsDeleted = false;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketType);
        }

        // GET: Administrator/TicketTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketType = await _context.TicketTypes
                .FirstOrDefaultAsync(m => m.TicketTypeId == id);
            if (ticketType == null)
            {
                return NotFound();
            }

            return View(ticketType);
        }

        // POST: Administrator/TicketTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticketType = await _context.TicketTypes.FindAsync(id);
            _context.TicketTypes.Remove(ticketType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketTypeExists(int id)
        {
            return _context.TicketTypes.Any(e => e.TicketTypeId == id);
        }
    }
}
