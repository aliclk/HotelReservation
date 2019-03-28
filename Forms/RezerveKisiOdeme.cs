using HotelReservation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class FrmRezerveKisi : Form
    {
        private Rezervasyon _currentRezervasyon = null;
        public FrmRezerveKisi(Rezervasyon rezervasyon)
        {
            _currentRezervasyon = rezervasyon;
            InitializeComponent();
            lblGirisTarihiOdeme.Text = _currentRezervasyon.CheckInDate.ToShortDateString();
            lblCikisTarihiOdeme.Text = _currentRezervasyon.CheckOutDate.ToShortDateString();
            lblOdenecekTutar.Text = _currentRezervasyon.ToplamUcret.ToString();
        }

        private void btnOdemeyiTamamla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezervasyon işlemi tamamlanmıştır.İyi günler dileriz.");
        }
    }
}
