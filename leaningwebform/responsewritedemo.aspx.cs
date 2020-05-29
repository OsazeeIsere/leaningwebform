using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaningwebform
{
    public partial class responsewritedemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to ASP.NET");
            Response.Write("<br><b>Welcome to ASP.NET<b><br>");
            Response.Write("<br><i>Welcome to ASP.NET<i><br>");
            Response.Write("<br><u>Welcome to ASP.NET<u><br>");

            Response.Write("<br><b><i><u>Welcome to ASP.NET<U><I><b><br>");
            Response.Write("<ul>");
            Response.Write("<li> Expert System</li>");
            Response.Write("<li> Advance Data Base</li>");
            Response.Write("<li> Data Structure</li>");

            Response.Write("</ul>");

            Response.Write("<ol>");
            Response.Write("<li> Expert System</li>");
            Response.Write("<li> Advance Data Base</li>");
            Response.Write("<li> Data Structure</li>");

            Response.Write("</ol>");
            //creating table
            Response.Write("<table align='center'border='5' bgcolor='aqua'>");
            Response.Write("<tr><td>Course Name</td><td>Duration</td><td>Price</td>");
            Response.Write("<tr><td>Expert System</td><td>22</td><td>1</td>");
            Response.Write("<tr><td>Advance Data Base</td><td>33</td><td>2</td>");
            Response.Write("<tr><td>Data Structure</td><td>21</td><td>3</td>");
            Response.Write("<tr><td>Algorithm Design</td><td>41</td><td>4</td>");


            Response.Write("</table>");

        }
    }
}