using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TP_DB_CONNECTION.dao;
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION.ui
{
    // This class handles the operations related to inserting a new reservation.
    public partial class InsertReservation : Form
    {

        public InsertReservation()
        {
            InitializeComponent();
            Display_Passager();
        }
        void Display_Passager()
        // This method fetches and displays all passengers from the database.
        {
            DaoReservation res = new DaoReservation();
            try
            {
                res.GetConnection();
                string Select = "SELECT * FROM passager";

                MySqlCommand cmd = new MySqlCommand(Select, res.Conn);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string codePassager = read.GetString("nom");
                    cmb_passager.Items.Add(codePassager);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                res.EndConnection();
            }
        }


        // This method handles the event when the 'Return' button is clicked.
        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        // This method handles the event when a different passenger is selected from the dropdown.
        // It fetches and displays the corresponding passenger code.
        private void cmb_passager_SelectedIndexChanged(object sender, EventArgs e)
        {

            DaoReservation reservation = new DaoReservation();
            try
            {
                reservation.GetConnection();
                // Récupérez le code passager correspondant à la sélection dans le ComboBox
                string selectedCodePassager = cmb_passager.Text.ToString();
                

                // Utilisez le code passager pour récupérer les informations nécessaires dans la table Passager
                string q = "SELECT codePassager FROM PASSAGER WHERE nom = @nom";
                MySqlCommand cmd = new MySqlCommand(q, reservation.Conn);
                cmd.Parameters.AddWithValue("@nom", selectedCodePassager);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lbl_codePass.Text = rdr["codePassager"].ToString();
                }
                else
                {
                    lbl_codePass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reservation.EndConnection();
            }
        }
        
        //method handles the event when the 'Insert' button is clicked.
        // It creates a new reservation and adds it to the database.
        private void btn_inserer_Click(object sender, EventArgs e)
        {
            DaoReservation reservation = new DaoReservation();
            try
            {
                string v_codePassager = lbl_codePass.Text;
                string v_statut_res = cmb_statut_res.Text;
                string v_date_res = date_time_pecker.Text;
                Reservation res = new Reservation(v_codePassager, v_statut_res, v_date_res);
                reservation.GetConnection();
                reservation.AddReservation(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reservation.EndConnection();
            }
            cmb_passager.SelectedIndex = -1;
            lbl_codePass.Text="";
            cmb_statut_res.SelectedIndex = -1;
        }

        private void InsertReservation_Load_1(object sender, EventArgs e)
        {

        }
    }
}

