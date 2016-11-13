using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW6.Controllers
{

    public class HomeController : Controller
    {
        private AdventureContext db = new AdventureContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}