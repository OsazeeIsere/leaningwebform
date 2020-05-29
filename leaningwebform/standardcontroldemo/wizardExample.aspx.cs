using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class wizardExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
           
            string t1 = TextBox1.Text;
            string t2 = TextBox2.Text;
            string t3 = TextBox3.Text;
            string t4 = TextBox4.Text;
            string t5 = TextBox5.Text;
            string t6 = TextBox6.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("Thank You! The following are the details of what you entered...<br>");
            sb.Append("The First Name: ");
            sb.Append(t1);
            sb.Append("<br>");

            sb.Append("The Last Name: ");
            sb.Append(t2);
            sb.Append("<br>");

            sb.Append("Academic Qualification: ");
            sb.Append(t3);
            sb.Append("<br>");

            sb.Append("Post Qualification");
            sb.Append(t4);
            sb.Append("<br>");

            sb.Append("Work Experience: ");
            sb.Append(t5);
            sb.Append("<br>");

            sb.Append("Work Experience: ");
            sb.Append(t1);
            sb.Append("<br>");

            Label2.Text = sb.ToString();
            Label1.Text = "Thank you following with us.";
        }
    }
}