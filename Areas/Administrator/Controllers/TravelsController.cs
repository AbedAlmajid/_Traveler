﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoTraveler.Data;
using DemoTraveler.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using DemoTraveler.Models.ViewModels;

namespace DemoTraveler.Areas.Administrator
{
    [Area("Administrator")]
    public class TravelsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;
        public TravelsController(AppDbContext context , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Administrator/Travels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Travels.ToListAsync());
        }

        // GET: Administrator/Travels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travel = await _context.Travels
                .FirstOrDefaultAsync(m => m.TravelId == id);
            if (travel == null)
            {
                return NotFound();
            }

            return View(travel);
        }

        // GET: Administrator/Travels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Travels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(TravelViewModel travel)
        {
            if (ModelState.IsValid)
            {
                string imgName = UploadNewImage(travel);

                Travel tt = new Travel
                {
                    TravelName = travel.TravelName,
                    TravelImg = imgName,
                    IsDeleted = false,
                    IsActive = true,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                };
                _context.Add(tt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travel);
        }

        public string UploadNewImage(TravelViewModel model)
        {
            string newFullImageName = null;
            if (model.TravelImg != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.TravelImg.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.TravelImg.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        // GET: Administrator/Travels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travel = await _context.Travels.FindAsync(id);
            if (travel == null)
            {
                return NotFound();
            }
            return View(travel);
        }

        // POST: Administrator/Travels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TravelId,TravelName,TravelImg,IsDeleted,IsActive,CreationDate,ModificationDate")] Travel travel)
        {
            if (id != travel.TravelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelExists(travel.TravelId))
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
            return View(travel);
        }

        // GET: Administrator/Travels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travel = await _context.Travels
                .FirstOrDefaultAsync(m => m.TravelId == id);
            if (travel == null)
            {
                return NotFound();
            }

            return View(travel);
        }

        // POST: Administrator/Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travel = await _context.Travels.FindAsync(id);
            _context.Travels.Remove(travel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelExists(int id)
        {
            return _context.Travels.Any(e => e.TravelId == id);
        }
    }
}
