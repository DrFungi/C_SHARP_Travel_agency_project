using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DB_CONNECTION
{
    public partial class InsertPassager : Form
    {

        public InsertPassager()
        {
            InitializeComponent();

        }
        Dao Dao = new Dao("server=localhost;userid=root;database=gestionreservation;port=3306");

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_inserer_Click(object sender, EventArgs e)
        {
            try
            {
                Dao.GetConnection();

                string execute = "INSERT INTO passager (nom, prenom, adresse, ville, pays, statut)" +
                    " VALUES (@v_nom,@v_prenom,@v_adresse,@v_ville,@v_pays,@v_statut)";
                string v_nom = txt_nom.Text;
                string v_prenom = txt_prenom.Text;
                string v_adresse = txt_adresse.Text;
                string v_ville = txt_ville.Text;
                string v_pays = txt_pays.Text;
                string v_statut = cmb_statut.Text;

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
                p4.ParameterName = "@v_ville";
                p4.Value = v_ville;

                MySqlParameter p5 = new MySqlParameter();
                p5.ParameterName = "@v_pays";
                p5.Value = v_pays;

                MySqlParameter p6 = new MySqlParameter();
                p6.ParameterName = "@v_statut";
                p6.Value = v_statut;

                MySqlCommand cmd = new MySqlCommand(execute, Dao.conn);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                int insertedrows = cmd.ExecuteNonQuery();
                Console.WriteLine("{0} ligne ajoutée", insertedrows);

                if (insertedrows > 0)
                {
                    MessageBox.Show("Insertion reussie");
                }
                else
                {
                    MessageBox.Show("Insertion echouee");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Dao.EndConnection();
            }
            //message for Hajar



        }

        private void cmb_statut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
