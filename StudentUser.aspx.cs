using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program2_Argabright
{
    public partial class StudentUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ReturnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainUser.aspx");
        }
    }
}