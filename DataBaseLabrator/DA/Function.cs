using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLabrator.DA
{
     public class Function
    {
        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static string connetionString = "Server=DESKTOP-M50H7JK\\MSSQLSERVER01;" +
                "Trusted_Connection=yes;" +
                "database=Raspberry;";
        internal static DataTable customreProdList(string prodId)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM customerProdList("+prodId+")", cnn);
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




        internal static string dateDifference(string orderId)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dateDifference(" + orderId + ")", cnn);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.SelectCommand.Connection = cnn;
            try
            {
                dataAdapter.Fill(dt);
                
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return dt.Rows[0].Field<int>(0).ToString();
        }
    }
}
