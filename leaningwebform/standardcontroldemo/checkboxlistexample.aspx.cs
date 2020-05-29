using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class checkboxlistexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double netsalary=0, salary, allowance = 0;
            salary = Convert.ToDouble(TextBox1.Text);
            foreach (ListItem li in CheckBoxList1 .Items )
            {
                switch (li .Text )

                {
                    case "HRA":
                        allowance += salary * 10 / 100;
                        break;
                    case "TA":
                        allowance += salary * 10 / 100;
                        break;
                    case "IA":
                        allowance += salary * 10 / 100;
                        break;
                    case "MA":
                        allowance += salary * 10 / 100;
                        break;
                }
            }
            netsalary = salary + allowance;
            TextBox2.Text = netsalary.ToString();
                
        }
    }
}