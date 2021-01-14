using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs3
{
    class DBconnect
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public static string SimpleString { get; set; }
    }
}
