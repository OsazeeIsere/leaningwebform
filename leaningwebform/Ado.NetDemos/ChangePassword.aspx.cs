using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code;

namespace leaningwebform.Ado.NetDemos
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["sessUserName"] != null)
                {
                    Label3.Text = "<h2> Welcome! Go ahead to change your Password</h2>";
                }
                else
                {
                    Response.Redirect("login.aspx");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetail x = new UserDetail();
            string oldpassword = Session["sessPassword"].ToString();
            string enteredpassword = TextBox1.Text;
            if (oldpassword.Equals(enteredpassword))
            {
                x.MyUserName = Session["sessUserName"].ToString();
                x.MyPassword = TextBox2.Text;
                int counter = x.ChamgePassword();
                if (counter.Equals(1))
                {
                    Session.Abandon();
                    Response.Redirect("login.aspx");
                }
                
            }
            else
            {
                Label3.Text = "<h1> Credentials mismatch! Unable to Change Password </h1>";
            }
        }
    }
}