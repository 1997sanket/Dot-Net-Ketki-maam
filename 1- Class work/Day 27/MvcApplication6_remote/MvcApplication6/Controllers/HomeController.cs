using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication6.Models;

namespace MvcApplication6.Controllers
{
    public class HomeController : Controller
    {
        private MyDataEntities db = new MyDataEntities();

        //
        // GET: /Home/
        public JsonResult IsUserNameAvailable(string UserName)
        {
            return Json(!db.tblusers.Any(x => x.UserName == UserName),JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View(db.tblusers.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            tbluser tbluser = db.tblusers.Find(id);
            if (tbluser == null)
            {
                return HttpNotFound();
            }
            return View(tbluser);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(tbluser tbluser)
        {
            if (ModelState.IsValid)
            {
                db.tblusers.Add(tbluser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbluser);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tbluser tbluser = db.tblusers.Find(id);
            if (tbluser == null)
            {
                return HttpNotFound();
            }
            return View(tbluser);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(tbluser tbluser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbluser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbluser);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbluser tbluser = db.tblusers.Find(id);
            if (tbluser == null)
            {
                return HttpNotFound();
            }
            return View(tbluser);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tbluser tbluser = db.tblusers.Find(id);
            db.tblusers.Remove(tbluser);
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