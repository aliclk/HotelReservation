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
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();

            if (Properties.Settings.Default.BeniHatirla==true)
            {
                FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
                frmanasayfa.Show();
                this.Hide();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            UserFactory.GirisYapanKullanici = DbFactory.MusteriCrud.Records.
                FirstOrDefault(x => x.KullaniciAdi == tbxKullaniciAdi.Text && x.Sifre== tbxSifre.Text);

            if (UserFactory.GirisYapanKullanici!=null)
            {
                if (chbxBeniHatirla.Checked==true)
                {
                    Properties.Settings.Default.BeniHatirla = true;
                    Properties.Settings.Default.CurrentUserId = UserFactory.GirisYapanKullanici.ID;
                    Properties.Settings.Default.Save();
                }

                FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
                frmAnaSayfa.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı mevcut değil");
            }

           
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum frmSifremiUnuttum = new FrmSifremiUnuttum();
            frmSifremiUnuttum.Show();
            this.Hide();
        }
    }
}
