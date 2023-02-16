using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationauthorization.Models;
namespace MvcApplicationauthorization.Controllers
{
    //
        // GET: /Home/
        [Log]
        public class StudentController : Controller
        {
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult About()
            {
                return View();
            }

            public ActionResult Contact()
            {
                return View();
            }
        }


    
}
