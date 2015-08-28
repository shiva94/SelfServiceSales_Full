using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;
using System.Data;

namespace get_servicenamestatus
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        OleDbCommand Com = null;
        OleDbCommand cmd;
        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        [WebMethod]
        public List<Class2> getservice(int cid)
        {
            OleDbConnection con = new OleDbConnection("Provider=OraOLEDB.Oracle;data source=192.168.0.217/orcl;User Id=hr;Password=hr;");
            //OleDbConnection con = new OleDbConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=user34;Data Source=.");
            OleDbDataAdapter adp = new OleDbDataAdapter("select s.service_id,sd.service_name,s.service_current_status from customer_services s,service_description sd where s.customer_id=? and s.service_id=sd.service_id ", con);
            // adp.SelectCommand.Parameters.AddWithValue("@e", customer_id);
            adp.SelectCommand.Parameters.AddWithValue("?", cid);

            DataSet ds = new DataSet();
            adp.Fill(ds, "Prod");

            List<Class2> P = new List<Class2>();
            foreach (DataRow dr in ds.Tables["Prod"].Rows)
            {
                P.Add(new Class2 { sid = Convert.ToString(dr["service_id"]), service_name = Convert.ToString(dr["service_name"]), service_current_status = Convert.ToString(dr["service_current_status"]) });
               
            }
            return P;
        }
    }
}