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

        }
        Dao Dao = new Dao("server=localhost;userid=root;database=gestionreservation;port=3306");

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_inserer_Click(object sender, EventArgs e)
        {
            Dao.GetConnection();
            txt_nom.Text= "ça marche";


            Dao.EndConnection();
        }
    }
}
