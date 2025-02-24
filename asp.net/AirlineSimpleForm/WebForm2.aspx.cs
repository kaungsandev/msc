using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirlineSimpleForm
{
	public partial class WebForm2 : System.Web.UI.Page
	{

        protected decimal price = 0;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["username"] != null)
			{
				Label1.Text = "Welcome, " + Session["username"];
			}
		}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
			Session["username"] = null;

			Response.Redirect("WebForm1.aspx");
        }

		protected void resetErrorMessages()
		{
			errorTripType.Text = null;
			errorDestination.Text = null;
			errorDepartureTime = null;
			errorPassport = null;
		}

        protected void validateFields()
        {
            if (radioTripType.SelectedItem == null)
            {
                errorTripType.Text = "Please choose trip type.";
                return;
            }

            if (dropdownSingle.SelectedItem == null && dropdownRound.SelectedItem == null)
            {
                errorDestination.Text = "Please choose your destination.";
                return;
            }
            if (radioDepartureTime.SelectedItem == null)
            {
                errorDepartureTime.Text = "Please choose departure time.";
                return;
            }
            if (txtPassport.Text == null || txtPassport.Text == "")
            {
                errorPassport.Text = "Please fill you passport number.";
                return;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            validateFields();
            // Get selected trip type
            string tripType = radioTripType.SelectedValue;

            // Get selected destination
            string destination = 
                tripType == "singletrip" 
                ? dropdownSingle.SelectedValue 
                : dropdownRound.SelectedValue;

            // Using the global price variable
   

            switch (destination)
            {
                case "bangkok":
                    price = 100;
                    break;
                case "singapore":
                    price = 150;
                    break;
                case "seoul":
                    price = 200;
                    break;
                case "london":
                    price = 250;
                    break;
                case "yangon - bangkok":
                    price = 200;
                    break;  
                case "yangon - singapore":
                    price = 150;
                    break;
                case "yangon - seoul":
                    price = 200;
                    break;
                case "yangon - london":
                    price = 250;
                    break;
            }
            totalPrice.Text = "Total Price: " + price.ToString();



        }

        protected void radioTripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDestination.Visible = true;
            if (radioTripType.SelectedValue == "singletrip")
            {
                
                dropdownSingle.Visible = true;
                dropdownRound.Visible = false;

                dropdownRound.SelectedValue = null;
            }
            if (radioTripType.SelectedValue == "roundtrip")
            {
                dropdownSingle.Visible = false;
                dropdownRound.Visible = true;

                dropdownSingle.SelectedValue = null;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            validateFields();

            // Get selected trip type
            string tripType = radioTripType.SelectedValue;

            // Get selected destination
            string destination =
                tripType == "singletrip"
                ? dropdownSingle.SelectedValue
                : dropdownRound.SelectedValue;

            Session["TripType"] = tripType;
            Session["Destination"] = destination;
            Session["DepartureTime"] = radioDepartureTime.SelectedValue;
            Session["PassportNumber"] = txtPassport.Text;
            Session["Price"] = price;  // Storing the calculated price

            Response.Redirect("WebForm3.aspx");
        }
    }
}