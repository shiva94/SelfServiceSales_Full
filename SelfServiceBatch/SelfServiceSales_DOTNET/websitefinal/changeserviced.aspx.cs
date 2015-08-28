using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace websitefinal
{
    public partial class addserviced : System.Web.UI.Page
    {
        //SqlConnection con = null;
        //SqlDataAdapter adp = null;
        ////object o;
        ////object p;
        protected void Page_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user61;Data Source=.");
            //adp = new SqlDataAdapter("select service_id,service_name from cust where customer_id=101", con);


            //DataSet ds = new DataSet();
            //adp.Fill(ds, "cus");
            //DataView dv = new DataView(ds.Tables["cus"]);
            Session["User"] = Session["Name"].ToString();
            getservice.Service1SoapClient f = new getservice.Service1SoapClient();
            getservice.Class2[] mn = f.getservice(Convert.ToInt32(Session["Name"]));
         
         
            
               GridView1.DataSource = mn;
                GridView1.DataBind();

            
          
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            //Response.Redirect("displayproductchange.aspx");
            //productlist.GetAllProductsSoapClient s = new productlist.GetAllProductsSoapClient();
            //productlist.ProductClass[] pc = s.GetProductsByZipAndServiceID(TextBox1.Text, int.Parse(DropDownList1.Text));
            //o = TextBox1.Text;
            //p = DropDownList1.Text;
            Response.Redirect("displayproductchange.aspx?v1=" + TextBox1.Text + "&v2=" + DropDownList1.Text);
           

        }
    }
}