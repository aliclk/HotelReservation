using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Yorumlar")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class Yorum:DbObject
    {
        public Musteri Musteri { get; set; }
        [MaxLength(50)]
        public string YorumBasligi { get; set; }
        [MaxLength(100)]
        public string YorumIcerigi { get; set; }
        public List<Yildiz> Yildizlar { get; set; }

        public Yorum()
        {
            Yildizlar = new List<Yildiz>();
        }

        public Yorum(string yorumBasligi, string yorumIcerigi, List<Yildiz> yildizlar)
        {
            YorumBasligi = yorumBasligi;
            YorumIcerigi = yorumIcerigi;
            Yildizlar = yildizlar;
        }

        public override string ToString()
        {
            return "Yorum Başlığı: " + YorumBasligi + "Yorum İçeriği: " + YorumIcerigi;
        }
    }
}
