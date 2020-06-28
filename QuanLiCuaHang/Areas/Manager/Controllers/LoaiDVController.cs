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
    public class LoaiDVController : Controller
    {
        private QUANLYCUAHANGEntity db = new QUANLYCUAHANGEntity();

        // GET: Manager/LoaiDV
        public ActionResult Index()
        {
            return View(db.LOAIDVs.ToList());
        }

        // GET: Manager/LoaiDV/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIDV lOAIDV = db.LOAIDVs.Find(id);
            if (lOAIDV == null)
            {
                return HttpNotFound();
            }
            return View(lOAIDV);
        }

        // GET: Manager/LoaiDV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/LoaiDV/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiDV,TenLoaiDV,DonGiaDV")] LOAIDV lOAIDV)
        {
            if (ModelState.IsValid)
            {
                db.LOAIDVs.Add(lOAIDV);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAIDV);
        }

        // GET: Manager/LoaiDV/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIDV lOAIDV = db.LOAIDVs.Find(id);
            if (lOAIDV == null)
            {
                return HttpNotFound();
            }
            return View(lOAIDV);
        }

        // POST: Manager/LoaiDV/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiDV,TenLoaiDV,DonGiaDV")] LOAIDV lOAIDV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAIDV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAIDV);
        }

        // GET: Manager/LoaiDV/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAIDV lOAIDV = db.LOAIDVs.Find(id);
            if (lOAIDV == null)
            {
                return HttpNotFound();
            }
            return View(lOAIDV);
        }

        // POST: Manager/LoaiDV/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LOAIDV lOAIDV = db.LOAIDVs.Find(id);
            db.LOAIDVs.Remove(lOAIDV);
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
