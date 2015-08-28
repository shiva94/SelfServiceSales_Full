using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class addserviceif : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            I2.Attributes.Add("src", "http://192.168.0.143:8081/client/CustId?V2=" + Session["Name"]);
        }
    }
}