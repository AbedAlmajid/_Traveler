using DemoTraveler.Data;
using DemoTraveler.Models;
using DemoTraveler.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
        }

        #region Users

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model, UserRoleViewModel userRoleViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CountryName = model.CountryName,
                    Gender = model.Gender,
                    Email = model.Email,
                    UserName = model.FirstName + "" + model.LastName,
                    PhoneNumber = model.PhoneNumber
                };

                var userExists = await _userManager.FindByEmailAsync(model.Email);
                if (userExists != null)
                {
                    ModelState.AddModelError(string.Empty, "Email address is already registered.");
                    return View(model);
                }

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var userId = await _userManager.FindByIdAsync(user.Id);
                    var role = "Customer";

                    if (userId != null && role != null)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(userId, "Customer");

                        if (!isInRole)
                        {
                            var resultRole = await _userManager.AddToRoleAsync(userId, "Customer");

                            if (resultRole.Succeeded)
                            {
                                return RedirectToAction("Login" ,"Account");
                            }
                            else
                            {
                                ModelState.AddModelError("", "Failed to assign Customer to user.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", "User is already in the selected role.");
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("", "User is already in the selected role.");
                    }
                    return RedirectToAction("Login", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View(model);
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Login()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user,
                    model.Password, false, true);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Email", "Password or Email is not valid");
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "Email Is Not Valid !");
                }

            }

            return View(model);
        }

        public async Task<IActionResult> logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        #endregion

    }
}