using DemoTraveler.Data;
using DemoTraveler.Models;
using DemoTraveler.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Areas.Administrator.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [Area("Administrator")]
        public async Task<IActionResult> MyProfile()
        {
            var user = await _userManager.GetUserAsync(User);

            var userProfile = new ApplicationUserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDay = user.BirthDay,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email
            };

            return View(userProfile);
        }
    }
}
