using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04Ajax_exp.Models;

namespace _04Ajax_exp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

     StuContext db = new StuContext();

    public ActionResult Index()
    {
        return View();
    }

    public PartialViewResult All()
    {
        List<tblStudent> model = db.tblStudents.ToList();
        return PartialView("_stu", model);
    }
    // Return Top3 students
    public PartialViewResult Top3()
    {
        List<tblStudent> model = db.tblStudents.OrderByDescending(x => x.TotalMarks).Take(3).ToList();
        return PartialView("_stu", model);
    }

    // Return Bottom3 students
    public PartialViewResult Bottom3()
    {
        List<tblStudent> model = db.tblStudents.OrderBy(x => x.TotalMarks).Take(3).ToList();
        return PartialView("_stu", model);
    }

    }
}
