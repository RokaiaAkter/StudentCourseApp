using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCourseApp.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public ICollection<Course> Action { get; set; }
    }
}