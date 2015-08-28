using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mywebsite
{
    public partial class ViewBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("http://192.168.0.16:8085/billing/Connection1?V1=" + "V5" );
        }
    }
}