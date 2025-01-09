using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            // Capture the data from the form
            string name = TextBox1.Text;

            if (!string.IsNullOrEmpty(name))
            {
                string TextData = $"Name: {name}";

                Response.Clear();
                Response.ContentType = "text/plain";
                Response.AddHeader("Content-Disposition", "attachment; filename=data.txt");

                Response.Write(TextData);
                Response.End();
            }
            else
            {
                // If the Name field is empty, show an alert (this can also be done via JavaScript)
                Response.Write("<script>alert('Please enter a name!');</script>");
            }

        }
    }
}