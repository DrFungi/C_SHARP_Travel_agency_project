using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TP_DB_CONNECTION.ui
{
    public partial class InsertReservation : Form
    {
        public InsertReservation()
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

                
                               
                string insert_query = "INSERT INTO RESERVATION (codePassager,statutReservation,dateReservation)" +
                    " VALUES (@v_code_passager,@v_statut_res,@v_date_res)";

                string v_code_passager = txt_pass.Text;
                string v_statut_res = cmb_statut_res.Text;
                string v_date_res = txt_date_res.Text;

                MySqlParameter p1 = new MySqlParameter();
                p1.ParameterName = "@v_code_passager";
                p1.Value = v_code_passager;

                MySqlParameter p2 = new MySqlParameter();
                p2.ParameterName = "@v_statut_res";
                p2.Value = v_statut_res;

                MySqlParameter p3 = new MySqlParameter();
                p3.ParameterName = "@v_date_res";
                p3.Value = v_date_res;

                MySqlCommand cmd = new MySqlCommand(insert_query, Dao.conn);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
               

                int insertedrows = cmd.ExecuteNonQuery();

                if (insertedrows > 0)
                {
                    MessageBox.Show("Insertion reussie");
                }
                else
                {
                    MessageBox.Show("Insertion echouee");
                }

                txt_date_res.Clear();
               
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
