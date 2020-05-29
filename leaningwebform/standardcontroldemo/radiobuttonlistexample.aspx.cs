using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class radiobuttonlistexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = RadioButtonList1.SelectedValue.ToUpper();
            Calculate(str);

        }
        private void Calculate(string  option)
        {
            double netsalary, salary, allowance = 0;
            salary = Convert.ToDouble(TextBox1.Text);
            switch (option)
            {
                case "HRA":
                    allowance = salary * 10 / 100;
                    break;
                case "TA":
                    allowance = salary * 20 / 100;
                    break;
                case "MA":
                    allowance = salary * 30 / 100;
                    break;
                case "IA":
                    allowance = salary * 40 / 100;
                    break;
            }
            netsalary = salary + allowance;
            TextBox2.Text = netsalary.ToString();

        }
    }
}