using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION
{
    internal class DaoPassager
    {
        private string cs = "server=localhost;userid=root;database=gestionreservation;port=3306";

        public MySqlConnection Conn { get; set; }

        public DaoPassager()
        {
            Conn = new MySqlConnection(cs);
        }
        internal void GetConnection()
        {
            Conn.Open();
        }
        internal void EndConnection()
        {
            Conn.Close();
        }

        internal int AddPassager(Passager passager)
        {
            string execute = "INSERT INTO passager (nom, prenom, adresse, telephone, ville, pays, statut)" +
                " VALUES (@v_nom,@v_prenom,@v_adresse,@v_telephone,@v_ville,@v_pays,@v_statut)";

            MySqlParameter p1 = new MySqlParameter();
            p1.ParameterName = "@v_nom";
            p1.Value = passager.Nom;

            MySqlParameter p2 = new MySqlParameter();
            p2.ParameterName = "@v_prenom";
            p2.Value = passager.Prenom;

            MySqlParameter p3 = new MySqlParameter();
            p3.ParameterName = "@v_adresse";
            p3.Value = passager.Adresse;

            MySqlParameter p4 = new MySqlParameter();
            p4.ParameterName = "@v_telephone";
            p4.Value = passager.Telephone;

            MySqlParameter p5 = new MySqlParameter();
            p5.ParameterName = "@v_ville";
            p5.Value = passager.Ville;

            MySqlParameter p6 = new MySqlParameter();
            p6.ParameterName = "@v_pays";
            p6.Value = passager.Pays;

            MySqlParameter p7 = new MySqlParameter();
            p7.ParameterName = "@v_statut";
            p7.Value = passager.Statut;

            MySqlCommand cmd = new MySqlCommand(execute, Conn);

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
                return insertedrows;
            }
            else
            {
                MessageBox.Show("Insertion echouee");
                return insertedrows;
            }
        }

        internal DataTable affOccPass()
        {
            DataTable table = new DataTable();
            try
            {
                string query = "SELECT `codePassager` , `nom` , `prenom` , `adresse` FROM passager WHERE `statut` = 'occasionnel'";
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                table.Load(rdr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}