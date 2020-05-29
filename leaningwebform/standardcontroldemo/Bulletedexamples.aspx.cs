using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class Bulletedexamples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                   if(!Page .IsPostBack)
            {
                EmployeeNameAdd();
            }
        }

        private void EmployeeNameAdd()
        {
            ListItem lit1 = new ListItem("Jason");
            ListItem lit2 = new ListItem("JOAN");
            ListItem lit3 = new ListItem("JIM");
            BulletedList2.Items.Add(lit1);
            BulletedList2.Items.Add(lit2);
            BulletedList2.Items.Add(lit3);
            ListBox1.Items.Add(lit1);
            ListBox1.Items.Add (lit2);
            ListBox1.Items.Add(lit3);

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            TextBox1.Text = BulletedList1.Items[e.Index].Text .ToString ();
                       
        }
    }
}