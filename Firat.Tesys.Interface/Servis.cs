using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Firat.Tesys.Interface
{
    public class Servis
    {
        public int ParcaID { get; set; }
        public int UstaID { get; set; }
        public decimal ParcaUcreti { get; set; }
        public decimal IscilikUcreti { get; set; }
        public long MakineID { get; set; } // Yeni eklediğimiz bağlantı
        public long ServisID { get; set; }
        public long MusteriID { get; set; } 
        public DateTime GelisTarihi { get; set; }
        public string CihazTuru { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ArizaAciklama { get; set; }
        public string Durum { get; set; } 
        public decimal Ucret { get; set; }
    }
}

