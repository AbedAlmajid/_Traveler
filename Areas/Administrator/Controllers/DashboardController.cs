using DemoTraveler.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Areas.Administrator.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
