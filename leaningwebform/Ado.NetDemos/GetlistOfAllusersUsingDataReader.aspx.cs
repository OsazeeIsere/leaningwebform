using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using leaningwebform.App_Code;
namespace leaningwebform.Ado.NetDemos
{
    public partial class GetlistOfAllusersUsingDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetail x = new UserDetail();
                SqlDataReader sdr = x.GetAllUserusingReader();
                GridView1.DataSource = sdr;
                GridView1.DataBind();
                sdr.Close();
                sdr.Dispose();
                sdr = null;

            }
        }
    }
}