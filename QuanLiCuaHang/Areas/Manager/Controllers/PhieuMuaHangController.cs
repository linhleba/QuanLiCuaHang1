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
    public class PhieuMuaHangController : Controller
    {
        private QUANLYCUAHANGEntity db = new QUANLYCUAHANGEntity();

        // GET: Manager/PhieuMuaHang
        public ActionResult Index()
        {
            var pHIEUMUAHANGs = db.PHIEUMUAHANGs.Include(p => p.NHACUNGCAP);
            return View(pHIEUMUAHANGs.ToList());
        }

        // GET: Manager/PhieuMuaHang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUMUAHANG pHIEUMUAHANG = db.PHIEUMUAHANGs.Find(id);
            if (pHIEUMUAHANG == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUMUAHANG);
        }

        // GET: Manager/PhieuMuaHang/Create
        public ActionResult Create()
        {
            ViewBag.MaNCC = new SelectList(db.NHACUNGCAPs, "MaNCC", "TenNCC");
            return View();
        }

        // POST: Manager/PhieuMuaHang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPMH,NgayLap,TongTien,MaNCC")] PHIEUMUAHANG pHIEUMUAHANG)
        {
            if (ModelState.IsValid)
            {
                db.PHIEUMUAHANGs.Add(pHIEUMUAHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNCC = new SelectList(db.NHACUNGCAPs, "MaNCC", "TenNCC", pHIEUMUAHANG.MaNCC);
            return View(pHIEUMUAHANG);
        }

        // GET: Manager/PhieuMuaHang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUMUAHANG pHIEUMUAHANG = db.PHIEUMUAHANGs.Find(id);
            if (pHIEUMUAHANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNCC = new SelectList(db.NHACUNGCAPs, "MaNCC", "TenNCC", pHIEUMUAHANG.MaNCC);
            return View(pHIEUMUAHANG);
        }

        // POST: Manager/PhieuMuaHang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPMH,NgayLap,TongTien,MaNCC")] PHIEUMUAHANG pHIEUMUAHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEUMUAHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNCC = new SelectList(db.NHACUNGCAPs, "MaNCC", "TenNCC", pHIEUMUAHANG.MaNCC);
            return View(pHIEUMUAHANG);
        }

        // GET: Manager/PhieuMuaHang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUMUAHANG pHIEUMUAHANG = db.PHIEUMUAHANGs.Find(id);
            if (pHIEUMUAHANG == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUMUAHANG);
        }

        // POST: Manager/PhieuMuaHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHIEUMUAHANG pHIEUMUAHANG = db.PHIEUMUAHANGs.Find(id);
            db.PHIEUMUAHANGs.Remove(pHIEUMUAHANG);
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
