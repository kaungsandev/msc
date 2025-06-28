using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnDisabled.Enabled = true;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            btnDisabled.Enabled = false;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            btnDisabled.BackColor = Color.BlueViolet;        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            btnDisabled.Visible = CheckBox4.Checked ? true : false;
        }

        protected void btnDisabled_Click(object sender, EventArgs e)
        {
            Label1.Text = null;
            for(int i =0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    Label1.Text += "<br/>" + CheckBoxList1.Items[i].Text;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            radioLabel.Text = "Your choice is  " + RadioButtonList1.SelectedValue;            
        }
    }
}