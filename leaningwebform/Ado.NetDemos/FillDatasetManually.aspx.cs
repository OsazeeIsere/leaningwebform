using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace leaningwebform.Ado.NetDemos
{
    public partial class FillDatasetManually : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            DataSet dset = new DataSet();
            DataTable dtable = new DataTable();
            DataColumn dcol1 = new DataColumn("ECODE");
            DataColumn dcol2 = new DataColumn("NAME");
            DataColumn dcol3 = new DataColumn("SALARY");
            DataRow drow;
            dtable.Columns.Add(dcol1);
            dtable.Columns.Add(dcol2);
            dtable.Columns.Add(dcol3);
            // ASCII values of 65-90
            for(int i = 65; i <= 90; i++)
            {
                drow = dtable.NewRow();
                drow[0] = i.ToString();
                drow[1] =((char)i).ToString();
                drow["SALARY"] = i * 1000;
                dtable.Rows.Add(drow);
            }
            // GridView1.DataSource = dtable;
            //this above code works too. or we say:
            dset.Tables.Add(dtable);
            GridView1.DataSource = dset;
            GridView1.DataBind();
        }
    }
}