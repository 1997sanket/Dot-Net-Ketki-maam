using System;
using MvcApplication3.Models;
using System.Web.Mvc;

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
         [HttpGet]
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
            return View();
        }

    }
}
