using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQ1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TBEmail.Text.Length == 0)
            {
                lblError.Text = "Please fill email";
            }
            else
            {
                string email = TBEmail.Text;
                Response.Redirect($"VotingPage.aspx?email={email}");
            }
        }
    }
}