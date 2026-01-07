using System;

namespace Firat.Tesys.Interface
{
    
    public class ServisDetay
    {
        public long ServisID { get; set; }
        public string MusteriAdSoyad { get; set; } // Müşteri tablosundan gelecek isim
        public string CihazTuru { get; set; }
        public string MarkaModel { get; set; }
        public string Durum { get; set; } // Bekliyor, Tamir Edildi vb.
        public DateTime GelisTarihi { get; set; }
        public decimal Ucret { get; set; }
    }
}