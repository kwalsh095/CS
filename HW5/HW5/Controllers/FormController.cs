using HW5.DAL;
using System;
using System.Collections.Generic;
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
    }
}