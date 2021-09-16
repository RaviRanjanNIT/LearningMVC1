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

        public ActionResult TwoList()
        {
            List<Friends> listobj1 = new List<Friends>();
            List<Department> listobj2 = new List<Department>();

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

            listobj1.Add(fb1);
            listobj1.Add(fb2);
            listobj1.Add(fb3);
            listobj1.Add(fb4);

            Department dept1 = new Department();
            dept1.DeptId = 1;
            dept1.DepartmentName = "Computer Science & Engineering";

            Department dept2 = new Department();
            dept2.DeptId = 2;
            dept2.DepartmentName = "Electronics & Communications";

            Department dept3 = new Department();
            dept3.DeptId = 3;
            dept3.DepartmentName = "Mechanical Engineering";

            listobj2.Add(dept1);
            listobj2.Add(dept2);
            listobj2.Add(dept3);

            EmpDepartment alldata = new EmpDepartment();
            alldata.friends = listobj1;
            alldata.depatment = listobj2;

            return View(alldata);
        }
    }
}