using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace websitefinal
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        OleDbCommand Cmd = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //string a = Request.QueryString["v1"].ToString();
            //Session["User"] = Session["Name"].ToString();
            //int zipcode = 0;

            {
                int zipcode = 0;
                string a = Request.QueryString["v1"].ToString();
                Session["User"] = Session["Name"].ToString();


                //OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;Data Source=192.168.0.217/orcl;Persist Security Info=True;User ID=hr;Password=hr;");
                ////  var con = new SqlConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger;");
                //cn.Open();
                //var cmd = new OleDbCommand("select zipcode from address where address_id=(select billing_address_id from customer where customer_id='" + Session["Name"] + "'", cn);

                //OleDbDataReader R = cmd.ExecuteReader();

                //if (R.Read())
                //    zipcode = Int32.Parse(R[0].ToString());

                productlist.GetAllProductsSoapClient s = new productlist.GetAllProductsSoapClient();
                productlist.ProductClass[] pc = s.GetProductsByZipAndServiceID(a, 10001);
                int g = pc.Count();
                if (g == 1)
                {
                    Response.Redirect("displayproductone.aspx");
                }
                else
                {
                    gvdata.DataSource = pc;
                    gvdata.DataBind();
                }
            }
        }
        //OleDbDataAdapter adp = new OleDbDataAdapter ("select zipcode from address where address_id=(select billing_address_id from customer where customer_id=?", cn);
        //adp.SelectCommand.Parameters.AddWithValue("?", Session["Name"]);






        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            {
                string a = Request.QueryString["v1"].ToString();
                // Session["User"] = Session["Name"].ToString();

                string m = "0";
                for (int i = 0; i < gvdata.Rows.Count; i++)
                {
                    RadioButton rb = (gvdata.Rows[i].FindControl("rdbUser")) as RadioButton;
                    if (rb.Checked == true)
                    {
                        m = gvdata.Rows[i].Cells[1].Text;
                    }
                }
                updateproduct.Service1SoapClient x = new updateproduct.Service1SoapClient();

               // int z = x.product_service(a, m, (Convert.ToInt32(Session["Name"])));
                int z= 0;
                if (z == 1)
                {
                    Response.Redirect("Displayproductupdate.aspx");
                }
                else
                {
                    Response.Redirect("displayproductupdatefail.aspx");
                }
            }
        }
    }
}
