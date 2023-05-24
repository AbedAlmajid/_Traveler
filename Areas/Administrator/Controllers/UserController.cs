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
                    UserName = model.FirstName + "" + model.LastName,
                    PhoneNumber = model.PhoneNumber
                };

                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
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

        public IActionResult UserDetails(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;

            var userDetail = new ApplicationUser
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(userDetail);
        }

        [HttpGet]
        public IActionResult EditUser(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }
            var userEdit = new RegisterViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult EditUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.FindByIdAsync(model.Id).Result;

                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;
                    user.PhoneNumber = model.PhoneNumber;


                    var result = userManager.UpdateAsync(user).Result;

                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(UserList));
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to update profile.");
                    }
                }
                else
                {
                    // Handle user not found
                    return NotFound();
                }
            }

            // If the model state is invalid, return to the edit view with the updated model state
            return View(model);
        }

        [HttpGet]
        public IActionResult UserDelete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = userManager.FindByIdAsync(id).Result;

            var userEdit = new ApplicationUser
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(userEdit);
        }



        [HttpPost]
        public async Task<IActionResult> UserDelete(string id , RegisterViewModel model)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                var userTickets = db.UserTickets.Where(ut => ut.ApplicationUserId == user.Id);
                db.UserTickets.RemoveRange(userTickets);
                await db.SaveChangesAsync();

                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(UserList));
                }
                else
                {
                    ModelState.AddModelError("", "Failed To Delete User");
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("UserDelete", id);
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
        public  IActionResult DeleteRole(string id, DeleteRoleViewModel model)
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
                        ModelState.AddModelError("", "Failed To Delete Role");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Role Not Found");
            }
            return View("DeleteRole", id);
        }


        #endregion

        #region UserRole

        public async Task<IActionResult> UserRoleList()
        {
            var roles = roleManager.Roles.ToList();
            var roleViewModels = new List<UserRoleViewModel>();

            foreach (var role in roles)
            {
                var usersInRole = await userManager.GetUsersInRoleAsync(role.Name);
                var viewModel = new UserRoleViewModel
                {
                    RoleName = role.Name,
                    Users = usersInRole.Select(u => u.UserName).ToList()
                };
                roleViewModels.Add(viewModel);
            }

            return View(roleViewModels);
        }

        [HttpGet]
        public IActionResult CreateUserRole()
        {
            var users = userManager.Users.ToList();
            var roles = roleManager.Roles.ToList();

            var userRoleViewModel = new UserRole
            {
                Users = new SelectList(users, "Id", "UserName"),
                Roles = new SelectList(roles, "Id", "Name")
            };
            return View(userRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRole(UserRole userRoleViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(userRoleViewModel.UserId);
                var role = await roleManager.FindByIdAsync(userRoleViewModel.RoleId);

                if (user != null && role != null)
                {
                    var isInRole = await userManager.IsInRoleAsync(user, role.Name);

                    if (!isInRole)
                    {
                        var result = await userManager.AddToRoleAsync(user, role.Name);

                        if (result.Succeeded)
                        {
                            //var timeOut = TimeSpan.FromSeconds(30);
                            //userManager.RemoveFromRoleAsync(user, role.Name, timeOut);
                            return RedirectToAction(nameof(UserRoleList));
                        }
                        else
                        {
                            ModelState.AddModelError("", "Failed to assign role to user.");
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

            }
            ModelState.AddModelError("", "Is Already Taken");
            userRoleViewModel.Users = new SelectList(userManager.Users.ToList(), "Id", "UserName");
            userRoleViewModel.Roles = new SelectList(roleManager.Roles.ToList(), "Id", "Name");

            return View("UserRoleList", userRoleViewModel);


        }
        #endregion



    }
}
