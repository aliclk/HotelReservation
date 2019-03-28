using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("OtelOzellikleri")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class OtelOzelligi:DbObject
    {
        public Otel Otel { get; set; }
        public Ozellik Ozellik { get; set; }

        public OtelOzelligi()
        {

        }

        public override string ToString()
        {
            return "Otel Özelliği: " + Ozellik;
        }
    }
}
