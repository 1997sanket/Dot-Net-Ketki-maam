using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace secure_login.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       [RequireHttps]
        public String Login()
        {
            return "this is secure https";
        }
    }
}