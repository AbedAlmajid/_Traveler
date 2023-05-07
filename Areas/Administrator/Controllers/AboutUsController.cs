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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace DemoTraveler.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class AboutUsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;
        public AboutUsController(AppDbContext context , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Administrator/AboutUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutUs.ToListAsync());
        }

        // GET: Administrator/AboutUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUs = await _context.AboutUs
                .FirstOrDefaultAsync(m => m.AboutUsId == id);
            if (aboutUs == null)
            {
                return NotFound();
            }

            return View(aboutUs);
        }

      
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AboutUsViewModel aboutUs)
        {
            if (ModelState.IsValid)
            {
                string imgName1 = UploadNewImage1(aboutUs);
                string imgName2 = UploadNewImage2(aboutUs);
                string imgName3 = UploadNewImage3(aboutUs);

                AboutUs aa = new AboutUs
                {
                    Title = aboutUs.Title,
                    AboutUsDescription = aboutUs.AboutUsDescription,
                    AboutImg1 = imgName1,
                    AboutImg2 = imgName2,
                    AboutImg3 = imgName3,
                    IsActive = true,
                    IsDeleted = false,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now
                };
                _context.Add(aa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUs);
        }


        public string UploadNewImage1(AboutUsViewModel model)
        {
            string newFullImageName = null;
            if (model.AboutImg1 != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.AboutImg1.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.AboutImg1.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        public string UploadNewImage2(AboutUsViewModel model)
        {
            string newFullImageName = null;
            if (model.AboutImg2 != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.AboutImg2.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.AboutImg2.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        public string UploadNewImage3(AboutUsViewModel model)
        {
            string newFullImageName = null;
            if (model.AboutImg3 != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.AboutImg3.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.AboutImg3.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }
        // GET: Administrator/AboutUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUs = await _context.AboutUs.FindAsync(id);
            if (aboutUs == null)
            {
                return NotFound();
            }
            return View(aboutUs);
        }

        // POST: Administrator/AboutUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AboutUsViewModel aboutUs)
        {
            string imgName1 = UploadNewImage1(aboutUs);
            string imgName2 = UploadNewImage2(aboutUs);
            string imgName3 = UploadNewImage3(aboutUs);

            if (id != aboutUs.AboutUsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var au = await _context.AboutUs.FindAsync();
                if (au == null)
                {
                    return NotFound();
                }
                au.Title = aboutUs.Title;
                au.AboutUsDescription = aboutUs.AboutUsDescription;
                au.AboutImg1 = imgName1;
                au.AboutImg2 = imgName2;
                au.AboutImg3 = imgName3;
                au.IsActive = true;
                au.IsDeleted = false;
                au.CreationDate = DateTime.Now;
                au.ModificationDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUs);
        }

        // GET: Administrator/AboutUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUs = await _context.AboutUs
                .FirstOrDefaultAsync(m => m.AboutUsId == id);
            if (aboutUs == null)
            {
                return NotFound();
            }

            return View(aboutUs);
        }

        // POST: Administrator/AboutUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutUs = await _context.AboutUs.FindAsync(id);
            _context.AboutUs.Remove(aboutUs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutUsExists(int id)
        {
            return _context.AboutUs.Any(e => e.AboutUsId == id);
        }
    }
}
