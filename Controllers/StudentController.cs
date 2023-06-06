using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Repository;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Listname = "List from Viewbag";
            ViewData["List"] = "List from view data";

            ViewData.Add(new KeyValuePair<string, object>("Name", "Ramkumar"));
            ViewData.Add(new KeyValuePair<string, object>("Dept", "Mech"));

            //List<Student> list = new List<Student>();
            //list.Add(new Student { StudentId = 1, Name = "Vijay", Department = "CSC"  });
            //list.Add(new Student { StudentId = 2, Name = "Karthi", Department = "CSC"  });
            //list.Add(new Student { StudentId = 3, Name = "Vickey", Department = "CSC" });

            ViewData["Index"] = StudentRepository.GetAllStudents();
            //ViewBag.Students = list;
            //TempData["Telist"] = list;


            return View();
        }
        public ActionResult Mylist()
        {
            ViewBag.List2 = TempData["Telist"];
            TempData.Keep();
            return RedirectToAction("Newlist");
        }
        public ActionResult Newlist()
        {
            ViewBag.List1 = TempData["Telist"];
            return View();
        }
        public ActionResult Partiallist()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { StudentId = 1, Name = "Vijay", Department = "CSC" });
            list.Add(new Student { StudentId = 2, Name = "Karthi", Department = "CSC"});
            list.Add(new Student { StudentId = 3, Name = "Vickey", Department = "CSC"});
            ViewBag.Students = list;
            return PartialView("Partial");
        }
    }
}