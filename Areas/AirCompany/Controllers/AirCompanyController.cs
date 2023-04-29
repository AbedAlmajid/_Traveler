using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Areas.AirCompany.Controllers
{
    public class AirCompanyController : Controller
    {
        [Area("AirCompany")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
