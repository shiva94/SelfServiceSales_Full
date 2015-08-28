using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace websitefinal
{
    public partial class changeservicefinal : System.Web.UI.Page
    {
        string l = "0";

        protected void Page_Load(object sender, EventArgs e)
        {
           Session["User"] = Session["Name"].ToString();

            if (!IsPostBack)
            {
                List<prod> L = new List<prod>();
                prod p = new prod();
                p.Product_Id = "1";
                p.Product_name = "Wireline Fios tv Services";
                L.Add(p);
                p = new prod();
                p.Product_Id = "2";
                p.Product_name = "Wireline Fios Data Services";
                L.Add(p);

                p = new prod();
                p.Product_Id = "3";
                p.Product_name = "Wireline Fios Voice Services";
                L.Add(p);

                p = new prod();
                p.Product_Id = "4";
                p.Product_name = "Wireless Service";
                L.Add(p);
                Session["User"] = Session["Name"].ToString();
                getservice.Service1SoapClient f = new getservice.Service1SoapClient();
                getservice.Class2[] mn = f.getservice((Convert.ToInt32(Session["Name"])));

                gvdata.DataSource =  L;
                gvdata.DataBind();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            getservice.Service1SoapClient f = new getservice.Service1SoapClient();
            getservice.Class2[] mn = f.getservice(Convert.ToInt32(Session["Name"]));
            int i = mn.Count();
            string m = "0";
            for (int k = 0; k < gvdata.Rows.Count; k++)
            {
                RadioButton rb = (gvdata.Rows[k].FindControl("rdbUser")) as RadioButton;
                if (rb.Checked == true)
                {
                    m = gvdata.Rows[k].Cells[1].Text;
                }



               
            }
            Response.Redirect("displayproductmore.aspx?v1=" + m);
        }
    }
}
    
