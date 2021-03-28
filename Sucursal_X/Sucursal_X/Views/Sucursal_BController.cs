using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sucursal_X.Models;

namespace Sucursal_X.Views
{
    public class Sucursal_BController : Controller
    {
        private DBSucusalEntities db = new DBSucusalEntities();

        // GET: Sucursal_B
        public ActionResult Index()
        {
            return View(db.Sucursal_B.ToList());
        }

        // GET: Sucursal_B/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal_B sucursal_B = db.Sucursal_B.Find(id);
            if (sucursal_B == null)
            {
                return HttpNotFound();
            }
            return View(sucursal_B);
        }

        // GET: Sucursal_B/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursal_B/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Código_barras,Cantidad,Precio_unitario")] Sucursal_B sucursal_B)
        {
            if (ModelState.IsValid)
            {
                db.Sucursal_B.Add(sucursal_B);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sucursal_B);
        }

        // GET: Sucursal_B/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal_B sucursal_B = db.Sucursal_B.Find(id);
            if (sucursal_B == null)
            {
                return HttpNotFound();
            }
            return View(sucursal_B);
        }

        // POST: Sucursal_B/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Código_barras,Cantidad,Precio_unitario")] Sucursal_B sucursal_B)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sucursal_B).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sucursal_B);
        }

        // GET: Sucursal_B/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal_B sucursal_B = db.Sucursal_B.Find(id);
            if (sucursal_B == null)
            {
                return HttpNotFound();
            }
            return View(sucursal_B);
        }

        // POST: Sucursal_B/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sucursal_B sucursal_B = db.Sucursal_B.Find(id);
            db.Sucursal_B.Remove(sucursal_B);
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
