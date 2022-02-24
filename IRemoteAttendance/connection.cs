using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MySql.Data.MySqlClient;




namespace IRemoteAttendance
{
    public class connection
    {
         MySql.Data.MySqlClient.MySqlConnection conn;
        
        static string host = "localhost";
        static string database = "mini_project";
        static string userDB = "root";
        static string password = "123456789";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;

       
        public string Table = "users"; // initialize db table
        public string ConnectionType = "";

        // Open connection
        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                // code error here
            }
            return false;
        }

        // Close connection
        public void Close()
        {
            
            conn.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                // code error here
            }
            return null;
        }


        // cheak if exist
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                // code error here
            }
            return null;
        }

        
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                // code error here
            }
            return -1;
        }

        // function to execute delete , insert and update
        public void Execute(string Sql_command)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand(Sql_command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // code errur here
            }
            
           
            
        }
    }
}

