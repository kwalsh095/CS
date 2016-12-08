using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final.DAL;
using Final.Models;

namespace Final.Controllers
{
    public class ActorsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: Actors
        public ActionResult Index()
        {
            return View(db.Actors.ToList());
        }

    }
}
