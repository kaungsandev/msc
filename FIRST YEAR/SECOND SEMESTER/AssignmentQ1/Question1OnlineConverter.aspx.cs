using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQ1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "FTM")
            {
                Label1.Text = "Feet";
                Label2.Text = "Meter";
            }
            else if (RadioButtonList1.SelectedValue == "CTF")
            {
                Label1.Text = "Celsius";
                Label2.Text = "Fahrenheit";
            }
            else if(RadioButtonList1.SelectedValue == "PTK")
            {
                Label1.Text = "Pound";
                Label2.Text = "Kilogram";
            }
            clearTextBox();
        }

        public void clearTextBox()
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "FTM")
            {
                TextBox2.Text = FeetToMeter(double.Parse(TextBox1.Text)).ToString();
            }
            else if (RadioButtonList1.SelectedValue == "CTF")
            {
                TextBox2.Text = CelsiusToFahrenheit(double.Parse(TextBox1.Text)).ToString();
            }
            else if (RadioButtonList1.SelectedValue == "PTK")
            {
                TextBox2.Text = PoundsToKilograms(double.Parse(TextBox1.Text)).ToString();
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "FTM")
            {
                TextBox1.Text = MetersToFeet(double.Parse(TextBox2.Text)).ToString();
            }
            else if (RadioButtonList1.SelectedValue == "CTF")
            {
                TextBox1.Text = FahrenheitToCelsius(double.Parse(TextBox2.Text)).ToString();
            }
            else if (RadioButtonList1.SelectedValue == "PTK")
            {
                TextBox1.Text = KilogramsToPounds(double.Parse(TextBox2.Text)).ToString();
            }
        }

        public static double FeetToMeter(double feet)
        {
            return feet * 0.3048;
        }
        public static double MetersToFeet(double meters)
        {
            return meters * 3.28084;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double PoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }
        public static double KilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }
    }
}