using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace leaningwebform.standardcontroldemo
{
    public partial class uploadmultiplefiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpFileCollection ozfc = Request.Files;
            for (int i=0;i<ozfc.Count; i++)
            {
                HttpPostedFile ozpf = ozfc[i];
                if (ozpf.ContentLength > 0)
                {
                    ozpf.SaveAs(@"C:\cv\" + Path .GetFileName ( ozpf.FileName));
                }
            }
            Label5.Text = "<h2>The Files Are Loaded</h2>";
        }
    }
}