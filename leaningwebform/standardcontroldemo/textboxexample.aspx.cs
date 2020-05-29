using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.standardcontroldemo
{
    public partial class textboxexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page .IsPostBack)
            {
                txtemployeenamme.Focus();
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtsalary.Text = string.Empty;
            txthra.Text = string.Empty;
            txtta.Text = string.Empty;
            txtma.Text = string.Empty;
            txtnetsalary.Text = string.Empty;
            txtemployeenamme.Focus();

        }

        protected void btncalculate_Click(object sender, EventArgs e)
        {
            double netsalary, salary, hra, ta, ma;
            salary = Convert.ToDouble(txtsalary.Text);
            hra = Convert.ToDouble(txthra.Text);
            ta = Convert.ToDouble(txtta .Text);
            ma = Convert.ToDouble(txtma.Text);
            netsalary = salary + hra + ta + ma;
            txtnetsalary.Text = netsalary.ToString();
        }
    }
}