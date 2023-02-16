using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_validation.Models;
namespace MvcApplication_validation.Controllers
{
    public class studentController : Controller
    {
        //
        // GET: /student/
        Student s1 = new Student() { };

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s1)
        {
            return View("Index",s1);
        }
    }
}
