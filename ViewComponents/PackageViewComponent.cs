using DemoTraveler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.ViewComponents
{
    public class PackageViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public PackageViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Packages.OrderByDescending(p => p.CreationDate).Take(6));
        }
    }
}
