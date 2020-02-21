using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTraining.Models;

namespace MVCTraining.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        // GET: Student
        public ActionResult Find()
        {
            List<Student> stdList = new List<Student>() {
                    new Student() { StudentId = 10, StudentName = "BAC", Age = 20 },
                        new Student() { StudentId = 11, StudentName = "XYC", Age = 21 },
                    };
            
              
            
            return View(stdList);
        }
        //[HttpPost]
        //public ActionResult Find(Student std)
        //{
        //    ViewData["Name"] = "Welcome to" + std.StudentName;
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Find(FormCollection values)
        //{
        //    ViewData["Name"] = "Welcome to" + values["StudentName"];
        //    return View();
        //}
        //[HttpPost]
        public ActionResult Edit([Bind(Include = "StudentId, StudentName")] Student std)
        {
            var name = std.StudentName;

            //write code to update student 

            return RedirectToAction("Index");
        }
    }
}