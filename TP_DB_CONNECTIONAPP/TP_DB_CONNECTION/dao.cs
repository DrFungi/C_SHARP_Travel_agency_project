using MySql.Data.MySqlClient;
using System;

namespace TP_DB_CONNECTION
{
    internal class Dao
    {
        public MySqlConnection conn { get; set; }

        public Dao(string cs)
        {
            conn = new MySqlConnection(cs);
        }

        internal void GetConnection()
        {
            string cs = "server=localhost;userid=root;database=gestionreservation;port=3306";
            conn.Open();
        }
        internal void EndConnection()
        {
            conn.Close();
        }
    }
}