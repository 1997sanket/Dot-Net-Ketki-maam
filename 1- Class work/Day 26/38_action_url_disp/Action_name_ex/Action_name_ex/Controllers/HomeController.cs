using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_name_ex.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
     /*  [ActionName("List")]
         public string Index()
         {
             return "hello from index";
         }*/
     /*  [ActionName("List")]
        public ActionResult Index()
        {
            return View();
        }*/
        [HttpGet]
          [AcceptVerbs(HttpVerbs.Post)]
       [ActionName("List")]
        public ActionResult Index()
        {
            return View("Index");
        }


    }
}