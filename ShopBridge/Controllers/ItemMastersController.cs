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
    public class ItemMastersController : Controller
    {
        private ShopBridgeEntities2 db = new ShopBridgeEntities2();

        // GET: ItemMasters
        public ActionResult Index()
        {
            return View(db.ItemMasters.ToList());
        }

        // GET: ItemMasters/Details/5
        public ActionResult Details(int? id)
        {
           

           
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemMaster itemMaster = db.ItemMasters.Find(id);
            try
            {

                if (itemMaster == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(itemMaster);
            //return View("Details");
        }

        // GET: ItemMasters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemId,ItenName,Quantity,Price,Dicount,ItemType")] ItemMaster itemMaster)
        {
            try
            {

          
                if (ModelState.IsValid)
                {
                    db.ItemMasters.Add(itemMaster);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(itemMaster);
        }

        // GET: ItemMasters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemMaster itemMaster = db.ItemMasters.Find(id);
            try
            {

            
                if (itemMaster == null)
                {
                    return HttpNotFound();
                }
            }
            catch(Exception ex)
            {
                return View("Error");
            }
            return View(itemMaster);
            
        }

        // POST: ItemMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemId,ItenName,Quantity,Price,Dicount,ItemType")] ItemMaster itemMaster)
        {
            try
            {

          
            if (ModelState.IsValid)
            {
                db.Entry(itemMaster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(itemMaster);
        }

        // GET: ItemMasters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemMaster itemMaster = db.ItemMasters.Find(id);
            try
            {

                if (itemMaster == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }

            return View(itemMaster);
        }

        // POST: ItemMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemMaster itemMaster = db.ItemMasters.Find(id);
            db.ItemMasters.Remove(itemMaster);
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
