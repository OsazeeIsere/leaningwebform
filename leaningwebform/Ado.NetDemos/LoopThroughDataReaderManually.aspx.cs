using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using leaningwebform.App_Code;
using System.Configuration;

namespace leaningwebform.Ado.NetDemos
{
    public partial class LoopThroughDataReaderManually : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserDetail x = new UserDetail();
                SqlDataReader sdr = x.GetAllUserusingReader();
                ShowData(sdr);

            }
        }

        private void ShowData(SqlDataReader sdr)
        {
            bool blHasTable = true;
            while (blHasTable)
            {
                Response.Write("<table border=5 bgColor=red>");
                Response.Write("<tr>");

                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Response.Write("<td>");
                    Response.Write(sdr.GetName(i));
                    Response.Write("</td>");
                }    
                    Response.Write("</tr>");

                    while(sdr.Read())
                    {
                        Response.Write("<tr>");

                        for (int i = 0; i < sdr.FieldCount; i++)
                        {
                            Response.Write("<td>");
                            Response.Write(sdr.GetValue(i));
                            Response.Write("</td>");
                        }

                        Response.Write("</tr>");

                    }

                Response.Write("/table");
                blHasTable = sdr.NextResult();

            }

        }
    }
}