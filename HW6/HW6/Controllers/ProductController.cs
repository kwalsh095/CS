using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HW6.Controllers
{
    public class ProductController : Controller
    {
        private AdventureContext db = new AdventureContext();

        // GET: Product
        public ActionResult List(int? id)
        {
            if (id == null)
            {
                return View(db.Products.ToList());
            }

            return View(db.Products.Where(p => p.ProductSubcategoryID == id).ToList());
        }

        public ActionResult Details(int? id)
        {
            var product = db.Products.Find(id);

            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(product);
        }
    }
}