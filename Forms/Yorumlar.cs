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
    public partial class FrmYorumlar : Form
    {
        public Otel _currentOtel;
        public FrmYorumlar(Otel otel)
        {
            InitializeComponent();
            _currentOtel = otel;
            lblOtelAdiYorumlar.Text = _currentOtel.Adi;

            foreach (Yorum item in otel.Yorumlar)
            {
                YorumItem yorumlar = new YorumItem(item,otel);
                flpYorumlar.Controls.Add(yorumlar);
            }
        }
       
        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            Yorum yorum = new Yorum();
            yorum.YorumBasligi = txtYorumBasligi.Text;
            yorum.YorumIcerigi = rtxtYorum.Text;
            yorum.Musteri = UserFactory.GirisYapanKullanici;

            _currentOtel.Yorumlar.Add(yorum);

            bool eklendiMi = DbFactory.OtelCrud.Update(_currentOtel.ID, _currentOtel);
            flpYorumlar.Controls.Clear();
            foreach (Yorum item in _currentOtel.Yorumlar)
            {
                YorumItem yorumItem = new YorumItem(item,_currentOtel);
                flpYorumlar.Controls.Add(yorumItem);
            }
        }

    }
}
