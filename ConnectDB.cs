using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformTest
{
    class ConnectDB
    {
        public static string connection { get; set; }

        public static MySqlConnection getConnectionDB()
        {
            MySqlConnection conn = new MySqlConnection(connection);
            return conn;
        }
    }
}
