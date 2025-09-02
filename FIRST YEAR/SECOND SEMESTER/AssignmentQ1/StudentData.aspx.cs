using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQ1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string studentId = Request.QueryString["id"];
            
            if (!string.IsNullOrEmpty(studentId))
            {
                string sessionKey = "student_" + studentId;

                if (Session[sessionKey] != null)
                {
                    Student student = (Student)Session[sessionKey];

                    lblStudentName.Text = student.name;
                    lblStudentId.Text = student.studentID;
                    lblPhoneNumber.Text = student.phoneNumber;

                    string coursesList = null;
                    foreach(Course course in student.courses)
                    {
                        // Create a new Label for each course.
                         coursesList = coursesList+ $"• {course.CourseName} <br />";
                    }
                    lblCourses.Text = coursesList;
                }
                else
                {
                    // Handle the case where the session data for this ID is missing.
                    ErrorLabel.Text = "Student data not found.";
                }
            }
            else
            {
                // Handle the case where no ID was passed in the URL.
                ErrorLabel.Text = "No student ID provided.";
            }
        }
    }
}