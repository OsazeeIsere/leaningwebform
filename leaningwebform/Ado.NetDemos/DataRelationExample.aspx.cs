using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using leaningwebform.App_Code;

namespace leaningwebform.Ado.NetDemos
{
    public partial class DataRelationExample : System.Web.UI.Page
    {
        DataSet dset;
        DataRelation UserContact;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetail x = new UserDetail();
                dset = x.GetAllUser();
                ViewState["Rel"]= dset;
                UserContact = dset.Relations.Add("userContact", dset.Tables[0].Columns["userid"],
                    dset.Tables[1].Columns["userid"]);

                GridView1.DataSource = dset;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            dset = (DataSet)ViewState["Rel"];
            DataColumn[] dcpk = new DataColumn[1];
            // set primary key
            dcpk[0] = dset.Tables[0].Columns["userid"];
            dset.Tables[0].PrimaryKey = dcpk;
            // trying to capture the primary key cell
            DataRow drFound;
            drFound = dset.Tables[0].Rows.Find(gvr.Cells[5].Text);
            DataRow[] childRow = drFound.GetChildRows("userContact");
            DataTable filteredTable = new DataTable();
            DataColumn dc1 = new DataColumn("userid");
            DataColumn dc2 = new DataColumn("contactid");
            DataColumn dc3 = new DataColumn("phonenumber");
            DataColumn dc4 = new DataColumn("landline");
            DataColumn dc5 = new DataColumn("fax");
            filteredTable.Columns.Add(dc1);
            filteredTable.Columns.Add(dc2);
            filteredTable.Columns.Add(dc3);
            filteredTable.Columns.Add(dc4);
            filteredTable.Columns.Add(dc5);
            foreach(DataRow dr in childRow)
            {
                filteredTable.ImportRow(dr);
            }
            GridView2.DataSource = filteredTable;
            GridView2.DataBind();






        }
    }
}
