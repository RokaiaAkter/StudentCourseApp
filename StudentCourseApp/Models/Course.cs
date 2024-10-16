using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourseApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        // Foreign key for Teacher
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        // A course can have many students
        public ICollection<Student> Students { get; set; }
    }
}