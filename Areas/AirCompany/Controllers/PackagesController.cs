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
using DemoTraveler.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Identity;

namespace DemoTraveler.Areas.AirCompany.Controllers
{
    [Area("AirCompany")]
    public class PackagesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private UserManager<ApplicationUser> _userManager;
        public PackagesController(AppDbContext context , IWebHostEnvironment hostEnvironment,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
        }

        public IActionResult Index(string CountryName)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            string loggedUser = _userManager.GetUserId(User);
            if (loggedUser == null)
            {
                return NotFound();
            }

            ViewData["CurrentFilter"] = CountryName;
            var package = from p in _context.Packages.Where(p => p.ApplicationUser.Id == loggedUser)
                          select p;
            if (!String.IsNullOrEmpty(CountryName))
            {
                package = package.Where(t => t.CountryName.Contains(CountryName));
            }
            return View(package);
        }

        // GET: AirCompany/Packages
        //public async Task<IActionResult> Index()
        //{
        //    var appDbContext = _context.Packages.Include(p => p.Country);
        //    return View(await appDbContext.ToListAsync());
        //}

        // GET: AirCompany/Packages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages.FirstOrDefaultAsync(m => m.PackageId == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // GET: AirCompany/Packages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirCompany/Packages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(PackageViewModel package)
        {
            if (!ModelState.IsValid)
            {
                return View(package);
            }

            var userId = _userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                string imgName = UploadNewImage(package);

                Package pp = new Package
                {
                    ApplicationUserId = userId,
                    CountryImg = imgName,
                    CountryName = package.CountryName,
                    Duration = package.Duration,
                    Person = package.Person,
                    CountryDesc = package.CountryDesc,
                    BrandName = package.BrandName,
                    Price = package.Price,
                    HotelStars = package.HotelStars,
                    DepartDate = package.DepartDate,
                    ReturnDate = package.ReturnDate,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false
                };
                _context.Add(pp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(package);
        }

        public string UploadNewImage(PackageViewModel model)
        {
            string newFullImageName = null;
            if (model.CountryImg != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.CountryImg.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.CountryImg.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        // GET: AirCompany/Packages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages.FindAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            return View(package);
        }

        // POST: AirCompany/Packages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PackageViewModel package)
        {
            string imgName = UploadNewImage(package);

            if (id != package.PackageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var pa = await _context.Packages.FindAsync(id);
                if (pa == null)
                {
                    return NotFound();
                }

                pa.CountryImg = imgName;
                pa.CountryName = package.CountryName;
                pa.Duration = package.Duration;
                pa.Person = package.Person;
                pa.CountryDesc = package.CountryDesc;
                pa.BrandName = package.BrandName;
                pa.Price = package.Price;
                pa.HotelStars = package.HotelStars;
                pa.DepartDate = package.DepartDate;
                pa.ReturnDate = package.ReturnDate;
                pa.CreationDate = DateTime.Now;
                pa.ModificationDate = DateTime.Now;
                pa.IsActive = true;
                pa.IsDeleted = false;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(package);
        }

        // GET: AirCompany/Packages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages.FirstOrDefaultAsync(m => m.PackageId == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // POST: AirCompany/Packages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var package = await _context.Packages.FindAsync(id);
            _context.Packages.Remove(package);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackageExists(int id)
        {
            return _context.Packages.Any(e => e.PackageId == id);
        }
    }
}
