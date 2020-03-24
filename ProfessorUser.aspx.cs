using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;

namespace Program2_Argabright
{
    public partial class ProfessorUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //temp variables to put in method
            string _courseName;
            string _courseNumber;
            string _courseSemester;
            string _courseYear;
            List<Student> students;

            Regex rgx = new Regex(@"^(P\d)");

            if (!IsPostBack)
            {
                //Session of Professors which holds course info 
                //      public bool AddCourse(string courseName, string courseNumber
                //      string courseSemester, int courseYear, List<Student> students)


                //Reading File in into String array then convert to string datatype
                string text;
                string[] arrayText;


                text = string.Join("", File.ReadAllText(@"C:\Users\abrig\Desktop\Visual_Studio\Courses.txt"));
                arrayText = text.Split('#');

                //professor list
                List<Professor> professorList = new List<Professor>();

                foreach (string s in arrayText)
                {
                    string[] split = s.Split(' ', '\n');
                    //_courseName = split[0];
                    //_courseNumber = split[1];
                    //_courseSemester = split[4];
                    //_courseYear = split[5];

                    foreach (string str in split)
                    {
                        if (rgx.IsMatch(str))
                        {
                            Professor professor = new Professor();
                            
                            professor.FirstName = str;
                            professorList.Add(professor);

                        }
                    }

                    ListBox1.Items.Add("--------------");
                    ListBox1.Items.Add("--------------");
                    ListBox1.Items.Add("--------------");
                    ListBox1.Items.Add("--------------");
                }
                foreach (Professor p in professorList)
                {
                    ListBox1.Items.Add(p.FirstName);
                }
            }
        }
        //   Here for use later           Session["Professors"] = prosList;
        protected void ReturnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainUser.aspx");
        }
    }
}