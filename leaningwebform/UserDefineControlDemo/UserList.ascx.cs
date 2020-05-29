using leaningwebform.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace leaningwebform.UserDefineControlDemo
{
    public partial class UserList : System.Web.UI.UserControl
    {
        public string Country { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetail x = new UserDetail();
                DataSet dset = new DataSet();
                dset = x.GetAllUser();

                DataView dv = dset.Tables[0].DefaultView;
                if (Country != null)
                {
                    dv.RowFilter = "country='" + Country + "'";
                }
                // GridView1.DataSource = dset;
                // we are commenting out the above line because we re changing the display mode
                GridView1.DataSource = dv;
                GridView1.DataBind();
               
            }
        }
    }
}