using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_Inventory.BusinessObject;
using WebService_Inventory.DataAccess;

namespace WebService_Inventory
{
    /// <summary>
    /// Summary description for Customer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Customer : System.Web.Services.WebService
    {

        [WebMethod]
        public int InserNewCustomer(Customer_BO newCust)
        {
            try
            {
                Customer_DA dataAccess = new Customer_DA();
                return dataAccess.InsertCustomer(newCust);
            }
            catch
            {

            }
            return 0;
        }
    }
}
