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
    public class tableCsController : Controller
    {
        private DbcsContext db = new DbcsContext();

        // GET: tableCs
        public ActionResult Index()
        {
            return View(db.tableCs.ToList());
        }

        // GET: tableCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableC tableC = db.tableCs.Find(id);
            if (tableC == null)
            {
                return HttpNotFound();
            }
            return View(tableC);
        }

        // GET: tableCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tableCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] tableC tableC)
        {
            if (ModelState.IsValid)
            {
                db.tableCs.Add(tableC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableC);
        }

        // GET: tableCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableC tableC = db.tableCs.Find(id);
            if (tableC == null)
            {
                return HttpNotFound();
            }
            return View(tableC);
        }

        // POST: tableCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] tableC tableC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableC);
        }

        // GET: tableCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableC tableC = db.tableCs.Find(id);
            if (tableC == null)
            {
                return HttpNotFound();
            }
            return View(tableC);
        }

        // POST: tableCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tableC tableC = db.tableCs.Find(id);
            db.tableCs.Remove(tableC);
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
