using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineHouseRenting.Models;

namespace OnlineHouseRenting.Controllers
{
    public class tbl_adminController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_admin
        public ActionResult Index()
        {
            return View(db.tbl_admin.ToList());
        }

        // GET: tbl_admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_admin tbl_admin = db.tbl_admin.Find(id);
            if (tbl_admin == null)
            {
                return HttpNotFound();
            }
            return View(tbl_admin);
        }

        // GET: tbl_admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ADMIN_ID,ADMIN_CONTACT,ADMIN_EMAIL,ADMIN_PASSWORD,ADMIN_ADDRESS")] tbl_admin tbl_admin)
        {
            if (ModelState.IsValid)
            {
                db.tbl_admin.Add(tbl_admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_admin);
        }

        // GET: tbl_admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_admin tbl_admin = db.tbl_admin.Find(id);
            if (tbl_admin == null)
            {
                return HttpNotFound();
            }
            return View(tbl_admin);
        }

        // POST: tbl_admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ADMIN_ID,ADMIN_CONTACT,ADMIN_EMAIL,ADMIN_PASSWORD,ADMIN_ADDRESS")] tbl_admin tbl_admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_admin);
        }

        // GET: tbl_admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_admin tbl_admin = db.tbl_admin.Find(id);
            if (tbl_admin == null)
            {
                return HttpNotFound();
            }
            return View(tbl_admin);
        }

        // POST: tbl_admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_admin tbl_admin = db.tbl_admin.Find(id);
            db.tbl_admin.Remove(tbl_admin);
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
