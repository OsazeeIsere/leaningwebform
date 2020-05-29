using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.navigationalControlsDemos
{
    public partial class menuExamples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string str = e.Item.Text.ToUpper();
            switch (str)
            {
                case "FORM VIEW":
                    Response.Redirect("~/dataBoundControlDemo/formViewExample.aspx");
                    break;
            }
        }
    }
}