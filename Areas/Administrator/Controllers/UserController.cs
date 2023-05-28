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


        #region User Admin

        [HttpGet]
        public async Task<IActionResult> UserListAdmin()
        {
            var adminRole = await roleManager.FindByNameAsync("Administrator");
            if (adminRole == null)
            {
                return NotFound();
            }
            var adminUser = await userManager.GetUsersInRoleAsync(adminRole.Name);

            return View(adminUser);
        }

        [HttpGet]
        public IActionResult CreateUserAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAdmin(RegisterViewModel model, UserRoleViewModel userRoleViewModel)
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

                    var userId = await userManager.FindByIdAsync(user.Id);
                    var role = "Administrator";

                    if (userId != null && role != null)
                    {
                        var isInRole = await userManager.IsInRoleAsync(userId, "Administrator");

                        if (!isInRole)
                        {
                            var resultRole = await userManager.AddToRoleAsync(userId, "Administrator");

                            if (result.Succeeded)
                            {
                                return RedirectToAction(nameof(UserListAdmin));
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
                    return RedirectToAction(nameof(UserListAdmin));
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
        public IActionResult UserDetails(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;

            var userDetail = new ApplicationUser
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.FirstName + " " + user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            return View(userDetail);
        }

        [HttpGet]
        public IActionResult EditUserAdmin(string id)
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
        public IActionResult EditUserAdmin(RegisterViewModel model)
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
                        return RedirectToAction(nameof(UserListAdmin));
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to update profile.");
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UserAdminDelete(string id)
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
        public async Task<IActionResult> UserAdminDelete(string id, RegisterViewModel model)
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
                    return RedirectToAction(nameof(UserListAdmin));
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


        #region User AirCompany

        [HttpGet]
        public async Task<IActionResult> UserListAirCompany()
        {
            var airCompanyRole = await roleManager.FindByNameAsync("AirCompany");
            if (airCompanyRole == null)
            {
                return NotFound();
            }
            var airCompanyUser = await userManager.GetUsersInRoleAsync(airCompanyRole.Name);

            return View(airCompanyUser);
        }

        [HttpGet]
        public IActionResult CreateUserAirCompany()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAirCompany(RegisterViewModel model, UserRoleViewModel userRoleViewModel)
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

                    var userId = await userManager.FindByIdAsync(user.Id);
                    var role = "AirCompany";

                    if (userId != null && role != null)
                    {
                        var isInRole = await userManager.IsInRoleAsync(userId, "AirCompany");

                        if (!isInRole)
                        {
                            var resultRole = await userManager.AddToRoleAsync(userId, "AirCompany");

                            if (result.Succeeded)
                            {
                                return RedirectToAction(nameof(UserListAirCompany));
                            }
                            else
                            {
                                ModelState.AddModelError("", "Failed to assign AirCompany to user.");
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
                    return RedirectToAction(nameof(UserListAirCompany));
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
        public IActionResult EditUserAirCompany(string id)
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
        public IActionResult EditUserAirCompany(RegisterViewModel model)
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
                        return RedirectToAction(nameof(UserListAirCompany));
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to update profile.");
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UserAirCompanyDelete(string id)
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
        public async Task<IActionResult> UserAirCompanyDelete(string id, RegisterViewModel model)
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
                    return RedirectToAction(nameof(UserListAdmin));
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




        #region User Customer

        #endregion
        [HttpGet]
        public async Task<IActionResult> UserListCustomer()
        {
            var CustomerRole = await roleManager.FindByNameAsync("Customer");
            if (CustomerRole == null)
            {
                return NotFound();
            }
            var customerUser = await userManager.GetUsersInRoleAsync(CustomerRole.Name);

            return View(customerUser);
        }


        [HttpGet]
        public IActionResult CreateUserCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserCustomer(RegisterViewModel model, UserRoleViewModel userRoleViewModel)
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

                    var userId = await userManager.FindByIdAsync(user.Id);
                    var role = "AirCompany";

                    if (userId != null && role != null)
                    {
                        var isInRole = await userManager.IsInRoleAsync(userId, "Customer");

                        if (!isInRole)
                        {
                            var resultRole = await userManager.AddToRoleAsync(userId, "Customer");

                            if (result.Succeeded)
                            {
                                return RedirectToAction(nameof(UserListCustomer));
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
                    return RedirectToAction(nameof(UserListCustomer));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View(model);
                }
            }
            return View(model);
        }






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
