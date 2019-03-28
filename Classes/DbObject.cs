using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class DbObject
    {
        public string ID { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        [MaxLength(50)]
        public string OlusturanKisi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        [MaxLength(50)]
        public string GuncelleyenKisi { get; set; }

        public DbObject()
        {
            ID = Guid.NewGuid().ToString();//Benzersiz ID oluşturur.
            OlusturmaTarihi = DateTime.Now;
            OlusturanKisi = "Ali";
            GuncellemeTarihi = DateTime.Now;
            GuncelleyenKisi = "Ali";
        }      
    }
}
