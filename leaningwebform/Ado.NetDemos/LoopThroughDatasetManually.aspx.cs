using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code;
using System.Data;
namespace leaningwebform.Ado.NetDemos
{
    public partial class LoopThroughDatasetManually : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetail x = new UserDetail();
                DataSet dset = new DataSet();
                dset = x.GetAllUser();
                ShowData(dset);
            }
        }

        private void ShowData(DataSet dset)
        {

            Response.Write("<table border=5 bgColor=agua>");
            for (int k = 0; k < dset.Tables.Count; k++)
            {

                Response.Write("<tr>");
            for(int i = 0; i < dset.Tables[k].Columns.Count; i++)
            {
                Response.Write("<td>");
                Response.Write(dset.Tables[k].Columns[i].Caption);
                Response.Write("</td>");
            }

            Response.Write("</tr>");

          
            
            for(int j=0;j<dset.Tables[k].Rows.Count;j++)
            {
                    if (dset.Tables[k].Rows[j]["country"].ToString().Equals("Nigeria"))
                    {
                        Response.Write("<tr bgColor='green'>");
                    }
                    else
                    {
                        Response.Write("<tr>");
                    }
                for (int i = 0; i < dset.Tables[k].Columns.Count; i++)
                {
                    Response.Write("<td>");
                    Response.Write(dset.Tables[k].Rows[j][i]);
                    Response.Write("</td>");
                }

                Response.Write("</tr>");

            }
            }
            Response.Write("</table>");

        }
    }
}