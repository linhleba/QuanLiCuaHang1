using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLiCuaHang.Areas.Manager.Data;

namespace QuanLiCuaHang.Areas.Manager.Controllers
{
    public class PhieuBanHangController : Controller
    {
        private QUANLYCUAHANGEntity db = new QUANLYCUAHANGEntity();

        // GET: Manager/PhieuBanHang
        public ActionResult Index()
        {
            return View(db.PHIEUBANHANGs.ToList());
        }

        // GET: Manager/PhieuBanHang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUBANHANG pHIEUBANHANG = db.PHIEUBANHANGs.Find(id);
            if (pHIEUBANHANG == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUBANHANG);
        }

        // GET: Manager/PhieuBanHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/PhieuBanHang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPBH,TenKH,NgayLap,TongTien")] PHIEUBANHANG pHIEUBANHANG)
        {
            if (ModelState.IsValid)
            {
                db.PHIEUBANHANGs.Add(pHIEUBANHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHIEUBANHANG);
        }

        // GET: Manager/PhieuBanHang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUBANHANG pHIEUBANHANG = db.PHIEUBANHANGs.Find(id);
            if (pHIEUBANHANG == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUBANHANG);
        }

        // POST: Manager/PhieuBanHang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPBH,TenKH,NgayLap,TongTien")] PHIEUBANHANG pHIEUBANHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEUBANHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHIEUBANHANG);
        }

        // GET: Manager/PhieuBanHang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUBANHANG pHIEUBANHANG = db.PHIEUBANHANGs.Find(id);
            if (pHIEUBANHANG == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUBANHANG);
        }

        // POST: Manager/PhieuBanHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHIEUBANHANG pHIEUBANHANG = db.PHIEUBANHANGs.Find(id);
            db.PHIEUBANHANGs.Remove(pHIEUBANHANG);
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
