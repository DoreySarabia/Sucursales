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
    public class Sucursal_AController : Controller
    {
        private DBSucusalEntities db = new DBSucusalEntities();

        // GET: Sucursal_A
        public ActionResult Index()
        {
            return View(db.Sucursal_A.ToList());
        }

        // GET: Sucursal_A/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal_A sucursal_A = db.Sucursal_A.Find(id);
            if (sucursal_A == null)
            {
                return HttpNotFound();
            }
            return View(sucursal_A);
        }

        // GET: Sucursal_A/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursal_A/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Código_barras,Cantidad,Precio_Unitario")] Sucursal_A sucursal_A)
        {
            if (ModelState.IsValid)
            {
                db.Sucursal_A.Add(sucursal_A);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sucursal_A);
        }

        // GET: Sucursal_A/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal_A sucursal_A = db.Sucursal_A.Find(id);
            if (sucursal_A == null)
            {
                return HttpNotFound();
            }
            return View(sucursal_A);
        }

        // POST: Sucursal_A/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Código_barras,Cantidad,Precio_Unitario")] Sucursal_A sucursal_A)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sucursal_A).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sucursal_A);
        }

        // GET: Sucursal_A/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sucursal_A sucursal_A = db.Sucursal_A.Find(id);
            if (sucursal_A == null)
            {
                return HttpNotFound();
            }
            return View(sucursal_A);
        }

        // POST: Sucursal_A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sucursal_A sucursal_A = db.Sucursal_A.Find(id);
            db.Sucursal_A.Remove(sucursal_A);
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
