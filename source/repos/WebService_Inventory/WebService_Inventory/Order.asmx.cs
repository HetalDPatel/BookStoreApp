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
    /// Summary description for Order
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Order : System.Web.Services.WebService
    {

        [WebMethod]
        public int InserNewOrder(Order_BO newUser)
        {
            try
            {
                Order_DA dataAccess = new Order_DA();
                return dataAccess.InsertOrder(newUser);
            }
            catch
            {

            }
            return 0;
        }
    }
}
