using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MultiFormApps
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Data Source=SHAWON;Initial Catalog=shopbd;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString); //retrun database connection string
            return conn;
        }
    }
}
