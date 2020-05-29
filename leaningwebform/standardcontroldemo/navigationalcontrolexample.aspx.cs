using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class navigationalcontrolexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
       //     Response.Redirect("textboxexample.aspx");
            Response.Redirect("https://www.jw.org/en/publications/jw-meeting-workbook/");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            //if(e.X < 200)
            //{
            //    Server.Transfer("textboxexample.aspx");
            //}
            //else
            //{
            //    Server.Transfer("~/responsewritedemo.aspx");
            //}

            if (e.Y < 50)
            {
                Response.Redirect("https://www.jw.org/en/publications/jw-meeting-workbook/");
            }
            else
            {
                Server.Transfer("~/responsewritedemo.aspx");
            }
        }
    }
}