using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQ1
{
    public partial class VotingRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == null)
            {
                labelError.Text = "Please fill email.";

            }
            else
            {
                if (Session["registered_user"] == null)
                {
                    List<string> registeredLists = new List<string>();
                    registeredLists.Add(tbEmail.Text);
                    Session["registered_user"] = registeredLists;
                    Response.Redirect("VotingLogin.aspx");
                }
                else
                {
                    List<string> registeredLists = Session["registered_user"] as List<string>;
                    if (registeredLists.Contains(tbEmail.Text))
                        {
                        Response.Redirect("VotingLogin.aspx");
                    }
                    else
                    {
                        registeredLists.Add(tbEmail.Text);
                        Session["registered_user"] = registeredLists;
                        Response.Redirect("VotingLogin.aspx");
                    }
                }

            }
        }
    }
}