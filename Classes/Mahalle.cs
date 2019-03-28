using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Mahalleler")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class Mahalle:DbObject
    {
        [MaxLength(50)]
        public string MahalleAdi { get; set; }

        public Mahalle(string mahalleAdi)
        {
            MahalleAdi = mahalleAdi;
        }

        public Mahalle()
        {

        }

        public override string ToString()
        {
            return "Mahalle Adı: " + MahalleAdi;
        }


    }
}
