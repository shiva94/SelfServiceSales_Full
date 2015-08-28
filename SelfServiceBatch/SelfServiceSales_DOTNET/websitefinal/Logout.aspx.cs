using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("User");
            Session.Remove("Name");
            Session.Remove("Uname");
            Session.RemoveAll();
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}