using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Firat.Tesys.Interface
{
    public interface IServisService
    {
        // Arıza kaydı oluşturma yeteneği
        bool ArizaKaydiOlustur(Servis yeniKayit);
        bool ServisDurumGuncelle(long servisID, string yeniDurum);
        // Seçilen parçanın uzmanlık alanına göre ustaları getiren akıllı metot
        System.Collections.Generic.List<Usta> UstalariGetir(int parcaID);

        // EKSİK OLAN KISIM BURASI: Listeleme yeteneği
        List<ServisDetay> ServisListesiGetir();
        DashboardVeri DashboardIstatistikleriniGetir();
        Dictionary<string, int> ArizaGrafigiGetir();
        System.Collections.Generic.List<BakimMusteri> BakimListesiGetir();
        // Makineleri getiren metot
        System.Collections.Generic.List<MakineTuru> MakineleriGetir();

        // Seçilen makineye göre parçaları getiren metot (ID alacak)
        System.Collections.Generic.List<Parca> ParcalariGetir(int makineTurID);
        void ServisDurumGuncelle(int servisID, string yeniDurum);
        Usta AyinElemaniniGetir();
    }
}