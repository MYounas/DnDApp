using DnDApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnDApp.Controllers
{
    public class HomeController : Controller
    {

        DbcsContext db = new DbcsContext();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getList1()
        {
            var data = db.tableAs.ToList();
            return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult getList2()
        {
            var data = db.tableBs.ToList();
            return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult getList3()
        {
            var data = db.tableCs.ToList();
            return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public ActionResult updateList3(tableC TC)
        {
            db.tableCs.Add(TC);
            db.SaveChanges();
            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}