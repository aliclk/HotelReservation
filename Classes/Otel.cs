using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Oteller")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class Otel:DbObject
    {
        [MaxLength(50)]
        public string Adi { get; set; }
        public Il AdresIl { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }
        public string SirketAdi { get; set; }
        [MaxLength(200)]
        public string Aciklama { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Yildiz> Yildizlar { get; set; }
        public int YildizSayisi { get; set; }
        [MaxLength(11)]
        public string TelefonNumarasi { get; set; }

        public Otel(string adi, Il adresIl, Ilce ilce, Mahalle mahalle, string sirketAdi, string aciklama, List<Yorum> yorumlar, List<Yildiz> yildizlar, int yildizSayisi, string telefonNumarasi)
        {
            Adi = adi;
            AdresIl = adresIl;
            Ilce = ilce;
            Mahalle = mahalle;
            SirketAdi = sirketAdi;
            Aciklama = aciklama;
            Yorumlar = new List<Yorum>();
            Yildizlar = new List<Yildiz>();
            YildizSayisi = yildizSayisi;
            TelefonNumarasi = telefonNumarasi;
        }
        
        public Otel()
        {
            Yorumlar = new List<Yorum>();
            Yildizlar = new List<Yildiz>();
        }

        public override string ToString()
        {
            return "Otel Adı: " + Adi + "Otel Adresi: " + AdresIl;
        }
    }
}
