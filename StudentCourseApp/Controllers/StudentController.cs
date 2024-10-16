using StudentCourseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCourseApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // Sample data
            var teacher1 = new Teacher { TeacherId = 1, TeacherName = "John Smith" };
            var teacher2 = new Teacher { TeacherId = 2, TeacherName = "Jane Doe" };

            var course1 = new Course { CourseId = 1, CourseName = "Mathematics", Teacher = teacher1 };
            var course2 = new Course { CourseId = 2, CourseName = "Science", Teacher = teacher2 };

            var students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Alice", Course = course1 },
                new Student { StudentId = 2, StudentName = "Bob", Course = course2 },
                new Student { StudentId = 3, StudentName = "Charlie", Course = course1 }
            };
            return View(students);
        }
    }
}