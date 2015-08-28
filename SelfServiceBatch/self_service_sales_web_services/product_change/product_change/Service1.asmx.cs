using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;

namespace product_change
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
        OleDbCommand Com = null;
        OleDbTransaction Trans = null;
        OleDbCommand cmd = null;
        OleDbConnection cn = null;
        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        [WebMethod]
        public int product_service(string service_id, string product_id, int customer_id)
        {
            int row=0;
           
           cn = new OleDbConnection("Provider=MSDAORA;Data Source=192.168.0.217/orcl;Persist Security Info=True;User ID=hr;Password=hr;");
          
            cmd = cn.CreateCommand();
            try
            {
                cn.Open();
             
                string s = "update product_services set product_id='" + product_id + "' where service_id=(select service_id from customer_services where customer_id=" + customer_id + " and service_id='" + service_id + "')";
                Trans = cn.BeginTransaction();
                cmd = new OleDbCommand(s, cn,Trans);
                cmd.Transaction = Trans;
                row= cmd.ExecuteNonQuery();
                Trans.Commit();

            }
            catch (Exception e)
            {
                string s = e.Message;
                Trans.Rollback();
            }
            finally
            {
                cn.Close();
            }
            return row;
            
        }

        }
    }
