using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Program2_Argabright
{
    public class Professor : Person
    {
        #region Properties
        public List<Course> Courses { get; }
        #endregion

        #region Constructors
        public Professor()
        {
            Courses = new List<Course>();
        }
        #endregion
        #region Public Methods
        public bool AddCourse(string courseName, string courseNumber, string courseSemester, int courseYear, List<Student> students)
        {
            bool success = false;
            try
            {
                Course newCourse = new Course();
                newCourse.Name = courseName;
                newCourse.Number = courseNumber;
                newCourse.Semester = courseSemester;
                newCourse.Year = courseYear;
                newCourse.Students = students;

                Courses.Add(newCourse);
                success = true;
            }
            catch (Exception e)
            {

            }
            return success;
        }
        #endregion
    }
}