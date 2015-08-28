using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class myorderstatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            I6.Attributes.Add("src", "getOrderStatus.aspx/?V6=" + Session["Name"].ToString());
        }
    }
}