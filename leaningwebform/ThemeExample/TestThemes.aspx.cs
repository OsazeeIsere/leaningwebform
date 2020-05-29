using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.ThemeExample
{
    public partial class TestThemes : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            switch (Request.QueryString["theme"])
            {
                case "Season":
                    Page.Theme = "Season";
                        break;
                case "Weather":
                    Page.Theme = "Weather";
                    break;


            }
           
        }
    }
}