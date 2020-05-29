using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
namespace leaningwebform.standardcontroldemo
{
    public partial class tableExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page .IsPostBack)
            {
                TableRow tr1 = new TableRow();
                TableCell c1 = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
                c1.Text = "ECode";
                c2.Text = "EName";
                c3.Text = "Salary";
                tr1.Cells.Add(c1);
                tr1.Cells.Add(c2);
                tr1.Cells.Add(c3);
                Table1.Rows.Add(tr1);

                for (int i = 65; i <= 90; i++)
                {
                    tr1 = new TableRow();
                    c1 = new TableCell();
                    c2 = new TableCell();
                    c3 = new TableCell();
                    c1.Text = i.ToString();
                    c2 .Text = ((char)i).ToString();
                    c3.Text = (i * 1000).ToString();
                    tr1.Cells.Add(c1);
                    tr1.Cells.Add(c2);
                    tr1.Cells.Add(c3);
                    Table1.Rows.Add(tr1);
                    Table1.BackColor = Color.Red;
                    Table1.ForeColor = Color.White;
                    
                }
            }
            

        }
    }
}