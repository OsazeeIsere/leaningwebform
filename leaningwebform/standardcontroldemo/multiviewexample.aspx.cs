using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class multiviewexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if(MultiView1 .ActiveViewIndex <MultiView1.Views .Count -1)
            MultiView1.ActiveViewIndex +=1;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = RadioButtonList1.SelectedValue.ToUpper();
            switch (str )
            {
                case "AQ":
                    MultiView1.SetActiveView(View2);
                    break;
                case "TQ":
                    MultiView1.SetActiveView(View3);
                    break;
            }
        }

        protected void Button2_Click()
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}