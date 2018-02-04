using DataBaseLabrator.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataBaseLabrator.DA
{

    class EmployeeDA
    {

        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static string connetionString = "Server=DESKTOP-M50H7JK\\MSSQLSERVER01;" +
                "Trusted_Connection=yes;" +
                "database=Raspberry;";
        internal static bool InsertEmployee(Employee emp)
        {
            bool flag = true;
            string sqlcmd = "INSERT INTO Employee (Emp#,title,FirstName,LastName,Sex,Street,City,Country,ZipCode,WorkTelNo,FaxNo,MobileNo,Salary,DateStarted)"+
                "VALUES("+ emp.id + "," + "'" + emp.title + "'" + "," + "'" + emp.firstName + "'" + "," + "'" + emp.lastName + "'" + "," +
                "'" + emp.sex + "'" + "," + "'" + emp.street + "'" + "," + "'" + emp.city + "'" + "," + "'" + emp.country + "'" + "," + emp.zipCode + "," +
                emp.workTelNo + "," + emp.faxNo + "," + emp.mobileNo + "," + emp.salary + "," + "'"+emp.dateStarted+"'" +")";
            MessageBox.Show(sqlcmd);
            
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

        internal static DataTable Search(string text)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Emp#=" + text, cnn);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee ", cnn);
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Emp#=" + text, cnn);
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


        internal static bool Update(Employee emp)
        {
            bool flag = true;
            string sqlcmd = string.Format("UPDATE Employee SET Title='{1}',FirstName='{2}',LastName='{3}',Sex='{4}',Street='{5}',City='{6}'," +
                "Country='{7}',ZipCode={8},WorkTelNo={9},FaxNo={10},MobileNo={11},Salary={12},DateStarted='{13}' WHERE Emp#={0}", emp.id,
                emp.title, emp.firstName, emp.lastName, emp.sex, emp.street, emp.city, emp.country, emp.zipCode, emp.workTelNo, emp.faxNo,
                emp.mobileNo, emp.salary, emp.dateStarted);

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
