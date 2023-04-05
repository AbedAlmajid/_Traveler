using DemoTraveler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.ViewComponents
{
    public class AboutUsViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public AboutUsViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.AboutUs.OrderByDescending(a => a.CreationDate).Take(1));
        }

    }
}
