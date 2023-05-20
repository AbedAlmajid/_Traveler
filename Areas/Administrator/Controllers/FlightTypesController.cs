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
    public class FlightTypesController : Controller
    {
        private readonly AppDbContext _context;

        public FlightTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/FlightTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FlightTypes.ToListAsync());
        }

        // GET: Administrator/FlightTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightType = await _context.FlightTypes
                .FirstOrDefaultAsync(m => m.FlightTypeId == id);
            if (flightType == null)
            {
                return NotFound();
            }

            return View(flightType);
        }

        // GET: Administrator/FlightTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/FlightTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FlightTypeViewModel flightType)
        { 
            if (ModelState.IsValid)
            {
                FlightType ft = new FlightType
                {
                    TypeFlight = flightType.TypeFlight
                };
                _context.Add(ft);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightType);
        }

        // GET: Administrator/FlightTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightType = await _context.FlightTypes.FindAsync(id);
            if (flightType == null)
            {
                return NotFound();
            }
            return View(flightType);
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FlightTypeViewModel flightType)
        {
            if (id != flightType.FlightTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var ft = await _context.FlightTypes.FindAsync(id);
                if (ft == null)
                {
                    return NotFound();
                }
                ft.TypeFlight = flightType.TypeFlight;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightType);
        }

        // GET: Administrator/FlightTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightType = await _context.FlightTypes
                .FirstOrDefaultAsync(m => m.FlightTypeId == id);
            if (flightType == null)
            {
                return NotFound();
            }

            return View(flightType);
        }

        // POST: Administrator/FlightTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightType = await _context.FlightTypes.FindAsync(id);
            _context.FlightTypes.Remove(flightType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightTypeExists(int id)
        {
            return _context.FlightTypes.Any(e => e.FlightTypeId == id);
        }
    }
}
