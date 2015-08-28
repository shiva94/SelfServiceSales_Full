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
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
            con.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(*) FROM LoginPage WHERE Customer_id=" + Username.Text + " and SecurityQuestion='" + DropDownList1.Text + "' and Answers='" + Answer.Text + "'");
            cmd.Connection = con;
            int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
            if (OBJ > 0)
            {
                Session["Uname"] = Username.Text;
                //Response.Cookies["fp"].Value = Label1.Text;
                Response.Redirect("ChangeForgotPassword.aspx");
                con.Close();
            }
            else
            {
                Label5.Text = " Your Que or Ans is incorrect... try again... ";

            }
        }
    }
}