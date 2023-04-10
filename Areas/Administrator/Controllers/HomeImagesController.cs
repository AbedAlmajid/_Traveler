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
    public class HomeImagesController : Controller
    {
        private readonly AppDbContext _context;

        public HomeImagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/HomeImages
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeImages.ToListAsync());
        }

        // GET: Administrator/HomeImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeImage = await _context.HomeImages
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (homeImage == null)
            {
                return NotFound();
            }

            return View(homeImage);
        }

        // GET: Administrator/HomeImages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/HomeImages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImageId,Imagea,Imageb,IsDeleted,IsActive,CreationDate,ModificationDate")] HomeImage homeImage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeImage);
        }

        // GET: Administrator/HomeImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeImage = await _context.HomeImages.FindAsync(id);
            if (homeImage == null)
            {
                return NotFound();
            }
            return View(homeImage);
        }

        // POST: Administrator/HomeImages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImageId,Imagea,Imageb,IsDeleted,IsActive,CreationDate,ModificationDate")] HomeImage homeImage)
        {
            if (id != homeImage.ImageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeImageExists(homeImage.ImageId))
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
            return View(homeImage);
        }

        // GET: Administrator/HomeImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeImage = await _context.HomeImages
                .FirstOrDefaultAsync(m => m.ImageId == id);
            if (homeImage == null)
            {
                return NotFound();
            }

            return View(homeImage);
        }

        // POST: Administrator/HomeImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeImage = await _context.HomeImages.FindAsync(id);
            _context.HomeImages.Remove(homeImage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeImageExists(int id)
        {
            return _context.HomeImages.Any(e => e.ImageId == id);
        }
    }
}
