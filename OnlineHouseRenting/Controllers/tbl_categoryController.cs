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
    public class tbl_categoryController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_category
        public ActionResult Index()
        {
            return View(db.tbl_category.ToList());
        }

        // GET: tbl_category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_category tbl_category = db.tbl_category.Find(id);
            if (tbl_category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_category);
        }

        // GET: tbl_category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HOUSE_ID,HOUSE_CATEGORY")] tbl_category tbl_category)
        {
            if (ModelState.IsValid)
            {
                db.tbl_category.Add(tbl_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_category);
        }

        // GET: tbl_category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_category tbl_category = db.tbl_category.Find(id);
            if (tbl_category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_category);
        }

        // POST: tbl_category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HOUSE_ID,HOUSE_CATEGORY")] tbl_category tbl_category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_category);
        }

        // GET: tbl_category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_category tbl_category = db.tbl_category.Find(id);
            if (tbl_category == null)
            {
                return HttpNotFound();
            }
            return View(tbl_category);
        }

        // POST: tbl_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_category tbl_category = db.tbl_category.Find(id);
            db.tbl_category.Remove(tbl_category);
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
