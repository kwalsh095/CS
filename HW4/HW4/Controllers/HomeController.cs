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

        [HttpGet]
        public ActionResult Loan()
        {
            return View();
        }

        //Do the calculations for the loan
        [HttpPost]
        public ActionResult Loan(double? pv, double? r, int? n)
        {

            if (pv == null || r == null || n == null || n < 1 || r < 0.01)
            {
                ViewBag.result = "You've typed an invalid value, please try again.";
                return View();
            }

            r = r /100 / 12;
            n = n * 12;
            double? temp = (r / (Math.Pow(1 + (double)r, (int)n) - 1));
            double? result = (r + temp) * pv;

            ViewBag.result = String.Format("{0:0.00}", result);
            ViewBag.sum = String.Format("{0:0.00}", result * n);

            ViewBag.txt1 = "Monthly Payment: $";
            ViewBag.txt2 = "Sum of payments: $";

            return View();
        }


    }
}