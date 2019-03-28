using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes
{
    [Table("OtelResimleri")]//Veritabanında tablo ismini yeniden adlandırdık.

    public class OtelResimleri:DbObject
    {
        public Otel otel { get; set; }
        public byte[] Resim { get; set; }

        public OtelResimleri()
        {

        }

        public OtelResimleri(byte[] resim)
        {
            Resim = resim;
        }

        public override string ToString()
        {
            return "Otel Resim: " + Resim;
        }
    }
}
