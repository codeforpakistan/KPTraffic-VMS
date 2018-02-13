using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BusinessLayer
{
   public class DatabaseConnections
    {
      //public string cs = "data source=SOHAILKHAN\\SOHAILSQL08; database=dbPayrollSystem; integrated security=true";
        public static SqlConnection conn;
        public static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public static SqlConnection OpenConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    return conn;
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        return conn;
                    }
                    else
                        return conn;
                }
            }
            catch (Exception)
            {
                return conn = null;
            }
        }

        public static void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
       

    }
}
