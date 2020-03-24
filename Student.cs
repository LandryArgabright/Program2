using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Program2_Argabright
{
    public class Student : Person
    {
        #region Properties
        public List<Course> Courses { get; }
        #endregion
        #region Constructors
        public Student()
        {
            Courses = new List<Course>();
        }
        #endregion
        #region Public Methods
        public bool AddCourse(Course course)
        {
            bool success = false;
            try
            {
                Courses.Add(course);
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