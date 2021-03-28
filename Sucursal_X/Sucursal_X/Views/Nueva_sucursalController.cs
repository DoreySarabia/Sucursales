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
    public class Nueva_sucursalController : Controller
    {
        private DBSucusalEntities db = new DBSucusalEntities();

        // GET: Nueva_sucursal
        public ActionResult Index()
        {
            return View(db.Nueva_sucursal.ToList());
        }

        // GET: Nueva_sucursal/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nueva_sucursal nueva_sucursal = db.Nueva_sucursal.Find(id);
            if (nueva_sucursal == null)
            {
                return HttpNotFound();
            }
            return View(nueva_sucursal);
        }

        // GET: Nueva_sucursal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nueva_sucursal/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Codigo_barras,Cantidad,Precio_unitario")] Nueva_sucursal nueva_sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Nueva_sucursal.Add(nueva_sucursal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nueva_sucursal);
        }

        // GET: Nueva_sucursal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nueva_sucursal nueva_sucursal = db.Nueva_sucursal.Find(id);
            if (nueva_sucursal == null)
            {
                return HttpNotFound();
            }
            return View(nueva_sucursal);
        }

        // POST: Nueva_sucursal/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Codigo_barras,Cantidad,Precio_unitario")] Nueva_sucursal nueva_sucursal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nueva_sucursal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nueva_sucursal);
        }

        // GET: Nueva_sucursal/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nueva_sucursal nueva_sucursal = db.Nueva_sucursal.Find(id);
            if (nueva_sucursal == null)
            {
                return HttpNotFound();
            }
            return View(nueva_sucursal);
        }

        // POST: Nueva_sucursal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nueva_sucursal nueva_sucursal = db.Nueva_sucursal.Find(id);
            db.Nueva_sucursal.Remove(nueva_sucursal);
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
