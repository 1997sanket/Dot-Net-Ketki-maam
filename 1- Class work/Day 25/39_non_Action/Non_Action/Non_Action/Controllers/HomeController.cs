using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Non_Action.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Method1()
        {
            return "<h1>Method 1 Invoked</h1>";
        }

        private string Method2()
        {
            return "<h1>Method 2 Invoked</h1>";
        }
        internal string Method4()
        {
            return "<h1>Method 4 Invoked</h1>";
        }
        [NonAction]
        public string Method3()
        {
            return "<h1>Method 3 Invoked</h1>";
        }
    }
}