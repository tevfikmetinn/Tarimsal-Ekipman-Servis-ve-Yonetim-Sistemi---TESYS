using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Firat.Tesys.Interface
{
    public class BakimMusteri
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Cihaz { get; set; }     // Traktör vb.
        public DateTime SonGelisTarihi { get; set; }
        public int GecenGun { get; set; }     // Kaç gün oldu?
        public string Durum { get; set; }     // Acil, Normal, İyi
    }
}
