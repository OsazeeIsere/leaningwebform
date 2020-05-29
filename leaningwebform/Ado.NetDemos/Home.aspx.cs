using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code;
using System.Data;
namespace leaningwebform
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["sessUserName"] != null)
                {
                    Label1.Text = "<h1> Welcome as " + Session["sessUserName"] + "</h1>";
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            UserDetail x = new UserDetail();
            int counter = x.Unsubscribe();
            if (counter.Equals(1))
            {
                Session.Abandon();
                Response.Redirect("SignUp.aspx");
            }
            else
            {
                Label1.Text = "<h2> Unable to remove User</h2>";
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeProfile.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GetListOfAllUsersUsingReader.aspx");

        }
    }
}