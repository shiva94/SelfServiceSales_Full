using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Services;
using System.Data.OleDb;

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
            OleDbConnection con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.80/orcl;User Id=scott;Password=tiger;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select COUNT(*) FROM custo1 WHERE custid=" + Username.Text,con);
            OleDbDataReader dr=cmd.ExecuteReader();
            //SqlCommand cmd = new SqlCommand(str1, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
            //SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Verizon;Data Source=.");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select COUNT(*) FROM LoginPage WHERE Customer_id=" + Username.Text);
            //cmd.Connection = con;
            //int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
            //if (OBJ > 0)
            //{
                if (Password.Text == Username.Text)
                {
                    SqlConnection con1 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Verizon;Data Source=.");
                    con1.Open();
                    string str = "update LoginPage set Password='" + Password.Text + "'where Customer_id=" + Username.Text;
                    SqlCommand cmd1 = new SqlCommand(str, con1);
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    Session["User"] = Username.Text;
                    Response.Redirect("Change_Password.aspx");
                }
                else
                    {
                        Label3.Text = "Invalid username or password";
                    }

            }
                else
                { 
                    SqlConnection con1 = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Verizon;Data Source=.");
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("select COUNT(*) FROM LoginPage WHERE Customer_id=" + Username.Text + " and Password='" + Password.Text + "'");
                    cmd1.Connection = con1;
                    int OBJ1 = Convert.ToInt32(cmd.ExecuteScalar());
                    if (OBJ1 > 0)
                    {

                        Session["Name"] = Username.Text;
                        //Response.Cookies["lp"].Value = Username.Text;
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        Label3.Text = "Invalid username or password";
                    }
                }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}