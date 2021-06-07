using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Project
{
    class Database
    {
        private static string serverConfiguration = @"server=localhost;userid=root;password=;database=minecount";
        public static string GetVersion()
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            return con.ServerVersion;
        }

        public static ArrayList ReadBlocks()
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            string sql = "SELECT * FROM blocks";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            ArrayList records = new ArrayList();
            while (rdr.Read())
            {
                records.Add(Tuple.Create(rdr.GetString(0), rdr.GetInt32(1)));
            }

            con.Close();

            return records;
        }

    }
}