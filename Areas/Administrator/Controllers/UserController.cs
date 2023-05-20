using DemoTraveler.Data;
using DemoTraveler.Models;
using DemoTraveler.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Areas.Administrator.Controllers
{

    [Area("Administrator")]
    public class UserController : Controller
    {
        private readonly AppDbContext db;
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private SignInManager<ApplicationUser> signInManager;
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserController(AppDbContext _db ,
            UserManager<ApplicationUser> _userManager,
            RoleManager<IdentityRole> _roleManager,
            SignInManager<ApplicationUser> _signInManager,
            IHttpContextAccessor _httpContextAccessor)
        {
            db = _db;
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
            httpContextAccessor = _httpContextAccessor;
        }


        #region User

        public IActionResult UserList()
        {
            return View(db.Users.ToList());
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.FirstName,
                    PhoneNumber = model.PhoneNumber
                };

                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(UserList));
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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email,
                    model.Password, true, false);

                if (result.Succeeded)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);

                    if (user != null)
                    {
                        string userId = user.Id;
                        string email = user.Email;
                        httpContextAccessor.HttpContext.Session.SetString("UserId", user.Id);
                    }

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid User or Password");
                return View(model);
            }
            return View(model);
        }

        #endregion

        #region Role

        public IActionResult RoleList()
        {
            var roles = roleManager.Roles.Select(r => new RoleViewModel
            {
                RoleId = r.Id,
                Name = r.Name
            }).ToList();

            return View(roles);
        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel role)
        {
            if (ModelState.IsValid)
            {
                Role rr = new Role
                {
                    Name = role.Name
                };
                var result = await roleManager.CreateAsync(rr);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(RoleList));
                }
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError("" , x.Description);
                    return View(role);
                }
            }
            return View(role);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            EditRoleViewModel model = new EditRoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(string id , EditRoleViewModel role)
        {
            if (id != role.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var ro = await roleManager.FindByIdAsync(id);
                if (ro == null)
                {
                    return NotFound();
                }
                ro.Name = role.RoleName;

                await db.SaveChangesAsync();
                return RedirectToAction(nameof(RoleList));
            }
            return View(role);
        }

        [HttpGet]
        public IActionResult DeleteRole(string id)
        {
            var role = roleManager.FindByIdAsync(id).Result;

            if (role == null)
            {
                // Handle case when role is not found
                return RedirectToAction(nameof(RoleList));
            }

            var viewModel = new DeleteRoleViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        public  IActionResult ConfirmDeleteRole(string id)
        {
            var role = roleManager.FindByIdAsync(id).Result;
            if (role != null)
            {
                var result = roleManager.DeleteAsync(role).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(RoleList));
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Role NoT Found.");
            }
            return View("DeleteRole", new DeleteRoleViewModel { RoleId = id });
        }

        
        #endregion

        #region UserRole

        public IActionResult UserRoleList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateUserRole()
        {
            var users = userManager.Users.ToList();
            var roles = roleManager.Roles.ToList();

            var userRoleViewModel = new UserRoleViewModel
            {
                Users = new SelectList(users, "Id", "UserName"),
                Roles = new SelectList(roles, "Id", "Name")
            };
            return View(userRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRole(UserRoleViewModel userRoleViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(userRoleViewModel.UserId);
                var role = await roleManager.FindByIdAsync(userRoleViewModel.RoleId);

                if (user != null && role != null)
                {
                    var result = await userManager.AddToRoleAsync(user, role.Name);

                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(UserRoleList));
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                
            }
            userRoleViewModel.Users = new SelectList(userManager.Users.ToList(), "Id", "UserName");
            userRoleViewModel.Roles = new SelectList(roleManager.Roles.ToList(), "Id", "Name");

            return View("UserRoleList", userRoleViewModel);


        }
        #endregion



    }
}
