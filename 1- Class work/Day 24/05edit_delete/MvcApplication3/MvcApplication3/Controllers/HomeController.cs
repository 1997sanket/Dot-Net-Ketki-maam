using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Employeelayer e1 = new Employeelayer();
        
        public ActionResult Index()
        {

            return View(e1.Employees);
        }
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {


            if (ModelState.IsValid)
            {
                int a=e1.store(e);
               
                return RedirectToAction("Index");

            }      
            return View(e);
        }
        
        public ActionResult Details(int Id)
        {
          Employee es = e1.Display(Id);
       
            return View(es);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee es = e1.Display(id);

            return View(es);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            if (ModelState.IsValid)
            {
                int es = e1.update(e);

                return RedirectToAction("Index");
            }
            return View(e);
        }
        
        public ActionResult Delete(int Id)
        {
            Employee es = e1.Display(Id);

            return View(es);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Deletetf(int Id)
        {
            int d = e1.deldata(Id);

            return RedirectToAction("Index");
            }
          
        
    }
}
