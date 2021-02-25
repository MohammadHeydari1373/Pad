using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Contacts
{
    class Contacts : IContacts
    {

        private string connectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true";

        public bool Insert(string name, string family, string mobile, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string query_insert = "INSERT INTO MyContacts(Name,Family,Mobile,Age,Address) VALUES(@Name,@Family,@Mobile,@Age,@Address);";

            
            SqlCommand comnd = new SqlCommand(query_insert , connection);
            comnd.Parameters.AddWithValue("@Name", name);
            comnd.Parameters.AddWithValue("@Family", family);
            comnd.Parameters.AddWithValue("@Mobile", mobile);
            comnd.Parameters.AddWithValue("@Age", age);
            comnd.Parameters.AddWithValue("@Address", address);
            connection.Open();
            comnd.ExecuteNonQuery();
            

            return true; 
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close(); 
            }
        }

        public bool Update(int contactid, string name, string family, string mobile, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {

                string query = "Update MyContacts Set Name=@Name,Family=@Family,Age=@Age,Mobile=@Mobile,Address=@Address Where ContactId=@ContactId";


                SqlCommand comnd = new SqlCommand(query, connection);
                comnd.Parameters.AddWithValue("@ContactId", contactid);
                comnd.Parameters.AddWithValue("@Name", name);
                comnd.Parameters.AddWithValue("@Family", family);
                comnd.Parameters.AddWithValue("@Mobile", mobile);
                comnd.Parameters.AddWithValue("@Age", age);  
                comnd.Parameters.AddWithValue("@Address", address);
                connection.Open();
                comnd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Delete(int contactid)
        {
            SqlConnection connection = new SqlConnection(connectionString); 
            try
            {
                string query = "Delete From MyContacts Where contactId =@contactId"; 

                SqlCommand comnd = new SqlCommand(query, connection);
                comnd.Parameters.AddWithValue("@contactId", contactid);
                connection.Open();
                comnd.ExecuteNonQuery();
                return true; 
            }
            catch
            {
                return false; 
               
            }
            finally
            {
                connection.Close(); 
            }
        }

        public System.Data.DataTable SelectAll()
        {
            string query_all = "Select * From MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query_all, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public System.Data.DataTable SelectRow(int contactid)
        {

            string query_all = "Select * From MyContacts where contactId=" + contactid;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query_all, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }


        public DataTable Search(string param)
        {
            string query_all = "Select * From MyContacts where Name like @param or Family like @param or  Mobile like @param or Address like @param ";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query_all, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@param", "%"+ param + "%"); 
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
}
