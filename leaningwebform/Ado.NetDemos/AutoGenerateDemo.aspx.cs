﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using leaningwebform.App_Code;
namespace leaningwebform.Ado.NetDemos
{
    public partial class AutoGenerateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet dset = null;
                UserDetail x = new UserDetail();
                dset = new DataSet();
                dset = x.GetAllUser();
                //ViewState["vw AllUsers"] = dset2;
                GridView1.DataSource = dset;
                GridView1.DataBind();


            }

        }
    }
}