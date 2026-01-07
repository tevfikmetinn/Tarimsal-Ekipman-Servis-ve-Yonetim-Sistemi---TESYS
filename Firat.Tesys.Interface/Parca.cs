using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firat.Tesys.Interface
{
    public class Parca
    {
        public int ParcaID { get; set; }
        public string ParcaAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public int StokAdet { get; set; }
        public int KritikSeviye { get; set; }
    }
}