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
    public class DirectorsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: Directors
        public ActionResult Index()
        {
            return View(db.Directors.ToList());
        }
    }
}
