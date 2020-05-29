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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetail x = new UserDetail();
            MySessionVariable v = new MySessionVariable();
            v.My_userName = TextBox1.Text;
            x.MyUserName = TextBox1.Text;
            x.MyPassword = TextBox2.Text;
            DataSet dset = x.CheckCredentials();
            int status =Convert.ToInt32( dset.Tables[0].Rows[0]["status"].ToString());
            switch(status)
            {
                case 1:
                Session["sessUserName"] = TextBox1.Text;
                Session["sessPassword"] = TextBox2.Text;
                    Response.Redirect("Home.aspx");
                    break;
                case -1:
                    Label3.Text = "<h1> No such user name does exist. Try again</h1>";

                    break;
                case -2:
                    Label3.Text = "<h1> You have unsubscribed in the past. You cant log in</h1>";

                    break;
                case -3:
                    Label3.Text = "<h1> Your account has locked out due to so many failed attempts.</h1>";

                    break;
                case 0:
                    
                    int nofa = Convert.ToInt32(dset.Tables[0].Rows[0]["nofa"].ToString());
                    if (nofa.Equals(5))
                    {
                        Label3.Text = "<h1> Youi have exceeded the max. failed attempts.Your account is locked.</h1>";

                    }
                    else
                    {
                        Label3.Text = "<h1> You have entered wronge password. left with " + (5 - nofa) + "attempts</h1>";
                    }
                    break;
                    }

            }
            
            
            
        }
    }
