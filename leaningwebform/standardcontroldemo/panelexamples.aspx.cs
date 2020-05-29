using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class panelexamples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = RadioButtonList1.SelectedValue.ToUpper();
            switch (str)
            {
                case "AQ":
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                    Panel3.Visible = false;
                    break;
                case "TQ":
                    Panel2.Visible = true;
                    Panel1.Visible = false;
                    Panel3.Visible = false;
                    break;
                case "WE":
                    Panel3.Visible = true;
                    Panel2.Visible = false;
                    Panel1.Visible = false;
                    break;
            }
        }
    }
}