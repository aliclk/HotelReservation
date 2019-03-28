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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = tbxKayitAdi.Text;
            musteri.Soyadi = tbxKayitSoyadi.Text;
            musteri.KullaniciAdi = tbxKayitKullaniciAdi.Text;
            musteri.Sifre = tbxKayitSifre.Text;
            musteri.Telefon = tbxKayitTelefon.Text;
            musteri.Email = tbxKayitEmail.Text;
            musteri.TcNo = tbxKayitTcNo.Text;

            var varMi = DbFactory.MusteriCrud.Records.FirstOrDefault(x => x.KullaniciAdi == tbxKayitKullaniciAdi.Text);
            if (varMi==null)
            {
                DbFactory.MusteriCrud.Insert(musteri);

                FrmGirisEkrani frmgiris = new FrmGirisEkrani();
                frmgiris.Show();
                this.Hide();
            }
            else
            {
                lblKullaniciMevcut.Text = "Bu Kullanıcı Adı alınmış";
            }
        }
    }
}
