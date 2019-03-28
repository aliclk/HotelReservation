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
    public partial class FrmOteller : Form
    {
        private Oda _currentOda = null;
        public FrmOteller(Oda currentOda)
        {
            InitializeComponent();
            _currentOda = currentOda;
            lblOtelAciklama.Text = _currentOda.otel.Aciklama;
            lblOtelAdres.Text = _currentOda.otel.Mahalle.MahalleAdi + "Mah." + _currentOda.otel.Ilce.IlceAdi
                + "/" + _currentOda.otel.AdresIl.IlAdi;
            lblOtelTelefon.Text = _currentOda.otel.TelefonNumarasi;
            lblOtelFiyat.Text = _currentOda.Ucret + "TL";

            lblOtelYildiz.Text = string.Empty;
            for (int i = 0; i < _currentOda.otel.YildizSayisi; i++)
            {
                lblOtelYildiz.Text += "*";
            }
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            FrmRezervasyonBilgileri frmRezerveBilgileri = new FrmRezervasyonBilgileri(_currentOda);
            frmRezerveBilgileri.ShowDialog();
            this.Hide();
        }

        private void btnYorumlar_Click(object sender, EventArgs e)
        {
            FrmYorumlar frmYorumlar = new FrmYorumlar(_currentOda.otel);
            frmYorumlar.ShowDialog();
        }
    }
}
