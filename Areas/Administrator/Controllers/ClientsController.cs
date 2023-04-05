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
    public class ClientsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;
        public ClientsController(AppDbContext context , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Administrator/Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

        // GET: Administrator/Clients/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Administrator/Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                string imgName = UploadNewImage(client);

                Client cc = new Client
                {
                    ClientName = client.ClientName,
                    ClientDesc = client.ClientDesc,
                    ClientImg = imgName,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false
                };
                
                _context.Add(cc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        public string UploadNewImage(ClientViewModel model)
        {
            string newFullImageName = null;
            if (model.ClientImg != null)
            {
                string fileRoot = Path.Combine(_hostEnvironment.WebRootPath, @"img\");
                string newFileName = Guid.NewGuid() + "_" + model.ClientImg.FileName;
                string FullPath = Path.Combine(fileRoot, newFileName);
                using (var myNewFile = new FileStream(FullPath, FileMode.Create))
                {
                    model.ClientImg.CopyTo(myNewFile);
                }
                newFullImageName = @"img\" + newFileName;
                return newFullImageName;
            }
            return newFullImageName;
        }

        // GET: Administrator/Clients/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Administrator/Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ClientId,ClientName,ClientDesc,ClientImg,IsDeleted,IsActive,CreationDate,ModificationDate")] Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientId))
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
            return View(client);
        }

        // GET: Administrator/Clients/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Administrator/Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(Guid id)
        {
            return _context.Clients.Any(e => e.ClientId == id);
        }
    }
}
