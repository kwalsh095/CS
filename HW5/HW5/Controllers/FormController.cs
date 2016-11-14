using HW5.DAL;
using HW5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW5.Controllers
{
    public class FormController : Controller
    {
        private UserContext db = new UserContext();

        // GET: Form
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index"); 
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            return View(user);
        }
    }
}