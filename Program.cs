using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformTest.View.system;

namespace WinformTest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string configFile = "./database_connect.txt";

            // Attempt to read the connection information from the file
            string connection = File.Exists(configFile) ? File.ReadAllText(configFile) : null;

            // Try connecting to the database
            if (string.IsNullOrEmpty(connection) || !TestDatabaseConnection(connection))
            {
                // Connection failed or no configuration file found, run the connection form
                Application.Run(new frmKetNoiCSDL());
            }
            else
            {
                // Connection successful, run the login form
                ConnectDB.connection = connection;
                Application.Run(new frmDangNhap());
            }
        }

        // Helper method to test the database connection
        static bool TestDatabaseConnection(string connection)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
