using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLabrator.DO;
using System.Data.SqlClient;
using System.Data;

namespace DataBaseLabrator.DA
{
    class CustomerDA
    {
        private static SqlDataAdapter dataAdapter=new SqlDataAdapter();

        static string connetionString = "Server=DESKTOP-M50H7JK\\MSSQLSERVER01;" +
                "Trusted_Connection=yes;" +
                "database=Raspberry;";
        internal static bool InsertCustomer(Customer cust)
        {
            bool flag = true;
            string sqlcmd = "INSERT INTO Customer (city,country,CreditRating,FaxNo,FirstName,LastName,sex,Street,zipcode,Customer#,TelNo)" + "VALUES("+"'"+cust.city + "'" + ","+"'"+ cust.country + "'" + "," + cust.creditRating + "," +
                cust.faxNo + "," + "'"+ cust.firstName + "'" + "," + "'" +cust.lastName + "'" + "," + "'" +cust.sex + "'" + "," +"'"+cust.street + "'" + "," +
                "'" + cust.zipCode + "'" + "," + cust.id + "," + cust.telNo + ")";
            
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, cnn);
                cmd.ExecuteNonQuery();
            }
            catch
            {flag = false;}
            finally
            {cnn.Close();}
            return flag;
        }

        internal static DataTable Search(string text)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd =new SqlCommand("SELECT * FROM Customer WHERE customer#="+text, cnn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer ", cnn);
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
            SqlConnection cnn= new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE Customer#=" + text, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch { return false; }
            finally
            {
                cnn.Close();
            }
            return true;
        }


        internal static bool Update(Customer cu)
        {
            bool flag = true;
            string sqlcmd = string.Format("UPDATE Customer SET FirstName='{1}',LastName='{2}',Sex='{3}',Street='{4}',City='{5}'," +
                "Country='{6}',ZipCode={7},TelNo={8},FaxNo={9},CreditRating={10} WHERE Customer#={0}", cu.id,
                cu.firstName, cu.lastName, cu.sex, cu.street, cu.city, cu.country, cu.zipCode, cu.telNo, cu.faxNo, cu.creditRating);

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
