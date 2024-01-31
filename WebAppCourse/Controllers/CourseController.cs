using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourse.Models;

namespace WebAppCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
        new Course { CourseId = 1,CourseName = "ASP.NET",CourseFee = 200,Technology = "C#",StartDate = DateTime.Now,EndDate = DateTime.Now.AddDays(10)},
                new Course { CourseId = 2,CourseName = "Csharp",CourseFee = 200,Technology = "C#",StartDate = DateTime.Now,EndDate = DateTime.Now.AddDays(20)},
                        new Course { CourseId = 3,CourseName = "C++",CourseFee = 200,Technology = "C programming",StartDate = DateTime.Now,EndDate = DateTime.Now.AddDays(30)}



        };
        public ActionResult Index()
        {
            return View(courses);
        }
    }
}