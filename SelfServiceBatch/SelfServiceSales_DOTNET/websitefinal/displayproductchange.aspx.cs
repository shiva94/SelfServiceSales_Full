using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class displayproductchange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["v1"].ToString();
            string b = Request.QueryString["v2"].ToString();
            productlist.GetAllProductsSoapClient s = new productlist.GetAllProductsSoapClient();
            productlist.ProductClass[] pc = s.GetProductsByZipAndServiceID(a, int.Parse(b));
            int i = pc.Count();

            if (i == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert(' Sorry This service is not available at your place.Please try another.Thank You ')", true);

            }
            else
            {
                GridView1.DataSource = pc;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string a = Request.QueryString["v1"].ToString();
            string b = Request.QueryString["v2"].ToString();
            productlist.GetAllProductsSoapClient s = new productlist.GetAllProductsSoapClient();
            productlist.ProductClass[] pc = s.GetProductsByZipAndServiceID(a, int.Parse(b));
            updateproduct.Service1SoapClient x = new updateproduct.Service1SoapClient();
            string k = pc[0].Product_ID;
            int i = x.product_service(a, product_id.Text, 22);
            if (product_id.Text == k)
            {
                if (i == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert(' Your Service is updated.Have a nice day')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert('Sorry Server is down.Will try to reach you')", true);
                }
            }


            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert(' You Entered incorrect product Id,Please Check ')", true);
                }

            }


        }
    }
