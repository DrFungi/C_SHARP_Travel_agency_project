using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


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
                Dao.GetConnection();
                MessageBox.Show("Connexion ok ");

                string select = "select  codePassager from passager";
                MySqlCommand cmd = new MySqlCommand(select, Dao.conn);
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
            /*try
            {
                Dao.GetConnection();


                string insert_query = "INSERT INTO RESERVATION (codePassager,statutReservation,dateReservation)" +
                    " VALUES (@v_code_passager,@v_statut_res,@v_date_res)";

                string v_code_passager = txt_codePassager.Text;
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
            }*/
        }


        private void cmb_passager_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Dao.GetConnection();

                // Récupérez le nom du passager sélectionné
                string selectedNom = cmb_passager.SelectedItem.ToString();

                // Utilisez un paramètre dans la requête SQL pour éviter les problèmes liés à l'encapsulation de chaînes de caractères
                string q = "SELECT codePassager FROM PASSAGER WHERE nom = @nom";
                MySqlCommand cmd = new MySqlCommand(q, Dao.conn);
                cmd.Parameters.AddWithValue("@nom", selectedNom);

                // Exécutez la requête SQL et lisez le résultat
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    // Récupérez le code passager correspondant
                    txt_codePassager.Text = rdr["codePassager"].ToString();
                }
                else
                {
                    // Effacez le champ si aucun code n'est trouvé
                    txt_codePassager.Clear();
                }
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
