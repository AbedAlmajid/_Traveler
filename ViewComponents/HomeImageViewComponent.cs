using DemoTraveler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.ViewComponents
{
    public class HomeImageViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public HomeImageViewComponent(AppDbContext _db)
        {
            db = _db;
        }
        
        public IViewComponentResult Invoke()
        {
            return View(db.HomeImages.OrderByDescending(I => I.CreationDate).Take(2));
        }
    }
}
