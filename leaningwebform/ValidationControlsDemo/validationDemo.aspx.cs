using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.ValidationControlsDemo
{
    public partial class validationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
            TextBox4.Text = null;
            TextBox5.Text = null;
            TextBox6.Text = null;
            DropDownList1 .Text = null;
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(TextBox1 .Text.Trim().Length  < 5)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a=0, b=0, c=0;
            c = a + b;
            c = a - b;


            Page.Validate("logingroup");
            if (Page .IsValid)
            {
                c = a / b;
                c = a * b;
            }
           
        }
    }
}