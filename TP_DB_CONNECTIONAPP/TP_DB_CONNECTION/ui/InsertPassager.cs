using System;
using System.Windows.Forms;
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION
{
    public partial class InsertPassager : Form
    {
        public InsertPassager()
        {
            InitializeComponent();
            

        }
        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_inserer_Click(object sender, EventArgs e)
        {
            DaoPassager daoPassager = new DaoPassager();
            try
            {
                string v_nom = txt_nom.Text;
                string v_prenom = txt_prenom.Text;
                string v_adresse = txt_adresse.Text;
                string v_telephone = txt_telephone.Text;
                string v_ville = txt_ville.Text;
                string v_pays = txt_pays.Text;
                string v_statut = cmb_statut.Text;
                Passager passager = new Passager(v_nom, v_prenom, v_adresse, v_telephone, v_ville, v_pays, v_statut);
                daoPassager.GetConnection();
                int result = daoPassager.AddPassager(passager);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                daoPassager.EndConnection();
            }

            txt_nom.Clear();
            txt_prenom.Clear();
            txt_adresse.Clear();
            txt_telephone.Clear();
            txt_ville.Clear();
            txt_pays.Clear();
            cmb_statut.SelectedIndex = -1;
        }
 
    }
}
