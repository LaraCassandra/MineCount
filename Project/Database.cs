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

                public static ArrayList ReadRecipes()
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            string sql = "SELECT * FROM recipes";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            ArrayList records = new ArrayList();
            while (rdr.Read())
            {
                records.Add(Tuple.Create(rdr.GetString(0), new string[3,3]
                {{rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)},
                {rdr.GetString(4), rdr.GetString(5), rdr.GetString(6)},
                {rdr.GetString(7), rdr.GetString(8), rdr.GetString(9)}}));
            }

            return records;
        }

    }
}