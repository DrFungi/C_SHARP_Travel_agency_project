using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DB_CONNECTION.ui
{
    public partial class MenuAnalyse : Form
    {
        public MenuAnalyse()
        {
            InitializeComponent();
        }

        private void MenuAnalyse_Load(object sender, EventArgs e)
        {

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_lpg_Click(object sender, EventArgs e)
        {
           FenListePassager lps = new FenListePassager();
            lps.Show();
        }

        private void btn_ocas_Click(object sender, EventArgs e)
        {
            FenListePassOccas occpass = new FenListePassOccas();
            occpass.Show();
        }

        private void btn_md_Click(object sender, EventArgs e)
        {
            MasterDetail masterDetail = new MasterDetail();
            masterDetail.Show();
        }
    }
}
