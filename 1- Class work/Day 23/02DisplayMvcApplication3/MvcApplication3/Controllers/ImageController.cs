using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
    public class ImageController : Controller
    {
         [HttpGet]
       public ActionResult Index()
        {
           
           return View();
       
       }
        
       
      [HttpPost]
        public ActionResult Index(HttpPostedFileBase fnm)
         {
           
             if (fnm!=null && fnm.ContentLength > 0)
            {
                string filename = Path.GetFileName(fnm.FileName);
                string filepath=Path.Combine(Server.MapPath("~/Images"),filename);
                fnm.SaveAs(filepath); 
            }
             
            return View();
        }

    }

