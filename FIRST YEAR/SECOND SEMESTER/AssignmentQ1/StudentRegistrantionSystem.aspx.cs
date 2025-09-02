using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQ1
{
    public class Course
    {
        public string CourseName { get; set; }
        public int AvailableSeats { get; set; }
    }
    public class Student
    {
        public string name { get; set; }
        public string studentID { get; set; }
        public string phoneNumber { get; set; }
        public List<Course> courses{ get; set; }

    }

    public partial class StudentRegistrantionSystem : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Courses"] == null)
                {
                    List<Course> courses = new List<Course>
                    {
                        new Course { CourseName = "Introduction to ASP.NET", AvailableSeats = 3 },
                        new Course { CourseName = "Machine Learning", AvailableSeats = 1 },
                        new Course { CourseName = "Python Programming", AvailableSeats = 2 }
                    };
                    Session["Courses"] = courses;
                }
                List<Course> courseList = (List<Course>)Session["Courses"];
                CourseList.DataSource = courseList;
                CourseList.DataTextField = "CourseName";
                CourseList.DataValueField = "CourseName";
                CourseList.DataBind();
            }
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = null;
            List<string> errorMessages = new List<string>();
            Course selectedCourse = null; // Initialize to null.
            if (string.IsNullOrEmpty(CourseList.SelectedValue))
            {
                errorMessages.Add("Please select a course to continue.");
            }
            else
            {
                List<Course> courses = (List<Course>)Session["Courses"];

                string selectedCourseName = CourseList.SelectedValue;
                selectedCourse = courses.Find(c => c.CourseName == selectedCourseName);
                if (selectedCourse.AvailableSeats < 1)
                {
                    errorMessages.Add("Sorry, this course is full.");
                }
            }
            if (TBName.Text.Length == 0)
            {
                errorMessages.Add("Please fill Student Name.");
            }
            if (TBStudenId.Text.Length == 0)
            {
                errorMessages.Add("Please fill Student ID.");
            }
            if (TBPhoneNumber.Text.Length == 0)
            {
                errorMessages.Add("Please fill Phone Number.");
            }

            if (errorMessages.Count > 0)
            {
                // Join all messages into a single string with HTML line breaks.
                StatusLabel.Text = string.Join("<br />", errorMessages);
                StatusLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                string studentID = TBStudenId.Text.Trim();
                // remove seats
                List<Course> coursesListFromSession = (List<Course>)Session["Courses"];
                Course updatedCourse = coursesListFromSession.Find(c => c.CourseName == selectedCourse.CourseName);
                updatedCourse.AvailableSeats--;

                if (Session["student_"+studentID] == null)
                {
                    Student student = new Student
                    {
                        name = TBName.Text,
                        studentID = studentID,
                        phoneNumber = TBPhoneNumber.Text,
                        courses = new List<Course>{updatedCourse}
                    };
                    Session["student_" + studentID] = student;
                }
                else
                {   
                    Student student = (Student)Session["student_" + studentID];

                    if (!student.courses.Any(c => c.CourseName == updatedCourse.CourseName))
                    {
                        student.courses.Add(updatedCourse);
                        Console.WriteLine(student.courses);
                    }
                    Session["student_" + studentID] = student;
                }
                // Define the JavaScript function to show the alert and redirect.
                string redirectUrl = $"StudentData.aspx?id={studentID}";
                string script = $"alert('Success! Form submitted successfully.'); window.location.href = '{redirectUrl}';";


                // Register the script to be executed after the page renders.
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertAndRedirect", script, true);
            }
        }

        protected void CourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusLabel.Text = null;
            List<Course> courses = (List<Course>)Session["Courses"];

            string selectedCourseName = CourseList.SelectedValue;
            Course selectedCourse = courses.Find(c => c.CourseName == selectedCourseName);
            if (selectedCourse.AvailableSeats < 1)
            {
                
                StatusLabel.Text = "The selected course is full.";
                StatusLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}