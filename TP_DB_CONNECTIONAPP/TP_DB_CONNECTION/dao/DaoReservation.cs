using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION.dao
{
    internal class DaoReservation
    {
        private string cs = "server=localhost;userid=root;database=gestionreservation;port=3306";
        public MySqlConnection Conn { get; set; }

        public DaoReservation()
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

        internal void AddReservation(Reservation reservation)
        {
            string insert_query = "INSERT INTO RESERVATION (codePassager,statutReservation,dateReservation)" +
                " VALUES (@v_code_passager,@v_statut_res,@v_date_res)";

            MySqlParameter p1 = new MySqlParameter();
            p1.ParameterName = "@v_code_passager";
            p1.Value = reservation.CodePassager;

            MySqlParameter p2 = new MySqlParameter();
            p2.ParameterName = "@v_statut_res";
            p2.Value = reservation.StatutReservation;

            MySqlParameter p3 = new MySqlParameter();
            p3.ParameterName = "@v_date_res";
            p3.Value = reservation.DateReservation;

            MySqlCommand cmd = new MySqlCommand(insert_query, Conn);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

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

        internal ListeReservation SelectionnerData(string selectedFrequentPassager)
        {
            //GetConnection();
            string q = "select codePassager, statutReservation, dateReservation from reservation WHERE CodePassager = @passager";
            MySqlParameter p1 = new MySqlParameter();
            p1.ParameterName = "@passager";
            p1.Value = selectedFrequentPassager;

            MySqlCommand cmd = new MySqlCommand(q, Conn);
            cmd.Parameters.Add(p1);
            MySqlDataReader reader = cmd.ExecuteReader();
            ListeReservation results = new ListeReservation();
            //List<Reservation> results = new List<Reservation>();
            while (reader.Read())
            {
                string codePassager = reader["codePassager"].ToString();
                string statutReservation = (string)reader["statutReservation"];
                string dateReservation = reader.IsDBNull(reader.GetOrdinal("dateReservation"))
                    ? null
                    : reader.GetDateTime(reader.GetOrdinal("dateReservation")).ToString();

                results.AjouterReservation(new Reservation(codePassager, statutReservation, dateReservation));
            }
            //EndConnection();
            return results;
        }




        //internal void SelectPassager(ComboBox cmb_passager)
        //{
        //    string select = "SELECT nom, codePassager FROM PASSAGER";
        //    MySqlCommand cmd = new MySqlCommand(select,Conn);
        //    MySqlDataReader rdr = cmd.ExecuteReader();

        //    while (rdr.Read())
        //    {
        //        // Ajoutez le nom du passager dans le ComboBox
        //        cmb_passager.Items.Add(rdr["nom"].ToString());
        //    }

        //    // Configurez le ValueMember et le DisplayMember
        //    cmb_passager.ValueMember = "codePassager";
        //    cmb_passager.DisplayMember = "nom";

        //    // Gérez l'événement SelectedIndexChanged
        //    cmb_passager.SelectedIndexChanged += cmb_passager_SelectedIndexChanged
        //}

    }
}
