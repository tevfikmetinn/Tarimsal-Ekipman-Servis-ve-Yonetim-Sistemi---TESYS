using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Firat.Tesys.Interface
{
    public interface IMusteriService
    {
        
        bool MusteriKaydet(Musteri yeniMusteri);


        List<Musteri> MusteriListele();
        bool MusteriSil(long musteriID);
        bool MusteriGuncelle(Musteri guncellenecekMusteri);
    }
    
    }
