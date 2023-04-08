using DemoTraveler.Data;
using DemoTraveler.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext db;
        public AccountController(AppDbContext _db)
        {
            db = _db;
        }
        
        public IActionResult Register()
        {
            ViewBag.Roles = new SelectList(db.Roles, "RoleId", "RoleName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(User user)
        {
            user.CreationDate = DateTime.Now;
            user.ModificationDate = DateTime.Now;
            user.IsDeleted = false;
            user.IsActive = true;

            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var data = db.Users.Where(x => x.UserName == user.UserName &&
            x.Password == user.Password);

            if (data.Any())
            {
                HttpContext.Session.SetString("name", user.UserName);
                return RedirectToAction("Index", "Dashboard", new { area = "Administrator" });
            }
            return View(user);
        } 

        public async Task<IActionResult> LogoutAsync(User user)
        {
            HttpContext.Session.Clear();
            await db.SaveChangesAsync();
            return RedirectToAction("Login");
        }
    }
}

