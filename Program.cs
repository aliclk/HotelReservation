using HotelReservation.Classes.Factory;
using HotelReservation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //veritabanını başlatmak için.
            DbFactory.IlceCrud.CheckConnection();
            DbFactory.IlCrud.CheckConnection();
            DbFactory.MahalleCrud.CheckConnection();
            DbFactory.MusteriCrud.CheckConnection();
            DbFactory.OdaCrud.CheckConnection();
            DbFactory.OtelCrud.CheckConnection();
            DbFactory.OtelOzelligiCrud.CheckConnection();
            DbFactory.OtelResimleriCrud.CheckConnection();
            DbFactory.OzellikCrud.CheckConnection();
            DbFactory.RezervasyonCrud.CheckConnection();
            DbFactory.YildizCrud.CheckConnection();
            DbFactory.YorumCrud.CheckConnection();
            //veritabanı doğru bir şekilde başladı.

            if (Properties.Settings.Default.BeniHatirla==true)
            {
                UserFactory.GirisYapanKullanici = DbFactory.MusteriCrud.Find(Properties.Settings.Default.CurrentUserId);
            }
            Application.Run(new FrmAnaSayfa());
        }
    }
}
