using HW6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HW6.Controllers
{
    public class CategoryController : Controller
    {
        private AdventureContext db = new AdventureContext();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.ProductCategories.ToList());
        }

        public ActionResult Sub(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var subs = db.ProductSubcategories.Where(p => p.ProductCategoryID == (int)id).ToList();

            return View(subs);
        }
    }
}