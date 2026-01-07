using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firat.Tesys.Interface;
using Firat.Tesys.Service;

namespace Firat.Tesys.Business
{
    public class ServisManager : IServisService
    {
        public bool ArizaKaydiOlustur(Servis yeniKayit)
        {
            
            if (yeniKayit.MusteriID <= 0) return false;

            SqlServisService servis = new SqlServisService();
            return servis.ArizaKaydiOlustur(yeniKayit);
        }

        public DashboardVeri DashboardIstatistikleriniGetir()
        {
            SqlServisService servis = new SqlServisService();
            return servis.DashboardIstatistikleriniGetir();
        }

        public Dictionary<string, int> ArizaGrafigiGetir()
        {
            SqlServisService servis = new SqlServisService();
            return servis.ArizaGrafigiGetir();
        }

        public bool ServisDurumGuncelle(long servisID, string yeniDurum)
        {
            SqlServisService servis = new SqlServisService();
            return servis.ServisDurumGuncelle(servisID, yeniDurum);
        }
        public void ServisDurumGuncelle(int servisID, string yeniDurum)
        {
            SqlServisService servis = new SqlServisService();
            servis.ServisDurumGuncelle(servisID, yeniDurum);
        }

        public Usta AyinElemaniniGetir()
        {
            SqlServisService servis = new SqlServisService();
            return servis.AyinElemaniniGetir();
        }

        public List<Usta> UstalariGetir(int parcaID)
        {
            SqlServisService servis = new SqlServisService();
            return servis.UstalariGetir(parcaID);
        }
        public List<ServisDetay> ServisListesiGetir()
        {
            SqlServisService servis = new SqlServisService();
            return servis.ServisListesiGetir();
        }

        public List<MakineTuru> MakineleriGetir()
        {
            SqlServisService servis = new SqlServisService();
            return servis.MakineleriGetir();
        }

        public List<Parca> ParcalariGetir(int makineTurID)
        {
            SqlServisService servis = new SqlServisService();
            return servis.ParcalariGetir(makineTurID);
        }

        public List<BakimMusteri> BakimListesiGetir()
        {
            SqlServisService servis = new SqlServisService();
            return servis.BakimListesiGetir();
        }
    }
}
