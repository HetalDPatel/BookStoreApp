using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService_Inventory.BusinessObject;

namespace WebService_Inventory.DataAccess
{
    public class Order_DA
    {
        SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString);

        public int InsertOrder(Order_BO order)
        {
            try
            {
                string query = $"insert into orders (order_no,purch_amt,ord_date,customer_id,salesman__id) values ('{order.OrderNo}','{order.POAmount}','{order.OrderDate}','{order.CustId}','{order.SaleId}')";

                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();

                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {

            }
            finally
            {
                _connection.Close();
            }
            return 0;
        }
    }
}
