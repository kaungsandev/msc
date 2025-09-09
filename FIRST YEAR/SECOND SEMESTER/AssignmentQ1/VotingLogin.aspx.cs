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

                List<string> registeredUser = Session["registered_user"] as List<string>;

                if(registeredUser == null)
                {
                    Response.Redirect("VotingRegister.aspx");
                }
                else
                {
                    if(registeredUser.Contains(email))
                    {
                        Response.Redirect($"VotingPage.aspx?email={email}");
                    }
                }

                Response.Redirect("VotingRegister.aspx");



            }
        }
    }
}