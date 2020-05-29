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
    public partial class ViewAllUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // disconnected oriented Architecture
                UserDetail x = new UserDetail();
                DataSet dset = new DataSet();
                dset = x.GetAllUser();

                dset.WriteXml(@"C:\Users\Osazee\dsetfiles\players.xlm");
             
                GridView1.DataSource = dset.Tables[1].DefaultView;
                GridView1.DataBind();

                BulletedList1.DataSource = dset;
                BulletedList1.DataTextField = "userName";
                BulletedList1.DataValueField = "userName";
                BulletedList1.DataBind();

                CheckBoxList1.DataSource = dset;
                CheckBoxList1.DataTextField = "userName";
                CheckBoxList1.DataValueField = "userName";
                CheckBoxList1.DataBind();

                DropDownList1.DataSource = dset;
                DropDownList1.DataTextField = "userName";
                DropDownList1.DataValueField = "userName";
                DropDownList1.DataBind();

                RadioButtonList1.DataSource = dset;
                RadioButtonList1.DataTextField = "userName";
                RadioButtonList1.DataValueField = "userName";
                RadioButtonList1.DataBind();

                ListBox1.DataSource = dset;
                ListBox1.DataTextField = "userName";
                ListBox1.DataValueField = "userName";
                ListBox1.DataBind();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet dset = new DataSet();
            dset.ReadXml(@"c:\Users\Osazee\dsetfiles\players.xlm");
            GridView2.DataSource = dset;
            GridView2.DataBind();
        }
    }
}