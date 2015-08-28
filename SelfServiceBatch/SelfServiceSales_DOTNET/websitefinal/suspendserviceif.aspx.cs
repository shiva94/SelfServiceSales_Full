using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class suspendserviceif : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            I1.Attributes.Add("src", "http://192.168.0.12:8080/SelfServiceSales/Suspend?V1=" +  Session["Name"]);

          

            
        }
    }
}