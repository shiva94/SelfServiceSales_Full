using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace websitefinal
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //    OleDbConnection cn = new OleDbConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger;");
        //    cn.Open();
        //    var cmd = new OleDbCommand("select * from customer", cn);
        //    int row = cmd.ExecuteNonQuery();
        //    return row;
            
            Label1.Text = Session["Name"].ToString();
            
 
            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
    "setTimeout(function() { window.location.replace('Login.aspx') }, 2000);", true);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("User");
            Session.Remove("Name");
            Session.Remove("Uname");
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}