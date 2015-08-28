using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;

namespace get_servicename
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
    
              
        public string service_description(string service_id)
        {

         
            OleDbConnection cn = new OleDbConnection("Provider=MSDAORA;Data Source=192.168.0.121/orcl;Persist Security Info=True;User ID=hr;Password=hr;");
            //  var con = new SqlConnection("Provider=OraOLEDB.Oracle;User Id=scott;Password=tiger;");
            cn.Open();
            var cmd = new OleDbCommand("select service_name from service_description where service_id='" + service_id + "'", cn);
            OleDbDataReader R = cmd.ExecuteReader();
            if (R.Read())
                return R[0].ToString();
            else
                return "0";

            cn.Close();
        }
    }
}