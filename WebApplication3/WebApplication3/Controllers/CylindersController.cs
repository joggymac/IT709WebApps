using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Car_Database.Models;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CylindersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cylinders
        public ActionResult Index()
        {
            return View(db.Cylinders.ToList());
        }

        // GET: Cylinders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cylinder cylinder = db.Cylinders.Find(id);
            if (cylinder == null)
            {
                return HttpNotFound();
            }
            return View(cylinder);
        }

        // GET: Cylinders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cylinders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CylinderID,Type")] Cylinder cylinder)
        {
            if (ModelState.IsValid)
            {
                db.Cylinders.Add(cylinder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cylinder);
        }

        // GET: Cylinders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cylinder cylinder = db.Cylinders.Find(id);
            if (cylinder == null)
            {
                return HttpNotFound();
            }
            return View(cylinder);
        }

        // POST: Cylinders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CylinderID,Type")] Cylinder cylinder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cylinder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cylinder);
        }

        // GET: Cylinders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cylinder cylinder = db.Cylinders.Find(id);
            if (cylinder == null)
            {
                return HttpNotFound();
            }
            return View(cylinder);
        }

        // POST: Cylinders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cylinder cylinder = db.Cylinders.Find(id);
            db.Cylinders.Remove(cylinder);
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
