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
using TP_DB_CONNECTION.dao;
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION.ui
{
    public partial class MasterDetail : Form
    {
        public MasterDetail()
        {
            InitializeComponent();
            Display_Passager();
        }
            DaoPassager passager = new DaoPassager();
        void Display_Passager()
        {
            try
            {
                passager.GetConnection();
                string Select = "SELECT * FROM PASSAGER WHERE statut like 'Frequent Flyer'";

                MySqlCommand cmd = new MySqlCommand(Select, passager.Conn);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int codePassager = read.GetInt32(0); //this will look for the value of the first column of the table passager
                    cmb_freq_fly.Items.Add(codePassager);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                passager.EndConnection();
            }
        }

        private void cmb_freq_fly_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsb_freq.Items.Clear();
            DaoPassager daoPassager = new DaoPassager();
            daoPassager.GetConnection();
            DaoReservation daoRes = new DaoReservation();
            daoRes.GetConnection();

            try
            {
                
                
                // Récupérez le code passager correspondant à la sélection dans le ComboBox
                string selectedFrequentPassager = cmb_freq_fly.Text.ToString();
                ListeReservation listing = new ListeReservation();
                listing = daoRes.SelectionnerData(selectedFrequentPassager);
                Passager passager = new Passager();
                passager = daoPassager.SelectionnerPassager(selectedFrequentPassager);
                lsb_freq.Items.Add(passager);
                lsb_freq.Items.Add(" ");
                lsb_freq.Items.Add("Code Reservation - Statut Reservation - Date Reservation");
                lsb_freq.Items.Add(" ");
                foreach (Reservation reservation in listing.Listing)
                {
                    lsb_freq.Items.Add(reservation);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                daoPassager.EndConnection();
                daoRes.EndConnection();
            }

        }

        private void btn_go_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
