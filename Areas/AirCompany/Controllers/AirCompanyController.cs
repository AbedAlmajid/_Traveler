using DemoTraveler.Models;
using DemoTraveler.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Areas.AirCompany.Controllers
{
    [Area("AirCompany")]
    public class AirCompanyController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
