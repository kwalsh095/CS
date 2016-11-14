using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW6.Controllers
{
    public class ReviewController : Controller
    {
        private AdventureContext db = new AdventureContext();

        // GET: Review
        public ActionResult Index(int? ProductID)
        {
            if (ProductID == null)
            { return View(); }

            ViewBag.ID = ProductID;
            return View();
        }

        [HttpPost]
        public ActionResult Index(ProductReview review)
        {
            if (ModelState.IsValid)
            {
                review.ReviewDate = DateTime.Now;
                review.ModifiedDate = DateTime.Now;
                db.ProductReviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("../Home/Index");
            }
                return View(review);
        }

        public ActionResult List()
        {
            return View(db.ProductReviews.OrderByDescending(p => p.ReviewDate).ToList());
        }
    }
}