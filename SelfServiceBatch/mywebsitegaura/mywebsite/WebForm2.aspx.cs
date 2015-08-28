using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace mywebsite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=abcdef;Data Source=.");
            adp = new SqlDataAdapter("Select * from EmployeeData$ ", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Emp");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            GridView2.DataSource = ds;
            GridView2.DataBind();
       }
    }
}