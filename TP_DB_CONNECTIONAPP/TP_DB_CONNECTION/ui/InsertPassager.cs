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
            txt_nom.Select();

        }
        DaoPassager Dao = new DaoPassager("server=localhost;userid=root;database=gestionreservation;port=3306");

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_inserer_Click(object sender, EventArgs e)
        {
            try
            {
                Dao.GetConnection();
                string v_nom = txt_nom.Text;
                string v_prenom = txt_prenom.Text;
                string v_adresse = txt_adresse.Text;
                string v_telephone = txt_telephone.Text;
                string v_ville = txt_ville.Text;
                string v_pays = txt_pays.Text;
                string v_statut = cmb_statut.Text;

                Dao.InsertPassager(v_nom, v_prenom, v_adresse, v_telephone, v_ville, v_pays, v_statut);

                txt_nom.Clear();
                txt_prenom.Clear();
                txt_adresse.Clear();
                txt_telephone.Clear();
                txt_ville.Clear();
                txt_pays.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Dao.EndConnection();
            }
        }
    }
}
