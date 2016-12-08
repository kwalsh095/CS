using Final.DAL;
using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetActors()
        {
            var data = db.Actors.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMovies(int id)
        {
            var data = db.Casts.Join(db.Movies,
                         t => t.MovieID,
                         a => a.ID,
                        (t, a) => new { t.Actor, t.Movie, a.Director, t.ActorID })
                    .Where(p => p.ActorID == id)
                    .ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}