using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DICTIONARY
{
    internal class DB
    {

        static string connectionString = "Data Source=DSTPL15090B685\\SQLEXPRESS;Initial Catalog = Dictionary; Integrated Security = True";

        SqlConnection connection = new SqlConnection(connectionString);
        //SqlConnection connection = new SqlConnection(@"Data Source=DSTPL15090B685\SQLEXPRESS;Initial Catalog = Dictionary; Integrated Security = True");


        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close(); 
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }



    }
}
