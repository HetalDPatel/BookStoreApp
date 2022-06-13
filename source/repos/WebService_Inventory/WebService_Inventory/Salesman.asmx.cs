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
    /// Summary description for Salesman
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Salesman : System.Web.Services.WebService
    {

        [WebMethod]
        public int InserNewSalesman(Salesman_BO newSalesman)
        {
            try
            {
                Salesman_DA dataAccess = new Salesman_DA();
                return dataAccess.InsertSalesman(newSalesman);
            }
            catch
            {

            }
            return 0;
        }
    }
}
