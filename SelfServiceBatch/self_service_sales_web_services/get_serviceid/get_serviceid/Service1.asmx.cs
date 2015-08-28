using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;

namespace get_serviceid
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
         [WebMethod]
    
              
        public string product_service(string customer_id)
        {
            string service_id = null; ;
            OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;Data Source=192.168.0.121/orcl;Persist Security Info=True;User ID=hr;Password=hr;");
          //  var con = new SqlConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger;");
            cn.Open();
            var cmd = new OleDbCommand("select service_id from customer_services where customer_id='"+customer_id+"'",cn);
             OleDbDataReader R=cmd.ExecuteReader();
             if (R.Read())
                 return R[0].ToString();
             else
                 return "0";
        }
    }
}