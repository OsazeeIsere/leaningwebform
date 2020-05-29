using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform
{
    public partial class fileuploadexamples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1 .HasFile)
            {
                if (!FileUpload1.PostedFile.FileName .ToUpper().EndsWith("EXE"))
                {
                    FileUpload1.SaveAs(@"C:\cv\" + FileUpload1.FileName );
                    Label2.Text = "<h2>The file is Suceessfully Uploaded</h2>";
                    Label4.Text = FileUpload1.PostedFile.ContentType.ToString();
                    Label6.Text = FileUpload1.PostedFile.ContentLength.ToString();
                }
                else
                {
                    Label2.Text = "<h2> Please You Are Not allowed To Upload An Executabe File";
                }
            }
            else
            {
                Label2.Text = "<h2>Please Select a File</h2>";
            }
        }
    }
}