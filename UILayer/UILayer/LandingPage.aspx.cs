using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UILayer
{
    public partial class LandingPage : System.Web.UI.Page
    {
        string studentid;
        protected void Page_Load(object sender, EventArgs e)
        {
            studentid = Request.QueryString["studentid"];
        }

        protected void CompleteProfile_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/CompleteStudentProfile.aspx?sid=" + studentid);
        }
    }
}