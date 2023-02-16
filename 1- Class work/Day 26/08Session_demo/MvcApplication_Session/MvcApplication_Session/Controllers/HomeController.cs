using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_Session.Models;

namespace MvcApplication_Session.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User_Login objUser)
        {
            if (ModelState.IsValid)
            {
                using (UserLoginContainer db = new UserLoginContainer())
                {
                    var obj = db.User_Login.Where(a => a.Name.Equals(objUser.Name) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                      string x= Session.SessionID;
                        Session["UserName"] = obj.Name.ToString();
                        TempData["k"]= x;
                         
                        return RedirectToAction("UserDashBoard");
                    }
                   ViewBag.Message = "Not a valid user";
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logoutuser()
        {
            
           Session.Abandon();
            return RedirectToAction("Login");
        
        }
    }
}
