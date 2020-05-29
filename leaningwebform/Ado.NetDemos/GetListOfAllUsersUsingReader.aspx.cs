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
    public partial class GetListOfAllUsersUsingReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDetail x = new UserDetail();
            DataSet dset = new DataSet();
            dset = x.GetlistOfUsers();
            if(dset.Tables[0].Rows.Count>0)
            {
                ListItem ls = new ListItem();

                DataList dl = new DataList();
                dl.DataSource = dset;
                for(int i =0;i< dset.Tables[0].Rows.Count;i++)
                {
                    DropDownList1.Items.Add(dset.Tables[0].Rows[i]["userName"].ToString());

                }
            }
        }
    }
}