using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Project
{
    class Database
    {

        // CONFIGURE SERVER
        private static string serverConfiguration = @"server=localhost;userid=root;password=;database=minecount";
        public static string GetVersion()
        {
            // OPEN CONNECTION AND READ VERSION INFORMATION
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            return con.ServerVersion;
        }
    }

}