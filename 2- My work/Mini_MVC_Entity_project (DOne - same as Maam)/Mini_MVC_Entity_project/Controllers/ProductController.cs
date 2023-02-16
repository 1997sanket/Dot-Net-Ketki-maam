using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mini_MVC_Entity_project.Models;
using System.Web.Security;

namespace Mini_MVC_Entity_project.Controllers
{
    public class ProductController : Controller
    {
        private Model1Container db = new Model1Container();

        //
        // GET: /Product/

        public ActionResult Welcome()
        {
            
            
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.img = "Content/Images/MacBook.jpg";
            
            return View(db.Products.ToList());
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


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            User x = db.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();

            if (x != null)
            {
                //Add in cookie
                FormsAuthentication.SetAuthCookie(x.Email, false);

                return RedirectToAction("Search");
            }

            ViewBag.invalidUser = "Invalid User";
            return View();
        }


        [HttpGet, Authorize]
        public ActionResult Search()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Search(String name)
        {
            Product product = db.Products.Where(p => p.Name == name).FirstOrDefault();

            if (product != null)
            {
                
                return View("Details", product);
            }

            ViewBag.wrongLogin = "wrongLogin";
            return View();
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