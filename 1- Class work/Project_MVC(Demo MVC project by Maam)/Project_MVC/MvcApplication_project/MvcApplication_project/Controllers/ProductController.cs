using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_project.Models;
using System.Web.Security;

namespace MvcApplication_project.Controllers
{
    
    public class ProductController : Controller
    {
        private DemodataEntities db = new DemodataEntities();

        //
        // GET: /Product/

        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Login(tbluser tuser)
        {
            var r = (from rng in db.tblusers where rng.UserName == tuser.UserName && rng.Password ==tuser.Password  select rng).FirstOrDefault<tbluser>();
            if (r != null)
            {
                FormsAuthentication.SetAuthCookie(r.UserName, false); 
                return RedirectToAction("Search"); 
            }
            else
                ViewBag.invaliduser = "Invalid user";
            return View();
        }


        [HttpGet, Authorize]
        public ActionResult Search()
        {
            return View();
        }
        
        [HttpPost]
          public ActionResult Search(string pname)
        {
            var result = from rng in db.Product_pro where rng.Name == pname select rng;
            return View("Display",result);
        }
        public ActionResult Index()
        {
            return View(db.Product_pro.ToList());
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id = 0)
        {
            Product_pro product_pro = db.Product_pro.Find(id);
            if (product_pro == null)
            {
                return HttpNotFound();
            }
            return View(product_pro);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(Product_pro product_pro)
        {
            if (ModelState.IsValid)
            {
                db.Product_pro.Add(product_pro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product_pro);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Product_pro product_pro = db.Product_pro.Find(id);
            if (product_pro == null)
            {
                return HttpNotFound();
            }
            return View(product_pro);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(Product_pro product_pro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_pro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product_pro);
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Product_pro product_pro = db.Product_pro.Find(id);
            if (product_pro == null)
            {
                return HttpNotFound();
            }
            return View(product_pro);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Product_pro product_pro = db.Product_pro.Find(id);
            db.Product_pro.Remove(product_pro);
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