using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.dataBoundControlDemo
{
    public partial class gridViewExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow gvr1 = GridView1.SelectedRow;
            TextBox1.Text = gvr1.Cells[1].Text;
            TextBox2.Text = gvr1.Cells[2].Text;
            TextBox3.Text = gvr1.Cells[3].Text;
            TextBox4.Text = gvr1.Cells[4].Text;
        }
    }
}