using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform
{
    public partial class AjaxDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            calculate("+");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calculate("-");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            calculate("*");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            calculate("/");
        }

        private void calculate(string option)

        {
            int a = Convert.ToInt32 (TextBox1 .Text );
            int b = Convert.ToInt32(TextBox2.Text);
            int c = 0;
            switch (option )
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;


            }
            System.Threading.Thread.Sleep (5000);
            TextBox3.Text = c.ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label5.Text = DateTime.Now.ToString("hh:mm:ss");
            MyTitle.Text = Label5.Text;
        }
    }
}