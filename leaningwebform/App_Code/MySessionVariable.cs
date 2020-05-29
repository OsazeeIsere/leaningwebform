using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace leaningwebform.App_Code
{

    public class MySessionVariable
    {
        private string my_userName;


        public string My_userName
        {

            get

            {
                if (HttpContext.Current.Session["sess_userName"] != null)
                {

                    return HttpContext.Current.Session["sess_userName"].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                HttpContext.Current.Session["sess_userName"] = value;

            }
        }
    }
}