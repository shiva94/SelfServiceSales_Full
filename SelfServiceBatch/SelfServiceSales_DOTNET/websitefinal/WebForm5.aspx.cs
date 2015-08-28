using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;

namespace websitefinal
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        int cnt = 0;
        DataSet dsDummy = null; //dummy dataset use for repeater
        DataTable tbDummy = null; //dummy table for dataset
        protected void Page_Load(object sender, EventArgs e)
        {


            productlist.GetAllProductsSoapClient s = new productlist.GetAllProductsSoapClient();
            productlist.ProductClass[] pc = s.GetProductsByZipAndServiceID("2",10003);
            GridView1.DataSource = pc;
            GridView1.DataBind();
        }



        private int GetSelectedRecord(out int r)
        {
            r = -1;
        string R;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                RadioButton rb = (RadioButton)GridView1.Rows[i].Cells[0].FindControl("RadioButton1");
                R = GridView1.Rows[i].Cells[1].ToString();
                if (rb != null)
                {

                    if (rb.Checked)
                    {

                        HiddenField hf = (HiddenField)GridView1.Rows[i]

                                        .Cells[0].FindControl("HiddenField1");

                        if (hf != null)
                        {

                            ViewState["SelectedContact"] = hf.Value;
                            cnt = 1;
                            r = i;
                        }



                        break;

                    }

                }

            }
            return cnt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
    int Id = 0;
    foreach (GridViewRow row in GridView1.Rows)
    {
        RadioButton rb = (RadioButton)row.FindControl("RadioButton1");
        if (rb.Checked)
        {
            Id =Convert.ToInt32(GridView1.Rows[row.RowIndex].Cells[1].Text);
            //Add your code
        }
  
}
        }
    }
}