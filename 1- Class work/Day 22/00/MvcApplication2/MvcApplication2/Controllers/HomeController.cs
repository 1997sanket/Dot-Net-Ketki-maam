using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            string  s = "hello";
            return View(s);
        }

        public ActionResult About()
        {
            return View();
        }
         public ActionResult Movies()
        { 
            return View();
        }

        public ActionResult detail()
        {
            return View();
        }
    }
}
