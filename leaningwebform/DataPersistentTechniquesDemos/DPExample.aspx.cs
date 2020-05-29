using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code;


namespace leaningwebform.DataPersistentTechniquesDemos
{
    public partial class DPExample : System.Web.UI.Page
    {
        // to store the session away from the default location of inproc(worker process) that recycles when
        // it gets full and storing in stateserver, u do the following on web.config:
        //<sessionState mode="StateServer"
        //stateConnectionString="tcpip=127.0.0.1.42424"
        //           cookieless="false" timeout="20"/>

            //but more reliable is storing in the sql server. in the command prompt type
            //aspnet_regsql.exe -S . -E -ssadd -sstype p 
            // the p means persistent
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            { 
            TextBox3.Text = Session.SessionID.ToString();
             TextBox4.Text = Session.Timeout.ToString();
            Session.Timeout = 1;
                TextBox4.Text = Session.Timeout.ToString();
                
                //working with application object 
                int counter = Convert.ToInt32(Application["counter"].ToString());
                counter++;
                Label3.Text =" <h2> You are the visitor Number: " + counter.ToString();
                // b4 u change the app variable, call a special method application .lock() bcos there may be other user at 
                //that time t wanting to change this same value. but u should also unlock 
                Application.Lock();
                Application["counter"] = counter.ToString();
                Application.UnLock();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text;
            ViewState["vs_userName"] = str;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(ViewState["vs_userName"] !=null)
            {
                TextBox2.Text = ViewState["vs_userName"].ToString();
            }
        }
        
        protected void Button3_Click(object sender, EventArgs e)
        {
            // Session["sess_userName"] = TextBox1.Text;
            MySessionVariable x = new MySessionVariable();
            x.My_userName = TextBox1.Text;
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Session["sess_userName"]!=null)
            {
                MySessionVariable x = new MySessionVariable();

                //TextBox2.Text = Session["sess_userName"].ToString();
                TextBox2.Text = x.My_userName;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["sess_userName"] = TextBox1.Text;

            Response.Redirect("testSessionData.aspx?country=Nigeria&state=Edo");
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            HttpCookie ck1 = new HttpCookie("ck_userName",TextBox1.Text);
            ck1.Expires = DateTime.Today.AddDays(3);// this makes the cookie persistent
            Response.Cookies.Add(ck1);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if(Request.Cookies["ck_userName"].Value != null)
            {
                string str = Request.Cookies["ck_userName"].Value.ToString();
                TextBox2.Text = str;
            }

        }
    }
}