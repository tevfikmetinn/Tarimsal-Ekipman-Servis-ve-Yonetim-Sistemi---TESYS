using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Firat.Tesys.Interface
{
    
    public interface IMakineService
    {
        // 1. Makine kaydetme metodu (Hata varsa string döner)
        string MakineEkle(Makine m);

        // 2. Müşterinin makinelerini getirme metodu
        List<Makine> MusteriMakineleriniGetir(long musteriId);

        
        // Makinenin durumunu analiz edip "Acil Bakım", "İyi Durumda" gibi sonuç dönecek.
        string MakineDurumAnalizi(long makineId);
    }
}
