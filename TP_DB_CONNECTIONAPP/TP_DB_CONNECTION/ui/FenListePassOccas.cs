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

namespace TP_DB_CONNECTION.ui
{
    public partial class FenListePassOccas : Form
    {
        public FenListePassOccas()
        {
            InitializeComponent();
        }
        private DataTable table = new DataTable();

        private void btn_retourAnalyse_Click(object sender, EventArgs e)
        {
            this.Visible = false;            
        }

        private void btn_affOccPass_Click(object sender, EventArgs e)
        {
            DaoPassager daoPassager = new DaoPassager();
            try
            {
                daoPassager.GetConnection();
                table =  daoPassager.affOccPass();
                dgv_occPass.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                daoPassager.EndConnection();
            }
        }

        private void cmb_statut_SelectedIndexChanged(object sender, EventArgs e)
        {
            DaoPassager statut = new DaoPassager();
            try
            {
                statut.GetConnection();
                //string v_statut = cmb_statut.Text.ToString();
                

                // Utilisez le code passager pour récupérer les informations nécessaires dans la table Passager
                string q = "SELECT statut FROM PASSAGER WHERE statut = occasionnel";
                MySqlCommand cmd = new MySqlCommand(q, statut.Conn);
                //cmd.Parameters.AddWithValue("@statut", v_statut);
                //MySqlDataReader rdr = cmd.ExecuteReader();

               /* if (rdr.Read())
                {
                    txt_codePassager.Text = rdr["codePassager"].ToString();
                }
                else
                {
                    txt_codePassager.Clear(); // Effacez le champ si aucun code n'est trouvé
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               statut.EndConnection();
            }

        }

        private void txt_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "nom LIKE '%" + txt_search_occas.Text + "%'";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
