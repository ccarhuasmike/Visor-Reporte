using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Visor_Reporte.Common
{
    public class EjemploController : Controller
    {
        // GET: Ejemplo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ejemplo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ejemplo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ejemplo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ejemplo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ejemplo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ejemplo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ejemplo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
