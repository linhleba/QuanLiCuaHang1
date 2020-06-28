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
    public class TT_PhieuDichVuController : Controller
    {
        private QUANLYCUAHANGEntity db = new QUANLYCUAHANGEntity();

        // GET: Manager/TT_PhieuDichVu
        public ActionResult Index()
        {
            return View(db.TINHTRANGPDVs.ToList());
        }

        // GET: Manager/TT_PhieuDichVu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINHTRANGPDV tINHTRANGPDV = db.TINHTRANGPDVs.Find(id);
            if (tINHTRANGPDV == null)
            {
                return HttpNotFound();
            }
            return View(tINHTRANGPDV);
        }

        // GET: Manager/TT_PhieuDichVu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/TT_PhieuDichVu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTinhTrangPDV,TenTinhTrang")] TINHTRANGPDV tINHTRANGPDV)
        {
            if (ModelState.IsValid)
            {
                db.TINHTRANGPDVs.Add(tINHTRANGPDV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tINHTRANGPDV);
        }

        // GET: Manager/TT_PhieuDichVu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINHTRANGPDV tINHTRANGPDV = db.TINHTRANGPDVs.Find(id);
            if (tINHTRANGPDV == null)
            {
                return HttpNotFound();
            }
            return View(tINHTRANGPDV);
        }

        // POST: Manager/TT_PhieuDichVu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTinhTrangPDV,TenTinhTrang")] TINHTRANGPDV tINHTRANGPDV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tINHTRANGPDV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tINHTRANGPDV);
        }

        // GET: Manager/TT_PhieuDichVu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINHTRANGPDV tINHTRANGPDV = db.TINHTRANGPDVs.Find(id);
            if (tINHTRANGPDV == null)
            {
                return HttpNotFound();
            }
            return View(tINHTRANGPDV);
        }

        // POST: Manager/TT_PhieuDichVu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TINHTRANGPDV tINHTRANGPDV = db.TINHTRANGPDVs.Find(id);
            db.TINHTRANGPDVs.Remove(tINHTRANGPDV);
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
