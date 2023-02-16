using MiniProject_MVC_Entity__.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject_MVC_Entity__.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private mydbEntities db = new mydbEntities();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginCheck(User user)
        {
            User x = db.Users.Where(userX => userX.Email == user.Email && userX.Password == user.Password).SingleOrDefault();

            if(x!=null)
            {
                Session["name"] = x.Name;
                return View();
            }

            return View();
        }



        public ActionResult Logout()
        {
            
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Search(String name)
        {
            return Content(name.ToString());
        }
    }
}
