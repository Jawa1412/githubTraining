using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/WebForm2.aspx",false);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("http://google.com");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Execute("~/WebForm2.aspx", false);
        }
    }
}