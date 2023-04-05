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
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;
using System.Globalization;



namespace DemoTraveler.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class TravelsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;
        private readonly IViewLocalizer _localizer;

        public TravelsController(AppDbContext context , IWebHostEnvironment hostEnvironment,
           IViewLocalizer localizer)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _localizer = localizer;
        }

        // GET: Administrator/Travels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Travels.ToListAsync());
        }

        // GET: Administrator/Travels/Details/5
        public async Task<IActionResult> Details(Guid? id)
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
        public async Task<IActionResult> Edit(Guid? id)
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
        public async Task<IActionResult> Edit(TravelViewModel travel)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    string imgName = UploadNewImage(travel);

                    Travel tt = new Travel
                    {
                        TravelName = travel.TravelName,
                        TravelImg = imgName,
                        CreationDate = DateTime.Now,
                        ModificationDate = DateTime.Now,
                        IsActive = true,
                        IsDeleted =false
                    };
                    _context.Update(tt);
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
        public async Task<IActionResult> Delete(Guid? id)
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
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var travel = await _context.Travels.FindAsync(id);
            _context.Travels.Remove(travel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelExists(Guid id)
        {
            return _context.Travels.Any(e => e.TravelId == id);
        }
    }
}
