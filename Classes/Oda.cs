using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("Odalar")]//Veritabanında tablo ismini yeniden adlandırdık.
    public class Oda:DbObject
    {
        internal OdaTipi enumOdaTipi;
        public Otel otel { get; set; }
        public Yorum YorumIcerigi { get; set; }
        public bool OdaBosMu { get; set; }
        public double Ucret { get; set; }
        public string OdaNo { get; set; }

        public Oda()
        {

        }

        public Oda(Yorum yorumIcerigi, bool odaBosMu)
        {
            YorumIcerigi = yorumIcerigi;
            OdaBosMu = odaBosMu;
        }

        public override string ToString()
        {
            return "Yorum İçeriği: " + YorumIcerigi + "Oda Boş mu?" + OdaBosMu;
        }
    }
}
