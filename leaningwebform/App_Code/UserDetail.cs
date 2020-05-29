using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace leaningwebform.App_Code
{
    public class UserDetail
    {
        private string myUserName, myPassword, myCountry, myEmail, cusName, cusPosition, cusCity, cusState;

        public string MyUserName { get => myUserName; set => myUserName = value; }
        public string MyPassword { get => myPassword; set => myPassword = value; }
        public string MyCountry { get => myCountry; set => myCountry = value; }
        public string MyEmail { get => myEmail; set => myEmail = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public string CusPosition { get => cusPosition; set => cusPosition = value; }
        public string CusCity { get => cusCity; set => cusCity = value; }
        public string CusState { get => cusState; set => cusState = value; }
        
        public int CreatUser()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            int Counter = 0;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                //"data source=.;initial catalog=ASPtraining; integrated security=true;";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;

                cm.CommandText = "[uspUserDetailInsert]";
                cm.Parameters.AddWithValue("@userName", MyUserName);
                cm.Parameters.AddWithValue("@passWord", MyPassword);
                cm.Parameters.AddWithValue("@country", MyCountry);
                cm.Parameters.AddWithValue("@email", MyEmail);
                cn.Open();
                Counter = cm.ExecuteNonQuery(); // Use this command for Insert,Update and Delete operation on database


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally

            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (Counter);
        }
        public int Unsubscribe()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            MySessionVariable v = new MySessionVariable();
            string myName = v.My_userName;
            int Counter = 0;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                //"data source=.;initial catalog=ASPtraining; integrated security=true;";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;

                cm.CommandText = "[uspUnsubscribe]";
                cm.Parameters.AddWithValue("@userName", myName);
                cn.Open();
                Counter = cm.ExecuteNonQuery(); // Use this command for Insert,Update and Delete operation on database


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally

            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (Counter);
        }

        public DataSet CheckCredentials()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            DataSet dset = null;
            IDataAdapter sda = null;
            //int Counter = 0;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                //"data source=.;initial catalog=ASPtraining; integrated security=true;";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;

                cm.CommandText = "[uspCheckCredential]";

                cm.Parameters.AddWithValue("@userName", MyUserName);
                cm.Parameters.AddWithValue("@passWord", MyPassword);
                cn.Open();
                sda = new SqlDataAdapter(cm);
                dset = new DataSet();
                sda.Fill(dset);
                //Counter =Convert.ToInt32 (cm.ExecuteScalar().ToString()); // Use this command for if query return 1 value 


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally

            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (dset);

        }
        public int ChamgePassword()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            int Counter = 0;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                //"data source=.;initial catalog=ASPtraining; integrated security=true;";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;

                cm.CommandText = "[uspChangePassword]";
                cm.Parameters.AddWithValue("@userName", MyUserName);
                cm.Parameters.AddWithValue("@passWord", MyPassword);
                cn.Open();
                Counter = cm.ExecuteNonQuery(); // Use this command for Insert,Update and Delete operation on database


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally

            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (Counter);
        }
        public DataSet ChangeProfile()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            SqlDataAdapter sda = null;
            DataSet dset = null;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                //"data source=.;initial catalog=ASPtraining; integrated security=true;";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;

                cm.CommandText = "[uspGetUserDetails]";
                cm.Parameters.AddWithValue("@userName", MyUserName);
                sda = new SqlDataAdapter(cm);
                dset = new DataSet("Users");
                sda.Fill(dset, "User");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally

            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (dset);

        }
        public int UpdateUserProfile()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            int Counter = 0;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = "data source=.;initial catalog=ASPtraining; integrated security=true;";
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;

                cm.CommandText = "[uspChangeProfile]";
                cm.Parameters.AddWithValue("@userName", MyUserName);
                cm.Parameters.AddWithValue("@passWord", MyPassword);
                cm.Parameters.AddWithValue("@country", MyCountry);
                cm.Parameters.AddWithValue("@email", MyEmail);
                cn.Open();
                Counter = cm.ExecuteNonQuery(); // Use this command for Insert,Update and Delete operation on database


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally

            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }
            }
            return (Counter);
        }
        private string GetCs()
        {

            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = ".";
            csb.InitialCatalog = "ASPtraining";
            csb.IntegratedSecurity = true;
            return (csb.ToString());
        }
        private string GetCSFromWebConfig()
        {
            string str = ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString;
            return (str);
        }
        // dataset is a collection of tables
        // table is a collection of rows
        // rows is a collection of columns
        public DataSet GetlistOfUsers()
        {
            SqlConnection cn = null;
            SqlDataAdapter ad = null;
            SqlCommand cm = null;
            DataSet dset = null;
            MySessionVariable v = new MySessionVariable();
            string myName = v.My_userName;

            try
            {
                cm = new SqlCommand();
                cn = new SqlConnection();
                ad = new SqlDataAdapter();
                //cn.ConnectionString = GetCs();
                cn.ConnectionString = GetCSFromWebConfig();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "uspUserDetailSelect";
                cm.Parameters.AddWithValue("@userName", myName);
                ad = new SqlDataAdapter(cm);
                dset = new DataSet("Users");
                ad.Fill(dset, "User");

            }
            catch (Exception ex)

            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (!cn.Equals(null))
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;

                }
            }

            return (dset);

        }
        public DataSet GetAllUser()
        {
            SqlConnection cn = null;
            SqlDataAdapter ad = null;
            SqlCommand cm = null;
            DataSet dset = null;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "[uspGetAllUsers]";
                ad = new SqlDataAdapter(cm);
                dset = new DataSet("Users");
                ad.Fill(dset, "User");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (dset);
        }

        // connected oriented architecture
        // read only
        // forward only  
        public SqlDataReader GetAllUserusingReader()
        {
            SqlConnection cn = null;
            SqlCommand cm = null;
            SqlDataReader sdr = null;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "[uspAllUsers]";
                cn.Open();
                sdr = cm.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (sdr);
        }
        public DataSet GetAllCountries()
        {
            SqlConnection cn = null;
            SqlDataAdapter ad = null;
            SqlCommand cm = null;
            DataSet dset = null;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "[uspGetListOfCountries]";
                ad = new SqlDataAdapter(cm);
                dset = new DataSet("Users");
                ad.Fill(dset, "User");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (dset);
        }

        public DataSet GetAllCountriesWiseUsers()
        {
            SqlConnection cn = null;
            SqlDataAdapter ad = null;
            SqlCommand cm = null;
            DataSet dset = null;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = GetCSFromWebConfig();
                cm = new SqlCommand();
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "[uspGetListOfCountriesWise]";
                cm.Parameters.AddWithValue("@country", MyCountry);
                ad = new SqlDataAdapter(cm);
                dset = new DataSet("Users");
                ad.Fill(dset, "User");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return (dset);
        }

        public int BulkInsert()
        {
            int counter = 0;
            string connstr = "data source=.;initial catalog=ASPtraining; integrated security=true;";
            SqlConnection cn = null;
            SqlCommand cm = null;
            cn = new SqlConnection();
            cn.ConnectionString = connstr;
            cm = new SqlCommand();
            cm.Connection = cn;

            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "[uspInsertCustomer2]";
            cm.Parameters.AddWithValue("@cusName", CusName);
            cm.Parameters.AddWithValue("@cusPosition", CusPosition);
            cm.Parameters.AddWithValue("@cusCity", CusCity);
            cm.Parameters.AddWithValue("@cusState", CusState);
            cn.Open();
            cm.ExecuteNonQuery();

            //Label1.Text = "Record(s) is inserted successfully";
            //Label1.ForeColor = System.Drawing.Color.Green;
            //}

            //catch (Exception ex)
            //{
            //    Label1.Text = "An error has occured";
            //    Label1.ForeColor = System.Drawing.Color.Red;

            //}

            return (counter);
            cn.Close();
            cn = null;
        }
        public void Calculate(int a, int b, out int c, out int d, out int e, out int f)

        {
            string connstr = "data source=.;initial catalog=ASPtraining; integrated security=true;";
            int counter = 0;
            SqlConnection cn = null;
            SqlCommand cm = null;
            SqlParameter p1 = null;
            SqlParameter p2 = null;
            SqlParameter p3 = null;
            SqlParameter p4 = null;
            SqlParameter p5 = null;
            SqlParameter p6 = null;

            try
            {
                c = d = e = f = 0;
                cn = new SqlConnection();
                cm = new SqlCommand();
                p1 = new SqlParameter("@a", SqlDbType.Int);
                p2 = new SqlParameter("@b", SqlDbType.Int);
                p3 = new SqlParameter("@c", SqlDbType.Int);
                p4 = new SqlParameter("@d", SqlDbType.Int);
                p5 = new SqlParameter("@e", SqlDbType.Int);
                p6 = new SqlParameter("@f", SqlDbType.Int);

                cn.ConnectionString = connstr;
                cm.Connection = cn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "uspCalculate";


                p3.Direction = ParameterDirection.Output;
                p4.Direction = ParameterDirection.Output;
                p5.Direction = ParameterDirection.Output;
                p6.Direction = ParameterDirection.Output;

                p1.Value = a;
                p2.Value = b;

                cm.Parameters.Add(p1);
                cm.Parameters.Add(p2);
                cm.Parameters.Add(p3);
                cm.Parameters.Add(p4);
                cm.Parameters.Add(p5);
                cm.Parameters.Add(p6);

                cn.Open();
                 counter = cm.ExecuteNonQuery();

                c = Convert.ToInt32(p3.Value.ToString());
                d = Convert.ToInt32(p4.Value.ToString());
                e = Convert.ToInt32(p5.Value.ToString());
                f = Convert.ToInt32(p6.Value.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }

            }
        }
    }
}