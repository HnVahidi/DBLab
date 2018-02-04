using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLabrator.DA
{
    class OrderDA
    {
        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static string connetionString = "Server=DESKTOP-M50H7JK\\MSSQLSERVER01;" +
                "Trusted_Connection=yes;" +
                "database=Raspberry;";
        internal static DataTable Search(string text)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderT WHERE OrderT#=" + text, cnn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM OrderT", cnn);
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

        internal static bool Delete(string text)
        {
            bool flag = true;
            SqlConnection cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM OrderT WHERE OrderT#=" + text, cnn);
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
        internal static bool Insert(DO.Order ord)
        {
            bool flag = true;
            string sqlcmd = "INSERT INTO OrderT (OrderT#,invoice#,DateRaised,DatePaid,PaymentMethod#,ShipmentMethod#)" +
                " VALUES (" + ord.id + "," + ord.invoice + "," + "'" + ord.dateRaised + "'" + "," + "'" + ord.datePaid + "'," +
                ord.paymentMethodId + "," + ord.shipmentMethodeId + ")";

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
        internal static bool Update(DO.Order ord)
        {
            bool flag = true;
            string sqlcmd = "UPDATE OrderT SET invoice#=" + ord.invoice + ",DateRaised='" + ord.dateRaised
                + "',DatePaid='" + ord.datePaid + "',PaymentMethod#=" + ord.paymentMethodId + ",ShipmentMethod#=" + ord.shipmentMethodeId +
                " where OrderT#=" + ord.id;
                

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
