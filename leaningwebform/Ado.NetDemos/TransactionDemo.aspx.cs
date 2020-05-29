using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using leaningwebform.App_Code;
namespace leaningwebform.Ado.NetDemos
{
    public partial class TransactionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ExecuteSqlTransaction();
        }

        public void ExecuteSqlTransaction()
        {
            UserDetail x = new UserDetail();
            SqlConnection cn = null;
            string constr = GetCSFromWebConfig();

            // using a using keyword inside a block has advantage of having any need to close connection
            using (cn = new SqlConnection(constr))
            {
                cn.Open();

                SqlCommand cm = cn.CreateCommand();
                // start a transaction
                SqlTransaction myTransaction;
                myTransaction = cn.BeginTransaction("Sample Transaction");

                cm.Connection = cn;
                cm.Transaction = myTransaction;

                try
                {
                    cm.CommandType = CommandType.Text;
                    cm.CommandText = "Insert into userDetails(userName,password) values('Osasu Odia','come')";
                    cm.ExecuteNonQuery();

                    cm.CommandText = "Insert into region(regionid,regionDescription)values('234','Ikpoba Okha')";
                    cm.ExecuteNonQuery();

                    myTransaction.Commit();

                }
                catch (Exception ex)
                {
                    try
                    {
                        myTransaction.Rollback();

                    }
                    catch(Exception e2)
                    {
                        throw new Exception (e2.Message);
                    }
                }

            }
        }
        private string GetCSFromWebConfig()
        {
            string str = ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;
            return (str);
        }

    }
}