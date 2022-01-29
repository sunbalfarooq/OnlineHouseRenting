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
    public class tbl_house_detailController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_house_detail
        public ActionResult Index()
        {
            var tbl_house_detail = db.tbl_house_detail.Include(t => t.tbl_category);
            return View(tbl_house_detail.ToList());
        }

        // GET: tbl_house_detail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_detail tbl_house_detail = db.tbl_house_detail.Find(id);
            if (tbl_house_detail == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_detail);
        }

        // GET: tbl_house_detail/Create
        public ActionResult Create()
        {
            ViewBag.HOUSE_CATEGORY_FID = new SelectList(db.tbl_category, "HOUSE_ID", "HOUSE_CATEGORY");
            return View();
        }

        // POST: tbl_house_detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HOUSE_DETAIL_ID,HOUSE_ORDER,HOUSE_PIC,HOUSE_DESCRIPTION,HOUSE_STATUS,HOUSE_CATEGORY_FID")] tbl_house_detail tbl_house_detail)
        {
            if (ModelState.IsValid)
            {
                db.tbl_house_detail.Add(tbl_house_detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HOUSE_CATEGORY_FID = new SelectList(db.tbl_category, "HOUSE_ID", "HOUSE_CATEGORY", tbl_house_detail.HOUSE_CATEGORY_FID);
            return View(tbl_house_detail);
        }

        // GET: tbl_house_detail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_detail tbl_house_detail = db.tbl_house_detail.Find(id);
            if (tbl_house_detail == null)
            {
                return HttpNotFound();
            }
            ViewBag.HOUSE_CATEGORY_FID = new SelectList(db.tbl_category, "HOUSE_ID", "HOUSE_CATEGORY", tbl_house_detail.HOUSE_CATEGORY_FID);
            return View(tbl_house_detail);
        }

        // POST: tbl_house_detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HOUSE_DETAIL_ID,HOUSE_ORDER,HOUSE_PIC,HOUSE_DESCRIPTION,HOUSE_STATUS,HOUSE_CATEGORY_FID")] tbl_house_detail tbl_house_detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_house_detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HOUSE_CATEGORY_FID = new SelectList(db.tbl_category, "HOUSE_ID", "HOUSE_CATEGORY", tbl_house_detail.HOUSE_CATEGORY_FID);
            return View(tbl_house_detail);
        }

        // GET: tbl_house_detail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_house_detail tbl_house_detail = db.tbl_house_detail.Find(id);
            if (tbl_house_detail == null)
            {
                return HttpNotFound();
            }
            return View(tbl_house_detail);
        }

        // POST: tbl_house_detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_house_detail tbl_house_detail = db.tbl_house_detail.Find(id);
            db.tbl_house_detail.Remove(tbl_house_detail);
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
