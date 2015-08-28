using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.OleDb;
using System.Data;

namespace websitefinal
{
    public partial class getOrderStatus : System.Web.UI.Page
    {
        OleDbConnection Con = null;
        OleDbDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.121/orcl;User Id=hr;Password=hr");
            Adp = new OleDbDataAdapter("Select order_id as OrderID,order_negotiation_date as NegotiationDate,order_due_date as DueDate,order_status as OrderStatus,order_completion_date as CompletionDate from customer_orders where customer_Id=?", Con);
            int id =  int.Parse(Request.QueryString["V6"].ToString());
            Adp.SelectCommand.Parameters.AddWithValue("?",id );
            DataSet ds = new DataSet();
            Adp.Fill(ds, "orders");
            if (ds.Tables[0].Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('You have no current orders!');", true);
                Label1.Text = "We see you have no orders. Click on Add Products to order something!";
            }
            else
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}