using MvcApplicationDemo_err.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo_err.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        Employee e1 = new Employee() {Id=1,Name ="Raj", Gender ="Male",City ="London" };
        public ActionResult Index()
        {
            return View(e1);
        }
        public ActionResult Create()
        {
            return View();
        }
          [HttpPost]
          public ActionResult Create(Employee e)
          {
              if (e.Name == "Raj")
              {
                  ModelState.AddModelError(String.Empty, "Duplicate name not allowed");
                  return View(e);
              }
              return View("Details",e);
          }
       /* [HttpPost]
        public ActionResult Create(FormCollection Values)
        {
            e1.Name = Values["Name"];
            e1.Gender = Values["Gender"];
            e1.City = Values["City"];
            
            return View("Details", e1);
        }*/


    }
}
