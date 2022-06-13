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
    public class Customer_DA
    {
        SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString);

        public int InsertCustomer(Customer_BO cust)
        {
            try
            {
                string query = $"insert into customer (customer_id,cust_name,city,grade,salesman__id) values ({cust.custId},'{cust.custName}','{cust.city}',{cust.grade},{cust.SalesId})";

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
