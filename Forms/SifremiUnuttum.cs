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
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            var sifremiUnuttum = DbFactory.MusteriCrud.Records.FirstOrDefault
                (x => x.Email == txtlblSifremiUnuttumEmail.Text
                && x.KullaniciAdi == txtlblSifremiUnuttumKullaniciAdi.Text);
            if (sifremiUnuttum!=null)
            {
                MessageBox.Show("Şifreniz: " + sifremiUnuttum.Sifre);
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Hatalı");
            }
        }
    }
}
