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
    public partial class CreateUsersXMLFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {

                
                UserDetail x = new UserDetail();
                DataSet dset = new DataSet();
                dset = x.GetAllUser();
                    string XMLFile1 = Server.MapPath("MyXMLFile.xml");


                    // Use WriteXml to write the document.
                    DataSet ds1 = new DataSet();
                    dset.WriteXml(XMLFile1);
                    dset.ReadXml(Request.PhysicalApplicationPath + "MyXMLFile.xml");
                    XMLFile1.Equals(dset);




                    GridView1.DataSource = dset;
                    GridView1.AllowPaging = true;
                    GridView1.PageSize = 6;
                    GridView1.DataBind();

                    //XmlDataDocument xmlDoc = new XmlDataDocument(dset);

                    //xmlDoc.Save(@"C:\Users\Osazee\Desktop\leaningwebform\leaningwebform\MyXML\Users.xml)");
                Label1.Text = "Yes! An Xml file is created";
                }
                catch(Exception ex)
                {
                  Label1.Text=ex.Message;
                }
            }

        }
    }
}