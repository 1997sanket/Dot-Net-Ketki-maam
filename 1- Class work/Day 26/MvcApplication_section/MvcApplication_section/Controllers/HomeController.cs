using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication_section.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            ViewBag.greet = "hello";
            return View();
        }
        public ActionResult display()
        {

            ViewBag.disp= "bye";
            return View();
        }


    }
}
