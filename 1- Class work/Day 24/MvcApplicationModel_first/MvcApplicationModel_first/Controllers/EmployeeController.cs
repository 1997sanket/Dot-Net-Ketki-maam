using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationModel_first.Models;

namespace MvcApplicationModel_first.Controllers
{
    public class EmployeeController : Controller
    {
        private ModelempdeptContainer db = new ModelempdeptContainer();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var empdacs = db.Empdacs.Include(e => e.Deptdac);
            return View(empdacs.ToList());
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 1)
        {
            Empdac empdac = db.Empdacs.Find(id);
            if (empdac == null)
            {
                return HttpNotFound();
            }
            return View(empdac);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            ViewBag.DeptdacId = new SelectList(db.Deptdacs, "Id", "Name");
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(Empdac empdac)
        {
            if (ModelState.IsValid)
            {
                db.Empdacs.Add(empdac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DeptdacId = new SelectList(db.Deptdacs, "Id", "Name", empdac.DeptdacId);
            return View(empdac);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Empdac empdac = db.Empdacs.Find(id);
            if (empdac == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeptdacId = new SelectList(db.Deptdacs, "Id", "Name", empdac.DeptdacId);
            return View(empdac);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(Empdac empdac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empdac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptdacId = new SelectList(db.Deptdacs, "Id", "Name", empdac.DeptdacId);
            return View(empdac);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Empdac empdac = db.Empdacs.Find(id);
            if (empdac == null)
            {
                return HttpNotFound();
            }
            return View(empdac);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Empdac empdac = db.Empdacs.Find(id);
            db.Empdacs.Remove(empdac);
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