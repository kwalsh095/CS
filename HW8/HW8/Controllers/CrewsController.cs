using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.DAL;
using HW8.Models;

namespace HW8.Controllers
{
    public class CrewsController : Controller
    {
        private PirateContext db = new PirateContext();

        // GET: Crews
        public ActionResult Index()
        {
            var crews = db.Crews.Include(c => c.Pirate).Include(c => c.Ship);
            return View(crews.ToList());
        }

    }
}
