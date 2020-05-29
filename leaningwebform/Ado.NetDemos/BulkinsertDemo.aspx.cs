using System;
using System.Text;
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
    public partial class BulkinsertDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //convert each boundField added to grid view to template on design envir
            // in the source file, remove'EdithItem' and label 'ItemField' and drag and drop a textbox
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();
            DataColumn dc1 = new DataColumn("Name");
            DataColumn dc2 = new DataColumn("Position");
            DataColumn dc3 = new DataColumn("City");
            DataColumn dc4 = new DataColumn("State");

            dtable.Columns.Add(dc1);
            dtable.Columns.Add(dc2);
            dtable.Columns.Add(dc3);
            dtable.Columns.Add(dc4);

            DataRow drow;
            for(int i=0;i<=3;i++)
            {
                // the drow[0] means [newrow,column0]. so 0-4 stand for the 4 columns
                drow = dtable.NewRow();
                drow[0] = string.Empty;
                drow[1] = string.Empty;
                drow[2] = string.Empty;
                drow[3] = string.Empty;
                dtable.Rows.Add(drow);
            }
            dset.Tables.Add(dtable);
            GridView1.DataSource = dset;
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetail x = new UserDetail();
            GridView gv = new GridView();
            DataSet dset = new DataSet();
            //int rowscount = GridView1.Rows.Count;
            //int columnscount = GridView1.Columns.Count;
            //for (int i =0;i<GridView1.Rows.Count;i++)
            //{
            //    for(int j=0;j<columnscount;j++)
            //    x.CusName=GridView1.Rows.Cells[i][j]
            //        int counter = x.BulkInsert();
            //    if (counter.Equals(1))
            //    {
            //        Label5.Text = "<h2> Good! Your profile is Updated </h2>";
            //    }
            //    else
            //    {
            //        Label5.Text = "<h2> Sorry! Your profile is'nt Updated </h2>";
            //    }
            //}
            ////StringBuilder sb = new StringBuilder();
            //sb.Append("<root>");
            //for(int i=0;i< GridView1.Rows.Count; i++)
            //{
            //    TextBox txtname = GridView1.Rows[i].FindControl("txtname") as TextBox;
            //    TextBox txtposition = GridView1.Rows[i].FindControl("txtposition") as TextBox;
            //    TextBox txtcity = GridView1.Rows[i].FindControl("txtcity") as TextBox;
            //    TextBox txtstate = GridView1.Rows[i].FindControl("txtstate") as TextBox;

            //    if(txtname.Text.Length !=0)
            //    {
            //        sb.Append("< row Name='" + txtname.Text.Trim() + "'Position='" + txtposition.Text.Trim() +
            //            "'City='" + txtcity.Text.Trim() + "'State='" + txtstate.Text.Trim() + "'/>");

            //    }

            //}
            //sb.Append("</root>");

            //string connstr = "data source=.;initial catalog=ASPtraining; integrated security=true;";
            //SqlConnection cn = null;
            //SqlCommand cm = null;
            //cn = new SqlConnection();
            //cn.ConnectionString = connstr;
            //cm = new SqlCommand();
            //cm.Connection = cn;

            //cm.CommandType = CommandType.StoredProcedure;
            //cm.CommandText = "[uspInsertCustomer2]";
            //cm.Parameters.AddWithValue("@XMLCustomer", sb.ToString());

            //try
            //{
            //    using (cn)
            //    { 
            //        cn.Open();
            //    cm.ExecuteNonQuery();
            //    }
            //    Label1.Text = "Record(s) is inserted successfully";
            //    Label1.ForeColor = System.Drawing.Color.Green;
            //}

            //catch(Exception ex)
            //{
            //    Label1.Text = "An error has occured";
            //    Label1.ForeColor = System.Drawing.Color.Red;

            //}

        }
    }
}