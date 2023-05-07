using DemoTraveler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.ViewComponents
{
    public class PartnerViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public PartnerViewComponent(AppDbContext _db)
        {
           db =_db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Partners.OrderByDescending(p => p.CreationDate).Take(4));
        }
    }
}
