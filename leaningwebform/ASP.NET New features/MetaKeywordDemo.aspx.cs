﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform.ASP.NET_New_features
{
    public partial class MetaKeywordDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MetaKeywords = ".NET, MSI, SQL SERVER";
            Page.MetaDescription = "My Online Courses";

        }
    }
}