using System;
using System.Windows.Forms;
using TP_DB_CONNECTION.ui;

namespace TP_DB_CONNECTION
{
    public partial class MenuHome : Form
    {
        public MenuHome()
        {
            InitializeComponent();
        }

        private void btn_passager_Click(object sender, EventArgs e)
        {
            InsertPassager insertPassager = new InsertPassager();
            insertPassager.Show();
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            InsertReservation insertReservation = new InsertReservation();
            insertReservation.Show();
            
        }

        private void btn_Analyse_Click(object sender, EventArgs e)
        {
            MenuAnalyse analyse = new MenuAnalyse();
            analyse.Show();
        }
    }
}
