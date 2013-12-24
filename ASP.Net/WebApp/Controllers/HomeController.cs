using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
      private Entities db;

        //
        // GET: /Default1/

        public HomeController()
        {
          db = new Entities();
        }
        public HomeController(Entities entities)
        {
          db = entities;
        }

        public ActionResult Index()
        {
            return View(db.ValuesTable.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            ValuesTable values = db.ValuesTable.Find(id);
            if (values == null)
            {
                return HttpNotFound();
            }
            return View(values);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(ValuesTable values)
        {
            if (ModelState.IsValid)
            {
                db.ValuesTable.Add(values);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(values);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ValuesTable values = db.ValuesTable.Find(id);
            if (values == null)
            {
                return HttpNotFound();
            }
            return View(values);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(ValuesTable values)
        {
            if (ModelState.IsValid)
            {
                db.Entry(values).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(values);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ValuesTable values = db.ValuesTable.Find(id);
            if (values == null)
            {
                return HttpNotFound();
            }
            return View(values);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ValuesTable values = db.ValuesTable.Find(id);
            db.ValuesTable.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}