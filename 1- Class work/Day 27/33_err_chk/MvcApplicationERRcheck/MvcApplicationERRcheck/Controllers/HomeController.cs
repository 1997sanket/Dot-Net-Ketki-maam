using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationERRcheck.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
       [HandleError]
        public ActionResult Index()
        {
           
            return View();
        }
        //in URL call go and see internaly it will say page not found[go controller is not there]
    }
}
