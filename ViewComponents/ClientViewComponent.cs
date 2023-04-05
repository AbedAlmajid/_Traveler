using DemoTraveler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.ViewComponents
{
    public class ClientViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public ClientViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            return View(db.Clients.OrderByDescending(c => c.CreationDate).Take(4));
        }

    }

    
}
