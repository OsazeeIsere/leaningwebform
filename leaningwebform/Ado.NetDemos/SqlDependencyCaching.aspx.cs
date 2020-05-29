using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Caching;

namespace leaningwebform.Ado.NetDemos
{
    public partial class SqlDependencyCaching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // start configuration from sql by opening developer command prompt for vs 2017. Seach for this environment
            //from the start button. first enable database by typing:aspnet_regsql.exe -S . -E -d ASPtraining 
            // -ed and press enter
            //then type:aspnet_regsql.exe -S . -E -d ASPtraining -ed -t userDetails -et
            // to see list all table type:aspnet_regsql.exe - S. - E - d ASPtraining -lt
            // remember to set it up on the web.config page: 
            //            <system.web>
            //    < caching >
            //      < sqlCacheDependency enabled = "true" >

            //         < databases >

            //           < add name = "ASPtraining"
            //               connectionStringName = "MyCS"
            //               pollTime = "5000" />
            //        </ databases >
            //      </ sqlCacheDependency >
            //    </ caching >

            //</ system.web >


            Label2.Text = DateTime.Now.ToString();//("hh:mm:ss");
           if (!Page.IsPostBack)
            {
                GetData();
            }
        }

        private void GetData()
        {
            DataTable dtable = new DataTable();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;
            if (Cache["userDetailsCache"] != null)
            {
                dtable = (DataTable)Cache["userDetailsCache"];
                Label1.Text = "<br/> Got Data from cache";
            }
            else
            {
                using(SqlConnection cn=new SqlConnection(conString))
                {
                    string cmString = "Select * from userDetails order by userid";
                    using (SqlCommand cm = new SqlCommand(cmString, cn))
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter(cm))
                        {
                            ad.Fill(dtable);
                        }
                    }
                }
                SqlCacheDependency myDependency = new SqlCacheDependency("ASPtraining", "userDetails");
                Cache.Insert("userDetailsCache",dtable,myDependency);
                Label1.Text = "<br/> Got Data from Database";

            }
            GridView1.DataSource = dtable;
            GridView1.DataBind();
        }
    }
}