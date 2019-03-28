using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Rezervasyonlar")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class Rezervasyon:DbObject
    {
        public Musteri Musteri { get; set; }
        public Oda Oda { get; set; }
        public int KisiSayisi { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public double ToplamUcret { get; set; }

        public Rezervasyon()
        {

        }

        public Rezervasyon(int kisiSayisi, DateTime checkInDate, DateTime checkOutDate)
        {
            KisiSayisi = kisiSayisi;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public override string ToString()
        {
            return "Kişi Sayısı: " + KisiSayisi + "CheckIn: " + CheckInDate + "CheckOut: " + CheckOutDate;
        }
    }
}
