using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class checkboxexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            calculate("HRA", CheckBox1.Checked);
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            calculate("MA", CheckBox2.Checked);
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            calculate("IA", CheckBox3.Checked);
        }

        private void calculate(string option, bool blchecked)
        {
            double netsalary, salary, allowance = 0;
            salary = Convert.ToDouble(TextBox1.Text);
            netsalary = Convert.ToDouble(TextBox2.Text);
            if (netsalary.Equals(0))
                netsalary = salary;
            switch (option)
            {
                case "HRA":
                    allowance = salary * 10 / 100;
                    break;
                case "MA":
                    allowance = salary * 20 / 100;
                    break;
                case "IA":
                    allowance = salary * 30 / 100;
                    break;
            }
            if (blchecked)
            {
                netsalary += allowance;
                TextBox2.Text = netsalary.ToString();
            }
          
        else
            {
                netsalary = netsalary + allowance;
                TextBox2.Text = "0";
            }
            
        }
    }
}