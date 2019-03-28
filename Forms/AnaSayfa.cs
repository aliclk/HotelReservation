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
    public partial class FrmAnaSayfa : Form
    {
        public static List<Oda> odalar;

        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var t = DbFactory.OdaCrud.Records;
            odalar = DbFactory.OdaCrud.Records.Where(x => x.otel.Adi.ToLower().Contains(txtArama.Text.ToLower())
              || x.otel.AdresIl.IlAdi.ToLower().Contains(txtArama.Text.ToLower())
              || x.otel.Ilce.IlceAdi.ToLower().Contains(txtArama.Text.ToLower())
              || x.otel.Mahalle.MahalleAdi.ToLower().Contains(txtArama.Text.ToLower())).ToList();

            FrmRezervasyon frmrezervasyon = new FrmRezervasyon();
            frmrezervasyon.Show();
            this.Hide();
        }

        private void txtArama_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
        }
    }
}
