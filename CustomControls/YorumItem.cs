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

namespace HotelReservation.CustomControls
{
    public partial class YorumItem : UserControl
    {
        private Yorum _currentYorum = null;
        
        public YorumItem(Yorum currentYorum,Otel currentOtel)
        {
            InitializeComponent();
            _currentYorum = currentYorum;

            LblYorumBasligi.Text = _currentYorum.YorumBasligi;
            lblYorumlar.Text = _currentYorum.YorumIcerigi;
            lblOtelAdi.Text = currentOtel.Adi;
        }
    }
}
