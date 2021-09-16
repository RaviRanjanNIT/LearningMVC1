using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningMVC.Models;

namespace LearningMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Friends fb = new Friends();
            fb.Name = "Ravi Ranjan";
            fb.Contact = "9507117523";

            return View(fb);
        }

        public ActionResult Index2()
        {
            List<Friends> listobj = new List<Friends>();

            Friends fb1 = new Friends();
            fb1.Name = "Rahul Ranjan";
            fb1.Contact = "9955443578";

            Friends fb2 = new Friends();
            fb2.Name = "Ravi Ranjan";
            fb2.Contact = "9507117523";

            Friends fb3 = new Friends();
            fb3.Name = "Ravi Kant Pandey";
            fb3.Contact = "9988776655";

            Friends fb4 = new Friends();
            fb4.Name = "Shashi Kant";
            fb4.Contact = "9835498354";

            listobj.Add(fb1);
            listobj.Add(fb2);
            listobj.Add(fb3);
            listobj.Add(fb4);

            ViewBag.info = listobj;

            return View();
        }
    }
}