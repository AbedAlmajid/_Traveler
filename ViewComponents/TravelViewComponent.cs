using DemoTraveler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.ViewComponents
{
    public class TravelViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public TravelViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Travels.OrderByDescending(T => T.CreationDate).Take(6));
        }
    }
}
