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

        //Use a Get request in a form.
        public ActionResult Page1()
        {
            if (!String.IsNullOrEmpty(Request.QueryString["food"]))
            {
                string food = "My favorite food is also " + Request.QueryString["food"];
                ViewBag.foodData = food;
            }
                        
            return View();
        }


        //Called initially, before we post anything to the server.
        [HttpGet]
        public ActionResult Page2()
        {

            return View();
        }

        //Called when we submit the form.
        [HttpPost]
        public ActionResult Page2(FormCollection form)
        {
            ViewBag.message = form["food"] + " is delicious!";
            return View();
        }

        public ActionResult Loan()
        {

            return View();
        }


    }
}