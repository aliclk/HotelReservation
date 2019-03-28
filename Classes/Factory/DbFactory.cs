using HotelReservation.Classes.CrudFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes.Factory
{
    public static class DbFactory
    {
        private static volatile OtelContext _db = null;
        public static OtelContext Db
        {
            get
            {
                if (_db==null)
                {
                    _db = new OtelContext();
                }
                return _db;
            }
        }
        public static volatile GenelCrud<Il> _IlCrud = null;
        public static GenelCrud<Il> IlCrud
        {
            get
            {
                if (_IlCrud == null)
                {
                    _IlCrud = new GenelCrud<Il>(Db, Db.Iller);
                }
                return _IlCrud;
            }
        }
        public static volatile GenelCrud<Ilce> _IlceCrud = null;
        public static GenelCrud<Ilce> IlceCrud
        {
            get
            {
                if (_IlceCrud == null)
                {
                    _IlceCrud = new GenelCrud<Ilce>(Db, Db.Ilceler);
                }
                return _IlceCrud;
            }
        }
        public static volatile GenelCrud<Mahalle> _MahalleCrud = null;
        public static GenelCrud<Mahalle> MahalleCrud
        {
            get
            {
                if (_MahalleCrud == null)
                {
                    _MahalleCrud = new GenelCrud<Mahalle>(Db, Db.Mahalleler);
                }
                return _MahalleCrud;
            }
        }
        public static volatile GenelCrud<Musteri> _MusteriCrud = null;
        public static GenelCrud<Musteri> MusteriCrud
        {
            get
            {
                if (_MusteriCrud == null)
                {
                    _MusteriCrud = new GenelCrud<Musteri>(Db, Db.Musteriler);
                }
                return _MusteriCrud;
            }
        }
        public static volatile GenelCrud<Oda> _OdaCrud = null;
        public static GenelCrud<Oda> OdaCrud
        {
            get
            {
                if (_OdaCrud == null)
                {
                    _OdaCrud = new GenelCrud<Oda>(Db, Db.Odalar);
                }
                return _OdaCrud;
            }
        }
        public static volatile GenelCrud<Otel> _OtelCrud = null;
        public static GenelCrud<Otel> OtelCrud
        {
            get
            {
                if (_OtelCrud == null)
                {
                    _OtelCrud = new GenelCrud<Otel>(Db, Db.Oteller);
                }
                return _OtelCrud;
            }
        }
        public static volatile GenelCrud<OtelOzelligi> _OtelOzelligiCrud = null;
        public static GenelCrud<OtelOzelligi> OtelOzelligiCrud
        {
            get
            {
                if (_OtelOzelligiCrud == null)
                {
                    _OtelOzelligiCrud = new GenelCrud<OtelOzelligi>(Db, Db.OtelOzellikleri);
                }
                return _OtelOzelligiCrud;
            }
        }
        public static volatile GenelCrud<OtelResimleri> _OtelResimleriCrud = null;
        public static GenelCrud<OtelResimleri> OtelResimleriCrud
        {
            get
            {
                if (_OtelResimleriCrud == null)
                {
                    _OtelResimleriCrud = new GenelCrud<OtelResimleri>(Db, Db.OtelResimleri);
                }
                return _OtelResimleriCrud;
            }
        }
        public static volatile GenelCrud<Ozellik> _OzellikCrud = null;
        public static GenelCrud<Ozellik> OzellikCrud
        {
            get
            {
                if (_OzellikCrud == null)
                {
                    _OzellikCrud = new GenelCrud<Ozellik>(Db, Db.Ozellikler);
                }
                return _OzellikCrud;
            }
        }
        public static volatile GenelCrud<Rezervasyon> _RezervasyonCrud = null;
        public static GenelCrud<Rezervasyon> RezervasyonCrud
        {
            get
            {
                if (_RezervasyonCrud == null)
                {
                    _RezervasyonCrud = new GenelCrud<Rezervasyon>(Db, Db.Rezervasyonlar);
                }
                return _RezervasyonCrud;
            }
        }
        public static volatile GenelCrud<Yildiz> _YildizCrud = null;
        public static GenelCrud<Yildiz> YildizCrud
        {
            get
            {
                if (_YildizCrud == null)
                {
                    _YildizCrud = new GenelCrud<Yildiz>(Db, Db.Yildizlar);
                }
                return _YildizCrud;
            }
        }
        public static volatile GenelCrud<Yorum> _YorumCrud = null;
        public static GenelCrud<Yorum> YorumCrud
        {
            get
            {
                if (_YorumCrud == null)
                {
                    _YorumCrud = new GenelCrud<Yorum>(Db, Db.Yorumlar);
                }
                return _YorumCrud;
            }
        }
    }
}
