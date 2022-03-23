using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupManager
{
    class Database
    {
        public static string GetConnectionString(string dataSource)
        {
            return "Data Source=" + dataSource + ";Integrated Security=true;";
        }

        public static string GetConnectionString(string dataSource, string userId, string password)
        {
            return "Data Source=" + dataSource + ";User ID=" + userId + ";Password=" + password + ";";
        }

        public static SqlConnection GetConnection(string serverName)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = GetConnectionString(serverName);
            connection.Open();
            return connection;
        }

        public static SqlConnection GetConnection(string serverName, string login, string password)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = GetConnectionString(serverName, login, password);
            connection.Open();
            return connection;
        }
    }
}
