using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class Hidenfieldexample : System.Web.UI.Page
    {
        double Pie = 3.14;
        static double Pie1 = 3.14;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(TextBox1.Text);
            double pie = Convert.ToDouble(HiddenField1.Value);
            double area = pie * r * r;
            TextBox2.Text = area.ToString();
            // HiddenField is one way making data value Persistent. 
            //global Variable makes data value lost at post back
            Pie = 4.14;// this value of Pie will not be used when button is clicked second time
            Pie1 = 4.14;
            //using Static Variable option is not good either be/cos once Pie1 changed to 4.14, it remains so forever
            //so use data Persistent technique like HiddenField
        }
    }
}