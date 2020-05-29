using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.UserDefineControlDemo
{
    public partial class AddUserControlDynamically : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Control header = LoadControl("Header.ascx");
            Control footer = LoadControl("Footer.ascx");
            Control userlist = LoadControl("UserList.ascx");

            PlaceHolder1.Controls.Add(header);
            PlaceHolder2.Controls.Add(userlist);
            PlaceHolder3.Controls.Add(footer);

        }
    }
}