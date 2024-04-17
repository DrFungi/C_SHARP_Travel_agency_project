using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
