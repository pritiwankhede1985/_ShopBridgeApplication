using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShopBridge.ViewModels;

namespace ShopBridge.Controllers
{
    public class ManageMasterStocksController : Controller
    {
        private ShopBridgeEntities2 db = new ShopBridgeEntities2();

        // GET: ManageMasterStocks
        public ActionResult Index()
        {
            return View(db.ManageMasterStocks.ToList());
        }

        // GET: ManageMasterStocks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageMasterStock manageMasterStock = db.ManageMasterStocks.Find(id);
            if (manageMasterStock == null)
            {
                return HttpNotFound();
            }
            return View(manageMasterStock);
        }

        // GET: ManageMasterStocks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageMasterStocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemName,ItemId,MasterId,Stock")] ManageMasterStock manageMasterStock)
        {
            if (ModelState.IsValid)
            {
                db.ManageMasterStocks.Add(manageMasterStock);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manageMasterStock);
        }

        // GET: ManageMasterStocks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageMasterStock manageMasterStock = db.ManageMasterStocks.Find(id);
            if (manageMasterStock == null)
            {
                return HttpNotFound();
            }
            return View(manageMasterStock);
        }

        // POST: ManageMasterStocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemName,ItemId,MasterId,Stock")] ManageMasterStock manageMasterStock)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manageMasterStock).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manageMasterStock);
        }

        // GET: ManageMasterStocks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageMasterStock manageMasterStock = db.ManageMasterStocks.Find(id);
            if (manageMasterStock == null)
            {
                return HttpNotFound();
            }
            return View(manageMasterStock);
        }

        // POST: ManageMasterStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManageMasterStock manageMasterStock = db.ManageMasterStocks.Find(id);
            db.ManageMasterStocks.Remove(manageMasterStock);
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
