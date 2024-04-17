using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TP_DB_CONNECTION
{
    internal class DaoPassager
    {
        public MySqlConnection conn { get; set; }

        public DaoPassager(string cs)
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

        internal void InsertPassager(string v_nom, string v_prenom, string v_adresse, string v_telephone, string v_ville, string v_pays, string v_statut)
        {
            string execute = "INSERT INTO passager (nom, prenom, adresse, telephone, ville, pays, statut)" +
                " VALUES (@v_nom,@v_prenom,@v_adresse,@v_telephone,@v_ville,@v_pays,@v_statut)";

            MySqlParameter p1 = new MySqlParameter();
            p1.ParameterName = "@v_nom";
            p1.Value = v_nom;

            MySqlParameter p2 = new MySqlParameter();
            p2.ParameterName = "@v_prenom";
            p2.Value = v_prenom;

            MySqlParameter p3 = new MySqlParameter();
            p3.ParameterName = "@v_adresse";
            p3.Value = v_adresse;

            MySqlParameter p4 = new MySqlParameter();
            p4.ParameterName = "@v_telephone";
            p4.Value = v_telephone;

            MySqlParameter p5 = new MySqlParameter();
            p5.ParameterName = "@v_ville";
            p5.Value = v_ville;

            MySqlParameter p6 = new MySqlParameter();
            p6.ParameterName = "@v_pays";
            p6.Value = v_pays;

            MySqlParameter p7 = new MySqlParameter();
            p7.ParameterName = "@v_statut";
            p7.Value = v_statut;

            MySqlCommand cmd = new MySqlCommand(execute, conn);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);

            int insertedrows = cmd.ExecuteNonQuery();


            if (insertedrows > 0)
            {
                MessageBox.Show("Insertion reussie");
            }
            else
            {
                MessageBox.Show("Insertion echouee");
            }

        }
    }
}