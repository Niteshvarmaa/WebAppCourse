using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCourse.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal CourseFee { get; set; }
        public string Technology { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}