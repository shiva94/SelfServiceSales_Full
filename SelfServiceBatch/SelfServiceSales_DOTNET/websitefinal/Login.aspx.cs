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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Session.RemoveAll();
        }
        [WebMethod]
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
            con.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(*) FROM LoginPage WHERE Customer_id=" + Username.Text +"and Password='" +Password.Text+"'");
            cmd.Connection = con;
            int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
            if (OBJ > 0)
            {
                if (Password.Text == Username.Text)
                {
                    //Response.Cookies["User"].Value = Login1.UserName;
                    Session["User"] = Username.Text;
                    Response.Redirect("Change_Password.aspx");
                }
                else
                {
                    Session["Name"] = Username.Text;
                    //Response.Cookies["lp"].Value = Username.Text;
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                Label3.Text = "Invalid username or password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}