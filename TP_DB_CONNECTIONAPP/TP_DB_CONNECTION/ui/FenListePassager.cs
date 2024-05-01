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
using TP_DB_CONNECTION.modele;

namespace TP_DB_CONNECTION.ui
{
    public partial class FenListePassager : Form
    {
        public FenListePassager()
        {
            InitializeComponent();

        }
        private DataTable table = new DataTable();
        private void lbx_passager_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_lpg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_aff_passagers_Click(object sender, EventArgs e)
        {
            DaoPassager daoPassager = new DaoPassager();
            try
            {
                daoPassager.GetConnection();
                string query = "SELECT * FROM passager";
                MySqlCommand cmd = new MySqlCommand(query, daoPassager.Conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                table.Load(rdr);
                dgv_lpg.DataSource = table;
                daoPassager.EndConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Liste des passagers affichée");
                daoPassager.EndConnection();
            }
        }

        private void txt_search_passager_TextChanged(object sender, EventArgs e)
        {
            //DaoPassager daoPassager = new DaoPassager();
            try
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "nom LIKE '%"+txt_search_passager.Text+"%'";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }      
            
        }
    }
}
