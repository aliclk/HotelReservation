using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Yıldızlar")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class Yildiz:DbObject
    {
        public int BegenmeSayisi { get; set; }
        public int BegenmemeSayisi { get; set; }

        public Yildiz()
        {

        }

        public override string ToString()
        {
            return "Beğenme Sayısı: " + BegenmeSayisi + "Beğenmeme Sayısı" + BegenmemeSayisi;
        }
    }
}
