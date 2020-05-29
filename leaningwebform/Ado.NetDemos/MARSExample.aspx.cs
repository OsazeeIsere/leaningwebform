using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace leaningwebform.Ado.NetDemos
{
    public partial class MARSExample : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cm = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void GetInfo()
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=ASPtraining; integrated security=true;MultipleActiveResultsets=true;";
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cn.Open();
            cm.CommandText = "select * from userDetails order by userid";
            SqlDataReader reader1 = cm.ExecuteReader(CommandBehavior.CloseConnection);
            while(reader1.Read())
            {
                Response.Write(reader1["userid"]+ "");
                SqlCommand cm2 = new SqlCommand();
                cm2.Connection = cn;
                cm2.CommandType = CommandType.Text;
                cm2.CommandText = "select * from contacts where userid=" + reader1["userid"];
                SqlDataReader reader2 = cm2.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader2.Read())
                { 
                Response.Write("<br>" + reader2["fax"] + "," + reader2["phonenumber"] + "," + reader2["landline"]);
                }
                Response.Write("<hr>");
            }
            cn.Close();
            reader1.Close();
            reader1.Dispose();
            reader1 = null;




        }

    }
}