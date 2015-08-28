using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;

namespace websitefinal
{
    public partial class Change_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["User"].ToString();

        }
        [WebMethod]
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
            con.Open();
            string str1 = "select * from LoginPage where Password ='" + TextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //if (TextBox3.Text == TextBox2.Text)
                //{
                SqlConnection con1 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
                    con1.Open();
                    string str = "update LoginPage set Password='" + TextBox2.Text + "'where Password= '" + TextBox1.Text + "'and Customer_id=" + Session["User"].ToString();
                    SqlCommand cmd1 = new SqlCommand(str, con1);
                    cmd1.ExecuteNonQuery();
                    Label5.Text = "Your Password has been changed successfully and Your Redirecting to Login Page in 2 Seconds ";
                    con1.Close();
                    con.Close();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "redirectJS",
    "setTimeout(function() { window.location.replace('Login.aspx') }, 2000);", true);
                //}
                //else
                //{
                //    Label5.Text = "Your Confirm New Password is incorrect ";

                //}
            }
            else
            {
                Label5.Text = " Your old Password is incorrect try again... ";
            }
        }

    }
}