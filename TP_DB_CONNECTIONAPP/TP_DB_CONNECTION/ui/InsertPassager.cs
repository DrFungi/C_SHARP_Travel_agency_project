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
            Dao.GetConnection();
            string v_nom = txt_nom.Text;
            string v_prenom = txt_prenom.Text;
            string v_adresse = txt_adresse.Text;
            string v_ville = txt_ville.Text;
            string v_pays = txt_pays.Text;
            string v_statut = cmb_statut.Text;

            string execute = "INSERT INTO passager (nom, prenom, adresse, ville, pays, statut) VALUES ('" + v_nom + "', '" + v_prenom + "', '" + v_adresse + "', '" + v_ville + "', '" + v_pays + "', '" + v_statut + "')";
            MySqlCommand cmd = new MySqlCommand(execute, Dao.conn);
            int insertedrows = cmd.ExecuteNonQuery();
            if (insertedrows > 0)
            {
                MessageBox.Show("Insertion reussie");
            }
            else
            {
                MessageBox.Show("Insertion echouee");
            }


            Dao.EndConnection();
        }
    }
}
