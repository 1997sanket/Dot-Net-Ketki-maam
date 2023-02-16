using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/index

        public ActionResult Index()
        {
            return View();
        }


        // Home/about
        public ActionResult About()
        {
            return View();
        }


        // Home/Products
        public ActionResult Employees()
        {
            
            //Sending list of Employees to the Employees view
            return View(EmployeeLayer.Employees);
        }

        [HttpGet] //To show the form
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost] //on form submit
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid) //If Validation successful
            {
                EmployeeLayer.saveEmployee(e); //Save Employee in the database
                return RedirectToAction("Index");   //Return to Index page
            }

            return View(); //else show the same page
        }



        //Delete
        public ActionResult Delete(int id)
        {
            //int id = Convert.ToInt32(_id);

            var result = EmployeeLayer.deleteEmployee(id);

            if (result > 0)
            {
                return RedirectToAction("Index");
            }


            return RedirectToAction("Create");
        }


        //Update
        public ActionResult Update()
        {
            return View();
        }
       

        //on Update submit
        [HttpPost]
        public ActionResult Update(Employee e)
        {
            var result = EmployeeLayer.updateEmployee(e);

            if (result > 0)
                return RedirectToAction("Index");

            return View();


        }

        // Home/Products
        public ActionResult Contact()
        {
            return View();
        }

    }
}
