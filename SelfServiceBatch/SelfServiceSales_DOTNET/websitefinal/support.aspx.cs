using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class support : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            I3.Attributes.Add("src", "http://192.168.0.182:8080/SelfService/selfService.jsp?customerId=" + Session["Name"]);
        }
    }
}