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
    public partial class ShowCountryWiseUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // here we are keeping multiple version of cache by setting the VaryByParam on the source page
            // to Variable that determine the output. this case the dropdownlist1
            if (!Page.IsPostBack)
            {
                DataSet dset = null;
                 dset = new DataSet();
                UserDetail x = new UserDetail();
                dset = x.GetAllCountries();
                DropDownList1.DataSource = dset;
                DropDownList1.DataTextField = "Country";
                DropDownList1.DataValueField = "country";
                DropDownList1.DataBind();

                ListItem li = new ListItem("All Users", "All Users");
                DropDownList1.Items.Insert(0, li);

                DataSet dset2 = new DataSet();
                dset2 = x.GetAllUser();
                ViewState["vw AllUsers"] = dset2;
                GridView1.DataSource = dset2;
                GridView1.DataBind();


            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.SelectedItem.Text;
            // type cast the view state to a dataset object
            DataSet dset1 = (DataSet)ViewState["vw AllUsers"];

            // a dataview is a copy or a subset of a dataset that helps to filtered record
            //instead of going repeatedly to the sql server
            DataView dv = dset1.Tables[0].DefaultView;
            if (str != "All Users")
            { 
                dv.RowFilter ="country='"+ str + "'";
                dv.Sort = "userName desc";
            }
            GridView1.DataSource = dv;
            GridView1.DataBind();

            // these lines of code where communicating with server on each request
            //UserDetail x = new UserDetail();
            //x.MyCountry = str;
            //DataSet dset = new DataSet();
            //if(str!="All Users")
            //{ 
            //dset = x.GetAllCountriesWiseUsers();
            //}
            //else
            //{
            //    dset = x.GetAllUser();
            //}
            //GridView1.DataSource = dset;

            //GridView1.DataBind();
        }
    }
}