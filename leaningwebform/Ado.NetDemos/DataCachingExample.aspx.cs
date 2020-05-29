using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using leaningwebform.App_Code;

namespace leaningwebform.Ado.NetDemos
{
    public partial class DataCachingExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        if(!Page.IsPostBack)
            {
                UserDetail x = new UserDetail();
                DataSet dset = new DataSet();

                if (Cache["caAllUsers"]==null)
                {
                    dset = x.GetAllUser();
                    Cache["caAllUsers"] = dset;
                }
                else
                {
                    dset =(DataSet) Cache["caAllUsers"];
                }
                GridView1.DataSource = dset;
                GridView1.DataBind();

            }
        }
    }
}