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
    public class Salesman_DA
    {
        SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString);

        public int InsertSalesman(Salesman_BO sm)
        {
            try
            {
                string query = $"insert into salesman (salesman_id, name, city, commission) values ({sm.SalesmanId},'{sm.SalesmanName}','{sm.City}',{sm.Commission})";

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
