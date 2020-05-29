using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.navigationalControlsDemos
{
    public partial class treeViewExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            string str = TreeView1.SelectedNode.Text.ToUpper();
            switch (str)
            {
                case "FORM VIEW":
                    Response.Redirect("~/dataBoundControlDemo/formViewExample.aspx");
                    break;

            }
        }
    }
}