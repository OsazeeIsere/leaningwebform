using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code;
namespace leaningwebform.Ado.NetDemos
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserDetail x = new UserDetail();
            int counter = 0;
            try
            {
                // From UI controls --> Class Properties---> stored proce. parameter---> table field

                x.MyUserName = TextBox1.Text;
                x.MyPassword = TextBox2.Text;
                x.MyCountry = DropDownList1.SelectedItem.Text;
                x.MyEmail = TextBox3.Text;
                counter = x.CreatUser();
                if (counter.Equals(1))
                {
                    Label5.Text = "<h2> Congratulation! </h2>";
                }
            }
            catch(Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
    }
}