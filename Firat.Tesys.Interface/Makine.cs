using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firat.Tesys.Interface
{
    public class Makine
    {
        // SQL'de BIGINT yaptığımız için burada long kullanıyoruz (Standart 106)
        public long MakineID { get; set; }
        public long MusteriID { get; set; }

        public string CihazTuru { get; set; } // Traktör, Biçerdöver
        public string Marka { get; set; }     // New Holland, Claas
        public string Model { get; set; }     // TD 110
        public string SeriNo { get; set; }    // Şasi No
        public int UretimYili { get; set; }

        public DateTime KayitTarihi { get; set; }

        // Analiz sonucu için ek özellik (Veritabanında yok, hesaplanıp buraya yazılacak)
        public string Durum { get; set; }
    }
}
