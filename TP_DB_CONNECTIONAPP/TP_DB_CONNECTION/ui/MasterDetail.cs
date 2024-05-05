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
            try
            {
                DaoReservation daoRes = new DaoReservation();
                daoRes.GetConnection();
                // Récupérez le code passager correspondant à la sélection dans le ComboBox
                string selectedFrequentPassager = cmb_freq_fly.Text.ToString();
                List<Reservation> reservationList = daoRes.SelectionnerData(selectedFrequentPassager);
                lsb_freq.Items.Add("Code Passager - Statut Reservation - Date Reservation");
                foreach (Reservation reservation in reservationList)
                {
                    lsb_freq.Items.Add(reservation);
                }
                

                /* Utilisez le code passager pour récupérer les informations nécessaires dans la table Passager
                string q = "SELECT codeReservation, statutReservation, dateReservation FROM RESERVATION WHERE codePassager = @codePassager";
                MySqlCommand cmd = new MySqlCommand(q, passager.Conn);
                cmd.Parameters.AddWithValue("@codePassager", selectedFrequentPassager);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lsb_freq.Text = rdr["codePassager"].ToString();
                }
                else
                {
                  //  lsb_freq.Clear(); // Effacez le champ si aucun code n'est trouvé
                }*/
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
    }
}
