using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class radiobuttonexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Calculate(1);
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Calculate(2);
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Calculate(3);
        }

        private void Calculate(int option)
        {
            double netsalary, salary, allowance=0;
            salary = Convert.ToDouble(TextBox1.Text);
            switch (option )
            {
                case 1:
                    allowance = salary*10 / 100;
                    break;
                case 2:
                    allowance = salary*20 / 100;
                    break;
                case 3:
                    allowance = salary*30 / 100;
                    break;
            }
            netsalary = salary+allowance ;
            TextBox2.Text = netsalary.ToString ();

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}