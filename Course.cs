using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Program2_Argabright
{
    public class Course
    {
        public string Name { get; set;}
        public string Number { get; set; }
        public string Semester { get; set; }
        public int Year { get; set; }
        public List<Student> Students { get; set; }
    }
}