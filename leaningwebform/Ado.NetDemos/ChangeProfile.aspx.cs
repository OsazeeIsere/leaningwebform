using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code;
using System.Data;
namespace leaningwebform.Ado.NetDemos
{
    public partial class ChangeProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["sessUserName"] != null)
                {
                    Label5.Text = "<h2> Welcome as " + Session["sessUserName"] + "</h2>";
                    UserDetail x = new UserDetail();
                    x.MyUserName = Session["sessUserName"].ToString();
                     DataSet dset = x.ChangeProfile();
                        TextBox1.Text = x.MyUserName.ToString();
                    TextBox2.Text = dset.Tables[0].Rows[0]["password"].ToString();
                        DropDownList1.Text = dset.Tables[0].Rows[0]["country"].ToString();
                    TextBox3.Text = dset.Tables[0].Rows[0]["email"].ToString();


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
            x.MyUserName= Session["sessUserName"].ToString();
            x.MyPassword = TextBox2.Text;
            x.MyCountry = DropDownList1.Text;
            x.MyEmail = TextBox3.Text;
            int counter = x.UpdateUserProfile();
            if (counter.Equals(1))
            {
                Label5.Text = "<h2> Good! Your profile is Updated </h2>";
            }
            else
            {
                Label5.Text = "<h2> Sorry! Your profile is'nt Updated </h2>";
            }
        }
    }
}