using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservation.Classes;
using HotelReservation.Forms;

namespace HotelReservation.CustomControls
{
    public partial class OdaItem : UserControl
    {
        private Oda _currentOda = null; 
        public OdaItem(Oda currentOda)
        {
            InitializeComponent();
            _currentOda = currentOda;
            lblOtelAdi.Text = _currentOda.otel.Adi;
            lblOdaTipi.Text = _currentOda.enumOdaTipi.ToString();
            lblTelefon.Text = _currentOda.otel.TelefonNumarasi;
            lblAdres.Text = _currentOda.otel.Mahalle.MahalleAdi + "mah."
                + _currentOda.otel.Ilce.IlceAdi + "/" + _currentOda.otel.AdresIl.IlAdi;
            lblOdaFiyat.Text = _currentOda.Ucret + "TL";

            lblYildiz.Text = string.Empty;
            for (int i = 0; i < _currentOda.otel.YildizSayisi; i++)
            {
                lblYildiz.Text += "*";
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            FrmOteller oteller = new FrmOteller(_currentOda);
            oteller.ShowDialog();
        }
    }
}
