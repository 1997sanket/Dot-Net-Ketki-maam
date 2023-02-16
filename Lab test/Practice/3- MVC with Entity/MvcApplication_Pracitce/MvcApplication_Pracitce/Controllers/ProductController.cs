using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_Pracitce.Models;
using System.Web.Security;

namespace MvcApplication_Pracitce.Controllers
{
    public class ProductController : Controller
    {
        private Practice_dbEntities db = new Practice_dbEntities();


        public ActionResult Welcome()
        {
            return View();
        }

        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(User u)
        {
            User x = db.Users.Where(user => user.Username == u.Username && user.Password == u.Password).FirstOrDefault();

            if (x != null)
            {
                //If valid user then only he can search for a product
                FormsAuthentication.SetAuthCookie(u.Username, false);

                //Add user in the session
                Session["name"] = u.Username;

                return RedirectToAction("Welcome");
            }

            ViewBag.invalid = "invalid";
            return View();
        }

        [HttpGet, Authorize]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(String pName)
        {
            Product p = db.Products.Where(product => product.Name == pName).FirstOrDefault();

            if (p != null)
                return View("Details", p);

            else
                return Content("No product found");
        }


        [HttpGet, Authorize]
        public ActionResult Logout()
        {
            ViewBag.name = Session["name"];

            //Delete session
            Session.RemoveAll();
            return View();
        }


        //
        // GET: /Product/Details/5

        public ActionResult Details(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
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
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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