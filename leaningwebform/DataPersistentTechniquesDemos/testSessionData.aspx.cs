using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.DataPersistentTechniquesDemos
{
    public partial class testSessionData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["sess_userName"] != null)
                {
                    TextBox1.Text = Session["sess_userName"].ToString();
                }


                if(Request.QueryString["country"] != null)
                    {
                    TextBox2.Text = Request.QueryString["country"].ToString();
                }

                if (Request.QueryString["state"] != null)
                {
                    TextBox3.Text = Request.QueryString["state"].ToString();
                }


            }

        }
    }
}