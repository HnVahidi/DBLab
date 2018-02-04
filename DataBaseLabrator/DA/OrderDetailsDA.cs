using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLabrator.DA
{
    class OrderDetailsDA
    {
        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static string connetionString = "Server=DESKTOP-M50H7JK\\MSSQLSERVER01;" +
                "Trusted_Connection=yes;" +
                "database=Raspberry;";
        internal static DataTable Search(string orderId,string prodId)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetails WHERE OrderT#=" + orderId +" and Product#="+prodId, cnn);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.SelectCommand.Connection = cnn;
            try
            {
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        internal static DataTable SearchAll()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetails", cnn);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.SelectCommand.Connection = cnn;
            try
            {
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        internal static bool Delete(string orderId, string prodId)
        {
            bool flag = true;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM OrderDetails WHERE OrderT#=" + orderId + " and Product#=" + prodId, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch { flag = false; }
            finally
            {
                cnn.Close();
            }
            return flag;
        }
        internal static bool Insert(DO.OrderDetails ord)
        {
            bool flag = true;
            string sqlcmd = string.Format("INSERT INTO OrderDetails (OrderT#,Product#,Customer#,Emp#,OrderDate,PromisedDate,Status#,Quantity,ShipmentDate)" +
                " VALUES ({0},{1},{2},{3},'{4}','{5}',{6},{7},'{8}')",
                ord.orderId, ord.productId, ord.customerId, ord.empId, ord.orderDate, ord.promisedDate, ord.statusId, ord.quantity, ord.shipmentDate);

            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, cnn);
                cmd.ExecuteNonQuery();
            }
            catch
            { flag = false; }
            finally
            { cnn.Close(); }
            return flag;
        }
        internal static bool Update(DO.OrderDetails ord)
        {
            bool flag = true;
            string sqlcmd = string.Format("UPDATE OrderDetails SET " +
                "Customer#={2},Emp#={3},OrderDate='{4}',PromisedDate='{5}',Status#={6},Quantity={7},ShipmentDate='{8}'" +
                " WHERE OrderT#={0} AND Product#={1}",
                ord.orderId, ord.productId, ord.customerId, ord.empId, ord.orderDate, ord.promisedDate, ord.statusId, ord.quantity, ord.shipmentDate);


            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, cnn);
                cmd.ExecuteNonQuery();
            }
            catch
            { flag = false; }
            finally
            { cnn.Close(); }
            return flag;
        }
    }
}
