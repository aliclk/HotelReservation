using HotelReservation.Classes;
using HotelReservation.Classes.Factory;
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
    public partial class FrmRezervasyonBilgileri : Form
    {
        private Oda _currentOda = null;
        public FrmRezervasyonBilgileri(Oda Oda)
        {
            InitializeComponent();
            _currentOda = Oda;
            DateTime BaslangicTarihi = Convert.ToDateTime(dtpGirisTarihi.Value);
            DateTime BitisTarihi = Convert.ToDateTime(dtpCikisTarihi.Value);

            TimeSpan ToplamGunSayisi = BitisTarihi - BaslangicTarihi;
            //iki tarih arasındaki farkı aldık

            lblToplamGunRzv.Text = ToplamGunSayisi.TotalDays.ToString();
            lblOdaNoRzv.Text = _currentOda.OdaNo;
            lblOtelAdiRzv.Text = _currentOda.otel.Adi;
            lblToplamUcretRzv.Text= (_currentOda.Ucret * Convert.ToInt32(ToplamGunSayisi.TotalDays)).ToString();
            
        }

        private void btnRezervasyonuTamamla_Click(object sender, EventArgs e)
        {
            if (rdbtnHemenOde.Checked==true)
            {
                Rezervasyon rezervasyon = new Rezervasyon();
                rezervasyon.Musteri = UserFactory.GirisYapanKullanici;
                rezervasyon.Oda = _currentOda;
                rezervasyon.CheckInDate= dtpGirisTarihi.Value;
                rezervasyon.CheckOutDate = dtpCikisTarihi.Value;
                rezervasyon.ToplamUcret = Convert.ToDouble(lblToplamUcretRzv.Text);

                FrmRezerveKisi frmrezervekisi = new FrmRezerveKisi(rezervasyon);
                frmrezervekisi.ShowDialog();
            }
            else if (rdbtnOteldeOdeme.Checked==true)
            {
                MessageBox.Show("Rezervasyon İşlemi Tamamlanmıştır.İyi Günler Dileriz.");
            }
        }

        private void FrmRezervasyonBilgileri_Load(object sender, EventArgs e)
        {
            dtpGirisTarihi.MinDate = DateTime.Now;
            dtpCikisTarihi.MinDate = DateTime.Now;
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime cikisTarihi = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan toplamGunSayisi = cikisTarihi - baslangicTarihi;

            lblToplamGunRzv.Text = toplamGunSayisi.TotalDays.ToString();
            lblToplamUcretRzv.Text = (_currentOda.Ucret*Convert.ToInt32
                (toplamGunSayisi.TotalDays)).ToString();
        }

    }
}
