using System;
using System.Collections.Generic;
using Firat.Tesys.Interface;
using Firat.Tesys.Service;

namespace Firat.Tesys.Business
{
    
    public class MusteriManager : IMusteriService
    {

        

        public bool MusteriKaydet(Musteri yeniMusteri)
        {
            if (string.IsNullOrEmpty(yeniMusteri.Ad) || string.IsNullOrEmpty(yeniMusteri.Soyad))
            {
                return false;
            }

            SqlMusteriService veriServisi = new SqlMusteriService();

           
            return veriServisi.MusteriKaydet(yeniMusteri);
        }
        public bool MusteriSil(long musteriID)
        {
            
            if (musteriID <= 0) return false;

            SqlMusteriService veriServisi = new SqlMusteriService();
            return veriServisi.MusteriSil(musteriID);
        }
        public bool MusteriGuncelle(Musteri guncellenecekMusteri)
        {
            
            if (string.IsNullOrEmpty(guncellenecekMusteri.Ad) || string.IsNullOrEmpty(guncellenecekMusteri.Soyad))
            {
                return false;
            }

            SqlMusteriService veriServisi = new SqlMusteriService();
            return veriServisi.MusteriGuncelle(guncellenecekMusteri);
        }


        public List<Musteri> MusteriListele()
        {
            
            SqlMusteriService veriServisi = new SqlMusteriService();
            return veriServisi.MusteriListele();
        }
    }
}