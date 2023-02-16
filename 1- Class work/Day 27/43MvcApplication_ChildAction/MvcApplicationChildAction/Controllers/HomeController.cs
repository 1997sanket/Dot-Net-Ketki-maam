using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationChildAction.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Countries(List<String> countryData)
        {
            return View(countryData);
        }

        [ChildActionOnly]
        public ActionResult PCountries(List<String> countryData)
        {
            return PartialView("_chk",countryData);
        }
    }
}
