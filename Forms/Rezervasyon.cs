using HotelReservation.Classes;
using HotelReservation.Classes.Factory;
using HotelReservation.CustomControls;
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
    public partial class FrmRezervasyon : Form
    {
        public FrmRezervasyon()
        {
            InitializeComponent();
            foreach (Oda item in FrmAnaSayfa.odalar)
            {
                OdaItem odaitem = new OdaItem(item);
                flpOdalarContainer.Controls.Add(odaitem);
            }
            if (UserFactory.GirisYapanKullanici!=null)
            {
                pnlUyeOl.Visible = false;
                pnlCikisYap.Visible = true;
            }
        }
        public static List<Oda> odalar;
        public static Oda seciliOda;

        private void btnAra_Click(object sender, EventArgs e)
        {
            flpOdalarContainer.Controls.Clear();
            odalar = DbFactory.OdaCrud.Records.Where(x => (x.otel.Adi.ToLower().Contains(tbxAra.Text.ToLower())
            || x.otel.AdresIl.IlAdi.ToLower().Contains(tbxAra.Text.ToLower())
            || x.otel.Ilce.IlceAdi.ToLower().Contains(tbxAra.Text.ToLower())
            || x.otel.Mahalle.MahalleAdi.ToLower().Contains(tbxAra.Text.ToLower()))
            && x.enumOdaTipi == (OdaTipi)cbxOdaTipi.SelectedIndex).ToList();

            foreach (Oda oda in odalar)
            {
                if (DbFactory.RezervasyonCrud.Records.Any(x=>x.Oda.ID==oda.ID &&
                x.CheckInDate>dtpGirisTarihi.Value&&x.CheckOutDate<dtpCikisTarihi.Value)==true)
                {
                    odalar.Remove(oda);
                }
            }
            if (odalar.Count>0)
            {
                foreach (Oda oda in odalar)
                {
                    OdaItem odaItem = new OdaItem(oda);
                    flpOdalarContainer.Controls.Add(odaItem);
                }

            }
        }

        private void FrmRezervasyon_Load(object sender, EventArgs e)
        {
            //DateTimePicker da bugünün ve sonraki günlerin seçilmesinin sağladık.
            dtpGirisTarihi.MinDate = DateTime.Now;
            dtpCikisTarihi.MinDate = DateTime.Now;
            cbxOdaTipi.SelectedIndex = 0;
        }

        private void LlblCikisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserFactory.GirisYapanKullanici = null;
            pnlCikisYap.Visible = false;
            pnlUyeOl.Visible = true;
            Properties.Settings.Default.BeniHatirla = false;
            Properties.Settings.Default.CurrentUserId = null;
            Properties.Settings.Default.Save();
        }

        private void LlblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayitOl frmkayitol = new FrmKayitOl();
            frmkayitol.Show();
            this.Hide();
        }

        private void LlblGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisEkrani giris = new FrmGirisEkrani();
            giris.Show();
            this.Hide();
        }

        private void tbxAra_click(object sender, EventArgs e)
        {
            tbxAra.Clear();
        }
    }
}
