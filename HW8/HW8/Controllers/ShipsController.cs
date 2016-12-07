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
    public class ShipsController : Controller
    {
        private PirateContext db = new PirateContext();

        // GET: Ships
        public ActionResult Index()
        {
            return View(db.Ships.ToList());
        }

        
    }
}
