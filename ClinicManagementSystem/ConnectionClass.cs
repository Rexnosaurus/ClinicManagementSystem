using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogInForm
{
    internal class ConnectionClass
    {
        private MySqlConnection connection;
        private string username;
        private string password;
        private string database;
        private string link;

        public ConnectionClass()
        {
            username = "root";
            password = "rextcm132";
            database = "clinicmanagementsystem";
            link = "localhost";

            string connectionString = $"Server={link};Database={database};User ID={username};Password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
