using HW8.DAL;
using HW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW8.Controllers
{
    public class AjaxController : Controller
    {
        private PirateContext db = new PirateContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetBooty()
        {

            List<BootyList> data;
            data = db.Crews.Join(db.Pirates,
                         t => t.PirateID,
                         a => a.ID,
                        (t, a) => new { a.Name, t.Booty })
                    .GroupBy(l => l.Name)
                    .Select(lg =>
                        new BootyList
                        {
                            Name = lg.Key,
                            Total = lg.Sum(w => w.Booty)
                        })
                    .OrderByDescending(p => p.Total)
                    .ToList();


            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}