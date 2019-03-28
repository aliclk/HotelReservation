using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Musteriler")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class Musteri:DbObject
    {
        [MaxLength(50)]//veritabanında adın uzunluğunu belirledik.
        public string Adi { get; set; }
        [MaxLength(50)]
        public string Soyadi { get; set; }
        [MaxLength(50)]
        public string Sifre { get; set; }
        [MaxLength(50)]
        public string KullaniciAdi { get; set; }
        [MaxLength(11)]
        public string Telefon { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(11)]
        public string TcNo { get; set; }

        public Musteri(string adi, string soyadi, string sifre, string kullaniciAdi, string telefon, string email, string tcNo)
        {
            Adi = adi;
            Soyadi = soyadi;
            Sifre = sifre;
            KullaniciAdi = kullaniciAdi;
            Telefon = telefon;
            Email = email;
            TcNo = tcNo;
        }

        public Musteri()
        {

        }

        public override string ToString()
        {
            return "Adı: " + Adi + "Soyadı: " + Soyadi;
        }
    }
}
