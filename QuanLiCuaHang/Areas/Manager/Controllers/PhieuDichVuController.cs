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
    public class PhieuDichVuController : Controller
    {
        private QUANLYCUAHANGEntity db = new QUANLYCUAHANGEntity();

        // GET: Manager/PhieuDichVu
        public ActionResult Index()
        {
            var pHIEUDVs = db.PHIEUDVs.Include(p => p.TINHTRANGPDV);
            return View(pHIEUDVs.ToList());
        }

        // GET: Manager/PhieuDichVu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUDV pHIEUDV = db.PHIEUDVs.Find(id);
            if (pHIEUDV == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUDV);
        }

        // GET: Manager/PhieuDichVu/Create
        public ActionResult Create()
        {
            ViewBag.MaTinhTrangPDV = new SelectList(db.TINHTRANGPDVs, "MaTinhTrangPDV", "TenTinhTrang");
            return View();
        }

        // POST: Manager/PhieuDichVu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPDV,NgayLap,TenKH,SDT,TongTien,TongTienTraTruoc,TongTienConLai,MaTinhTrangPDV")] PHIEUDV pHIEUDV)
        {
            if (ModelState.IsValid)
            {
                db.PHIEUDVs.Add(pHIEUDV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTinhTrangPDV = new SelectList(db.TINHTRANGPDVs, "MaTinhTrangPDV", "TenTinhTrang", pHIEUDV.MaTinhTrangPDV);
            return View(pHIEUDV);
        }

        // GET: Manager/PhieuDichVu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUDV pHIEUDV = db.PHIEUDVs.Find(id);
            if (pHIEUDV == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTinhTrangPDV = new SelectList(db.TINHTRANGPDVs, "MaTinhTrangPDV", "TenTinhTrang", pHIEUDV.MaTinhTrangPDV);
            return View(pHIEUDV);
        }

        // POST: Manager/PhieuDichVu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPDV,NgayLap,TenKH,SDT,TongTien,TongTienTraTruoc,TongTienConLai,MaTinhTrangPDV")] PHIEUDV pHIEUDV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEUDV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTinhTrangPDV = new SelectList(db.TINHTRANGPDVs, "MaTinhTrangPDV", "TenTinhTrang", pHIEUDV.MaTinhTrangPDV);
            return View(pHIEUDV);
        }

        // GET: Manager/PhieuDichVu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEUDV pHIEUDV = db.PHIEUDVs.Find(id);
            if (pHIEUDV == null)
            {
                return HttpNotFound();
            }
            return View(pHIEUDV);
        }

        // POST: Manager/PhieuDichVu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHIEUDV pHIEUDV = db.PHIEUDVs.Find(id);
            db.PHIEUDVs.Remove(pHIEUDV);
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
