using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DnDApp.Models;

namespace DnDApp.Controllers
{
    public class tableAsController : Controller
    {
        private DbcsContext db = new DbcsContext();

        // GET: tableAs
        public ActionResult Index()
        {
            return View(db.tableAs.ToList());
        }

        // GET: tableAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableA tableA = db.tableAs.Find(id);
            if (tableA == null)
            {
                return HttpNotFound();
            }
            return View(tableA);
        }

        // GET: tableAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tableAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] tableA tableA)
        {
            if (ModelState.IsValid)
            {
                db.tableAs.Add(tableA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableA);
        }

        // GET: tableAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableA tableA = db.tableAs.Find(id);
            if (tableA == null)
            {
                return HttpNotFound();
            }
            return View(tableA);
        }

        // POST: tableAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] tableA tableA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableA);
        }

        // GET: tableAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableA tableA = db.tableAs.Find(id);
            if (tableA == null)
            {
                return HttpNotFound();
            }
            return View(tableA);
        }

        // POST: tableAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tableA tableA = db.tableAs.Find(id);
            db.tableAs.Remove(tableA);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
