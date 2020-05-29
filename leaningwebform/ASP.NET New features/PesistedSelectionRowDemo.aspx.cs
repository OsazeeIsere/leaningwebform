using leaningwebform.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace leaningwebform.ASP.NET_New_features
{
    public partial class PesistedSelectionRowDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Getusers();
            }
        }

        private void Getusers()
        {
           
                UserDetail x = new UserDetail();
                DataSet dset = x.GetAllUser();
                GridView1.DataSource = dset;
                GridView1.DataBind();

            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
           
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Getusers();

        }
    }
}