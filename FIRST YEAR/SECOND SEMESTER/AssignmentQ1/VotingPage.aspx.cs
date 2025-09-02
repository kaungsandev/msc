using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentQ1
{
    public class Actress
    {
        public string name { get; set; }
        public int voting_count { get; set; }
    }
    public partial class VotingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Actress> actressLists;
            if (!IsPostBack)
            {
                if (Request.QueryString["email"] == null)
                {
                    Response.Redirect("VotingLogin.aspx");
                }
                if (Session["actress_list"] == null)
                {
                    actressLists = new List<Actress>
                    {
                        new Actress {name="aye aye", voting_count= 2 },
                        new Actress {name="mya mya", voting_count= 3},
                        new Actress {name="hla hla", voting_count= 3}
                    };
                    Session["actress_list"] = actressLists;
                }
                else
                {
                    // The list already exists in the session, so retrieve it
                    actressLists = (List<Actress>)Session["actress_list"];
                }
                foreach (var actress in actressLists)
                {
                    ListItem item = new ListItem(
                        text: $"{actress.name} ({actress.voting_count} votes)",
                        value: actress.name
                    );
                    rblActress.Items.Add(item);
                }
            }

            string email = Request.QueryString["email"];
            List<string> votedUsers = Session["voted_users"] as List<string>;

            if(votedUsers == null)
            {
                votedUsers = new List<string>();
                Session["voted_users"] = votedUsers;
            }

            if (votedUsers.Contains(email))
            {
                Button1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rblActress.SelectedItem != null) {

                string email = Request.QueryString["email"];
                List<string> votedUsers = Session["voted_users"] as List<string>;
                votedUsers.Add(email);
                Session["voted_users"] = votedUsers;


                string selectedActressName = rblActress.SelectedItem.Value;
                

                List<Actress> actressLists = (List<Actress>)Session["actress_list"];


                if (actressLists != null)
                {
            
                    Actress votedActress = actressLists.FirstOrDefault(a => a.name == selectedActressName);

                    if (votedActress != null)
                    {
                        votedActress.voting_count++;
                        Session["actress_list"] = actressLists;
                    }
                }

                Response.Redirect(Request.RawUrl);
            }
             
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("VotingPage.aspx");
        }
    }
}