using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirlineSimpleForm
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			errorUsername.Text = null;
			errorPassword.Text = null;

			if(txtUsername.Text == null || txtUsername.Text == "")
			{
				errorUsername.Text = "Please fill username";
				return;
			}
            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                errorPassword.Text = "Please fill password";
                return;
            }

			Session["username"] = txtUsername.Text;
			Response.Redirect("WebForm2.aspx");
        }	
    }
}