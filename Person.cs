using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Program2_Argabright
{
    public class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion
        #region Constructors
        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        #endregion
        #region Public Methods
        public string Info()
        {
            return FirstName + " " + LastName;
        }
        #endregion
    }
}