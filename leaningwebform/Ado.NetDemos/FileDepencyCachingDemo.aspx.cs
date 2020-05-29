using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using System.Data.SqlClient;
using leaningwebform.App_Code;
using System.Xml;

namespace leaningwebform.Ado.NetDemos
{
    public partial class FileDepencyCachingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    UserDetail x = new UserDetail();
                    DataSet dset = new DataSet();
                    if (Cache["myXmlCache"] == null)
                    {
                        dset.ReadXml(Server.MapPath("MyXMLFile.xml"));

                        //dset.ReadXml(Server.MapPath("../App_Data/MyXMLFile.xml"));

                        Cache.Insert("myXmlCache", dset, new System.Web.Caching.CacheDependency(Server.MapPath("MyXMLFile.xml")));
                        Label1.Text = "A cache is generated";
                        //dset.ReadXml(Request.PhysicalApplicationPath + "MyXMLFile.xml");
                        //XMLFile1.Equals(dset);

                    }
                    else
                    {
                        Label1.Text = "Use pre generated cache";
                    }
                    GridView1.DataSource = Cache["myXmlCache"];
                    //GridView1.AllowPaging = true;
                    //GridView1.PageSize = 6;
                    GridView1.DataBind();


                }
                catch (Exception ex)
                {
                    Label1.Text = ex.Message;
                }
            }
        }
    }
}