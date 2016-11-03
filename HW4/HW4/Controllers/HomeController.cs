using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            if (!String.IsNullOrEmpty(Request.QueryString["food"]))
            {
                string food = "My favorite food is also " + Request.QueryString["food"];
                ViewBag.foodData = food;
            }
                        
            return View();
        }


    }
}