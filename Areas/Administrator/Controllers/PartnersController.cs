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

namespace DemoTraveler.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class PartnersController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;
        public PartnersController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Administrator/Partners
        public IActionResult Index(string partnerName)
        {
            //return View(await _context.Travels.ToListAsync());
            ViewData["CurrentFilter"] = partnerName;
            var partners = from t in _context.Partners
                          select t;
            if (!String.IsNullOrEmpty(partnerName))
            {
                partners = partners.Where(t => t.PartnerName.Contains(partnerName));
            }
            return View(partners);
        }

        // GET: Administrator/Partners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.PartnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Administrator/Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Partners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PartnerViewModel partner)
        {
            string imgName = UploadNewImage(partner);
            if (ModelState.IsValid)
            {
                Partner pp = new Partner
                {
                    PartnerName = partner.PartnerName,
                    PartnerJop = partner.PartnerJop,
                    PartnerImg = imgName,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false
                };
                _context.Add(pp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        public string UploadNewImage(PartnerViewModel model)
        {
            string newFullImageName = null;
            if (model.PartnerImg != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.PartnerImg.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.PartnerImg.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        // GET: Administrator/Partners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Administrator/Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PartnerViewModel partner)
        {
            string imgName = UploadNewImage(partner);
            if (id != partner.PartnerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var par = await _context.Partners.FindAsync(id);
                if (par == null)
                {
                    return NotFound();
                }
                par.PartnerName = partner.PartnerName;
                par.PartnerJop = partner.PartnerJop;
                par.PartnerImg = imgName;
                par.CreationDate = DateTime.Now;
                par.ModificationDate = DateTime.Now;
                par.IsActive = true;
                par.IsDeleted = false;
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        // GET: Administrator/Partners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.PartnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // POST: Administrator/Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partner = await _context.Partners.FindAsync(id);
            _context.Partners.Remove(partner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartnerExists(int id)
        {
            return _context.Partners.Any(e => e.PartnerId == id);
        }
    }
}
