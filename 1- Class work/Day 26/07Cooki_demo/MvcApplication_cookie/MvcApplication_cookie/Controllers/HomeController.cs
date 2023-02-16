using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_cookie.Models;

namespace MvcApplication_cookie.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            /* HttpCookie cookie = Request.Cookies["UserDetail"];
             if (cookie != null)
             { 
             User_Login obj=new User_Login();
             obj.Name = cookie["Name"];

             return View(obj);
             } */


            return View();
        }
        [HttpPost]
        public ActionResult Index(User_Login objUser, string chk)
        {
            if (ModelState.IsValid)
            {
                using (SampleEntities db = new SampleEntities())
                {

                  
                        if (chk == "check")
                        {
                            HttpCookie ck = new HttpCookie("UserDetail");
                            ck["Name"] = objUser.Name;
                            ck.Expires = DateTime.Now.AddDays(30);
                            Response.Cookies.Add(ck);
                        }
                    
                     }
                return View("linkpage");
                   
                
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            return View();
        }  
    }
}
