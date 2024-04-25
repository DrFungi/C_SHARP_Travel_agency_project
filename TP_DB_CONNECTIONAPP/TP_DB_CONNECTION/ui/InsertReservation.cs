using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TP_DB_CONNECTION.dao;
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION.ui
{
    public partial class InsertReservation : Form
    {
        public InsertReservation()
        {
            InitializeComponent();
        }

        DaoPassager Dao = new DaoPassager();


        public void cmbPassager()
        {
            MessageBox.Show("Test de la connexion ");
            try
            {
                DaoReservation res = new DaoReservation();
                res.GetConnection();
                
                MessageBox.Show("Connexion ok ");

                string select = "select * from passager";
                MySqlCommand cmd = new MySqlCommand(select,Conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                int rowCount = 0; // Compteur de lignes pour le débogage

                while (rdr.Read())
                {
                    // Ajoutez le nom du passager dans le ComboBox

                    cmb_passager.Items.Add(rdr.GetString("codePassager"));
                    rowCount++;
                }

                // Configurez le ValueMember et le DisplayMember
                /* cmb_passager.DisplayMember = "nom";
                 cmb_passager.ValueMember = "codePassager";*/

                MessageBox.Show("Nombre de lignes récupérées : " + rowCount);
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
        private void InsertReservation_Load(object sender, EventArgs e)
        {
            cmbPassager();

        }


        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void btn_inserer_Click(object sender, EventArgs e)
        {
            DaoReservation reservation = new DaoReservation();
            try
            {
                string v_codePassager = txt_codePassager.Text;
                string v_statut_res = cmb_statut_res.Text;
                string v_date_res = txt_date_res.Text;
                Reservation res = new Reservation(v_codePassager, v_statut_res, v_date_res);
                reservation.GetConnection();
                reservation.AddReservation(res);
                MessageBox.Show("Insertion reussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reservation.EndConnection();
            }
            txt_date_res.Clear();
            txt_codePassager.Clear();
            cmb_statut_res.SelectedIndex = -1;

        }
      


        private void cmb_passager_SelectedIndexChanged(object sender, EventArgs e)
        {

        //    try
        //    {
        //        Dao.GetConnection();

        //        // Récupérez le nom du passager sélectionné
        //        string selectedNom = cmb_passager.SelectedItem.ToString();

        //        // Utilisez un paramètre dans la requête SQL pour éviter les problèmes liés à l'encapsulation de chaînes de caractères
        //        string q = "SELECT codePassager FROM PASSAGER WHERE nom = @nom";
        //        MySqlCommand cmd = new MySqlCommand(q, Dao.conn);
        //        cmd.Parameters.AddWithValue("@nom", selectedNom);

        //        // Exécutez la requête SQL et lisez le résultat
        //        MySqlDataReader rdr = cmd.ExecuteReader();

        //        if (rdr.Read())
        //        {
        //            // Récupérez le code passager correspondant
        //            txt_codePassager.Text = rdr["codePassager"].ToString();
        //        }
        //        else
        //        {
        //            // Effacez le champ si aucun code n'est trouvé
        //            txt_codePassager.Clear();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        Dao.EndConnection();
        //    }
        }



    }
}
