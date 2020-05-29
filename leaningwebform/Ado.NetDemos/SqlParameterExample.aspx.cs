using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using leaningwebform.App_Code; 

namespace leaningwebform.Ado.NetDemos
{
    public partial class SqlParameterExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs ee)
        {
            UserDetail x = new UserDetail();
            int a,b,c,d,e,f;
            a =Convert.ToInt32( txta.Text);
            b =Convert.ToInt32( txtb.Text);

            x.Calculate(a, b, out c, out d, out e, out f);

            txtc.Text = c.ToString();
            txtd.Text = d.ToString();
            txte.Text = e.ToString();
            txtf.Text = f.ToString();
        }
    }
}