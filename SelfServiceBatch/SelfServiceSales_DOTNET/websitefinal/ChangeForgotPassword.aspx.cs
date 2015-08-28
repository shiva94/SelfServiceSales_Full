using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Services;

namespace websitefinal
{
    public partial class ChangeForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Uname"].ToString(); 
        }
        [WebMethod]
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
            con.Open();
            string str1 = "select * from LoginPage where Customer_id=" + Session["Uname"].ToString();
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //if (TextBox1.Text == TextBox2.Text)
                //{
                SqlConnection con1 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
                    con1.Open();
                    string str = "update LoginPage set Password='" + TextBox2.Text + "'where Customer_id=" + Session["Uname"].ToString();
                    SqlCommand cmd1 = new SqlCommand(str, con1);
                    cmd1.ExecuteNonQuery();
                    Label4.Text = "Your Password has been changed successfully and Your Redirecting to Login Page in 2 Seconds";
                    con1.Close();
                    con.Close();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
    "setTimeout(function() { window.location.replace('Login.aspx') }, 2000);", true);

                //}
                //else
                //{
                //    Label4.Text = "Your confirm Password is incorrect ";

                //}
            }
            else
            {
                Label4.Text = " Your User Name is incorrect try again... ";
            }
        }
    }
}