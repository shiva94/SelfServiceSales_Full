using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class viewbill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            I5.Attributes.Add("src", "http://192.168.0.16:8085/billing/Connection1?id=" + Session["Name"]);

        }
    }
}