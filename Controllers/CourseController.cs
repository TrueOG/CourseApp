using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    // localhost:5000/course
    public class CourseController:Controller
    {
        //action method
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Apply(Student student)
        {
          Repository.AddStudent(student);
          return View("Thanks",student);
        }

        public IActionResult Details(){

            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }

    // localhost:5000/course/list
        public IActionResult List(){
            return View();
        }
    }
}