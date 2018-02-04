using DataBaseLabrator.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataBaseLabrator.DA
{
    
    class ProductDA
    {
        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static string connetionString = "Server=DESKTOP-M50H7JK\\MSSQLSERVER01;" +
                "Trusted_Connection=yes;" +
                "database=Raspberry;";
        internal static DataTable Search(string text)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Product#=" + text, cnn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", cnn);
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE Product#=" + text, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch { flag=false; }
            finally
            {
                cnn.Close();
            }
            return flag;
        }
        internal static bool InsertProduct(Product prod)
        {
            bool flag = true;
            string sqlcmd = "INSERT INTO Product (Product#,Unitprice,ProductName,AvailableQuantity)" +
                "VALUES(" + prod.id + "," + prod.price + "," + "'"+ prod.productName +"'"+ "," +
                +prod.availableQuantity+")";

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
        internal static bool Update(Product prod)
        {
            bool flag = true;
            string sqlcmd = "UPDATE Product SET "+
                "Unitprice=" + prod.price +
                ",ProductName=" + "'" + prod.productName +"'"+
                ",AvailableQuantity=" + prod.availableQuantity+
            " WHERE Product#=" + prod.id;

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
