using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class Placeholderexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label l1 = new Label();
            Label l2 = new Label();
            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            Button b1 = new Button();
            Button b2 = new Button();
            l1.Text = "User Name";
            l2.Text = "Password";
            b1.Text = "Login";
            b2.Text = "Cancel";
            PlaceHolder1.Controls.Add(l1);
            PlaceHolder1.Controls.Add(t1);
           
            PlaceHolder1.Controls.Add(l2);
            PlaceHolder1.Controls.Add(t2);
            PlaceHolder1.Controls.Add(b1);
            PlaceHolder1.Controls.Add(b2);

        }
    }
}