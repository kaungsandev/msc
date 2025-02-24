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
        protected void btnExport_Click(object sender, EventArgs e)
        {
            // Capture the data from the form
            string name = InputTextName.Text;
            string gender = InputRadioGender.SelectedValue;
            string city = InputDropDownCity.SelectedValue;
            string bio = InputTextAreaBio.Text;


            // Convert the image to Base64 if provided
            string profileBase64Image = string.Empty;
            string showCaseBase64Image1 = string.Empty;
            string showCaseBase64Image2 = string.Empty;
            string showCaseBase64Image3 = string.Empty;

            if (FileUploadProfileImage.HasFile)
            {
                try
                {
                    // Profile Image Upload and store
                    string path = Server.MapPath("~/uploads/");
                    string extension = Path.GetExtension(FileUploadProfileImage.FileName).ToLower();
                    string profileImage = "profile_image" + extension;
                    FileUploadProfileImage.SaveAs(path + profileImage);


                    // Read the uploaded file into a byte array
                    byte[] imageBytes = new byte[FileUploadProfileImage.PostedFile.ContentLength];
                    // Convert the byte array to a Base64 string
                    profileBase64Image = Convert.ToBase64String(imageBytes);
                    
                }
                catch (Exception)
                {
                    profileBase64Image = ""; // If there's an error, set to empty string
                }
            }
            else
            {
                profileBase64Image = ""; // No file was uploaded
            }

            if(showCaseImage1.HasFile)
            {
                try
                {
                    // Read the uploaded file into a byte array
                    byte[] imageBytes = showCaseImage1.FileBytes;
                    // Convert the byte array to a Base64 string
                    showCaseBase64Image1 = Convert.ToBase64String(imageBytes);
                }
                catch (Exception)
                {
                    showCaseBase64Image1 = ""; // If there's an error, set to empty string
                }
            }
            if (showCaseImage2.HasFile)
            {
                try
                {
                    // Read the uploaded file into a byte array
                    byte[] imageBytes = showCaseImage2.FileBytes;
                    // Convert the byte array to a Base64 string
                    showCaseBase64Image2 = Convert.ToBase64String(imageBytes);
                }
                catch (Exception)
                {
                    showCaseBase64Image2 = ""; // If there's an error, set to empty string
                }
            }
            if (showCaseImage3.HasFile)
            {
                try
                {
                    // Read the uploaded file into a byte array
                    byte[] imageBytes = showCaseImage3.FileBytes;
                    // Convert the byte array to a Base64 string
                    showCaseBase64Image3 = Convert.ToBase64String(imageBytes);
                }
                catch (Exception)
                {
                    showCaseBase64Image3 = ""; // If there's an error, set to empty string
                }
            }

            if (!string.IsNullOrEmpty(name))
            {   
                // Text File Approach
                //string fileName = DateTime.Now.ToString();
                //string TextData = $"" +
                //    $"Name: {name}" + '\n'+
                //    $"Gender: {gender}" + '\n' +
                //    $"City: {city}" + '\n' +
                //    $"Biography:"+"\n"+$"{bio}" + '\n'+
                //    $"profile image:" + "\n" +$"{profileImage}";

                //Response.Clear();
                //Response.ContentType = "text/plain";
                //Response.AddHeader("Content-Disposition", "attachment; " +
                //    $"filename={fileName}.txt");

                //Response.Write(TextData);
                //Response.End();


                // HTML file approach
                string fileName = DateTime.Now.ToString("yyyyMMddHHmmss"); // Format file name for safe use
                // Generate the HTML template
                string htmlTemplate = $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>User Information</title>
    <style>
        body {{
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f9fafe;
            color: #333;
            line-height: 1.6;
        }}
        .container {{
            max-width: 800px;
            margin: 30px auto;
            background: #fff;
            border-radius: 12px;
            padding: 20px;
            box-shadow: 0 8px 15px rgba(0, 0, 0, 0.1);
        }}
        h1 {{
            text-align: center;
            color: #4a4a4a;
            margin-bottom: 20px;
        }}
        .profile-section {{
            text-align: center;
            margin-bottom: 30px;
        }}
        .profile-section img {{
            max-width: 150px;
            border-radius: 50%;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }}
        .details-section {{
            margin-bottom: 30px;
        }}
        .details-section .info {{
            display: flex;
            margin-bottom: 10px;
            align-items: center;
        }}
        .details-section .info strong {{
            flex: 0 0 120px;
            color: #666;
        }}
        .showcase-section {{
            margin-top: 20px;
        }}
        .showcase-title {{
            text-align: center;
            margin-bottom: 15px;
            font-size: 1.2rem;
            color: #4a4a4a;
        }}
        .showcase-grid {{
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 20px;
        }}
        .showcase-grid img {{
            width: 100%;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }}
        .showcase-grid img:hover {{
            transform: translateY(-5px);
            box-shadow: 0 6px 12px rgba(0, 0, 0, 0.15);
        }}
    </style>
</head>
<body>
    <div class='container'>
        <!-- Profile Section -->
        <div class='profile-section'>
            {(string.IsNullOrEmpty(profileBase64Image) ? "<p>No Profile Image Provided</p>" : $"<img src='data:image/png;base64,{profileBase64Image}' alt='Profile Image'>")}
            <h1>{name}</h1>
        </div>

        <!-- Details Section -->
        <div class='details-section'>
            <div class='info'><strong>Gender:</strong> {gender}</div>
            <div class='info'><strong>City:</strong> {city}</div>
            <div class='info'><strong>Biography:</strong>{bio}</div>
        </div>

        <!-- Showcase Section -->
        <div class='showcase-section'>
            <div class='showcase-title'>Showcase Images</div>
            <div class='showcase-grid'>
                {(string.IsNullOrEmpty(showCaseBase64Image1) ? "<p>No Image 1 Provided</p>" : $"<img src='data:image/png;base64,{showCaseBase64Image1}' alt='Showcase Image 1'>")}
                {(string.IsNullOrEmpty(showCaseBase64Image2) ? "<p>No Image 2 Provided</p>" : $"<img src='data:image/png;base64,{showCaseBase64Image2}' alt='Showcase Image 2'>")}
                {(string.IsNullOrEmpty(showCaseBase64Image3) ? "<p>No Image 3 Provided</p>" : $"<img src='data:image/png;base64,{showCaseBase64Image3}' alt='Showcase Image 3'>")}
            </div>
        </div>
    </div>
</body>
</html>";


                // Send the HTML file as a response
                Response.Clear();
                Response.ContentType = "text/html";
                Response.AddHeader("Content-Disposition", $"attachment; filename={fileName}.html");
                Response.Write(htmlTemplate);
                Response.End();

            }
            else
            {
                // If the Name field is empty, show an alert (this can also be done via JavaScript)
                Response.Write("<script>alert('Please enter a name!');</script>");
            }

        }

        protected void InputTextName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
