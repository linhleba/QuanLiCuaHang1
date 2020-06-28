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
    public class TT_LoaiDichVuController : Controller
    {
        private QUANLYCUAHANGEntity db = new QUANLYCUAHANGEntity();

        // GET: Manager/TT_LoaiDichVu
        public ActionResult Index()
        {
            return View(db.TINHTRANGDVs.ToList());
        }

        // GET: Manager/TT_LoaiDichVu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINHTRANGDV tINHTRANGDV = db.TINHTRANGDVs.Find(id);
            if (tINHTRANGDV == null)
            {
                return HttpNotFound();
            }
            return View(tINHTRANGDV);
        }

        // GET: Manager/TT_LoaiDichVu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/TT_LoaiDichVu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTinhTrangDV,TenTinhTrang")] TINHTRANGDV tINHTRANGDV)
        {
            if (ModelState.IsValid)
            {
                db.TINHTRANGDVs.Add(tINHTRANGDV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tINHTRANGDV);
        }

        // GET: Manager/TT_LoaiDichVu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINHTRANGDV tINHTRANGDV = db.TINHTRANGDVs.Find(id);
            if (tINHTRANGDV == null)
            {
                return HttpNotFound();
            }
            return View(tINHTRANGDV);
        }

        // POST: Manager/TT_LoaiDichVu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTinhTrangDV,TenTinhTrang")] TINHTRANGDV tINHTRANGDV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tINHTRANGDV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tINHTRANGDV);
        }

        // GET: Manager/TT_LoaiDichVu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TINHTRANGDV tINHTRANGDV = db.TINHTRANGDVs.Find(id);
            if (tINHTRANGDV == null)
            {
                return HttpNotFound();
            }
            return View(tINHTRANGDV);
        }

        // POST: Manager/TT_LoaiDichVu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TINHTRANGDV tINHTRANGDV = db.TINHTRANGDVs.Find(id);
            db.TINHTRANGDVs.Remove(tINHTRANGDV);
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
