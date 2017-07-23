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
    public class DriveTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DriveTypes
        public ActionResult Index()
        {
            return View(db.DriveTypes.ToList());
        }

        // GET: DriveTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriveType driveType = db.DriveTypes.Find(id);
            if (driveType == null)
            {
                return HttpNotFound();
            }
            return View(driveType);
        }

        // GET: DriveTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DriveTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrveTypeID,Name")] DriveType driveType)
        {
            if (ModelState.IsValid)
            {
                db.DriveTypes.Add(driveType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(driveType);
        }

        // GET: DriveTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriveType driveType = db.DriveTypes.Find(id);
            if (driveType == null)
            {
                return HttpNotFound();
            }
            return View(driveType);
        }

        // POST: DriveTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrveTypeID,Name")] DriveType driveType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(driveType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(driveType);
        }

        // GET: DriveTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriveType driveType = db.DriveTypes.Find(id);
            if (driveType == null)
            {
                return HttpNotFound();
            }
            return View(driveType);
        }

        // POST: DriveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DriveType driveType = db.DriveTypes.Find(id);
            db.DriveTypes.Remove(driveType);
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
