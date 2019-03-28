using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Ilceler")]//Veritabanında tablo ismini yeniden adlandırdık.
    public class Ilce:DbObject
    {
        [MaxLength(50)]             
        public string IlceAdi { get; set; }
        public List<Mahalle> Mahalleler { get; set; }

        public Ilce()
        {

        }

        public Ilce(string ilceAdi, List<Mahalle> mahalleler)
        {
            IlceAdi = ilceAdi;
            Mahalleler = new List<Mahalle>();
        }

        public override string ToString()
        {
            return "İlçe Adı: " + IlceAdi;
        }
    }
}
