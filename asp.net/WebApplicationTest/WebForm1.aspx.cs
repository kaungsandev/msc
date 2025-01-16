using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        protected void validateData()
        {

        }
        protected void btnExport_Click(object sender, EventArgs e)
        {
            // Capture the data from the form
            string name = InputTextName.Text;
            string gender = InputRadioGender.SelectedValue;
            string city = InputDropDownCity.SelectedValue;
            string bio = InputTextAreaBio.Text;

          
            string path = Server.MapPath("~/uploads/");
            string extension = Path.GetExtension(FileUploadProfileImage.FileName).ToLower();
            string profileImage = "profileImage"+extension;
            FileUploadProfileImage.SaveAs(path + profileImage);


            if (!string.IsNullOrEmpty(name))
            {
                string fileName = DateTime.Now.ToString();
                string TextData = $"" +
                    $"Name: {name}" + '\n'+
                    $"Gender: {gender}" + '\n' +
                    $"City: {city}" + '\n' +
                    $"Biography:"+"\n"+$"{bio}" +
                    $"profile image:" + "\n" +$"{profileImage}";

                Response.Clear();
                Response.ContentType = "text/plain";
                Response.AddHeader("Content-Disposition", "attachment; " +
                    $"filename={fileName}.txt");

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
