using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Firat.Tesys.Interface;

namespace Firat.Tesys.Service
{
    public class SqlServisService : IServisService
    {
        string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DB_TESYS; Trusted_Connection=True; TrustServerCertificate=True;";

        public bool ArizaKaydiOlustur(Servis yeniKayit)
        {

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                SqlTransaction trans = baglanti.BeginTransaction();

                try
                {
                    // ⚠️ GÜNCELLEME 1: SQL Sorgusuna MakineID sütununu ve @pMakine parametresini ekledik
                    string servisSorgu = @"INSERT INTO T_SERVIS 
                        (MusteriID, MakineID, GelisTarihi, CihazTuru, Marka, Model, ArizaAciklama, Durum, Ucret, ParcaID, ParcaUcreti, IscilikUcreti, UstaID) 
                        VALUES 
                        (@p1, @pMakine, @p2, @p3, @p4, @p5, @p6, 'Bekliyor', @p8, @p9, @p10, @p11, @p12)";

                    SqlCommand kmtServis = new SqlCommand(servisSorgu, baglanti, trans);

                    kmtServis.Parameters.AddWithValue("@p1", yeniKayit.MusteriID);

                    //  GÜNCELLEME 2: MakineID Parametresi
                    // Eğer Makine seçilmediyse (0 ise) veritabanına NULL atalım ki hata vermesin
                    if (yeniKayit.MakineID > 0)
                        kmtServis.Parameters.AddWithValue("@pMakine", yeniKayit.MakineID);
                    else
                        kmtServis.Parameters.AddWithValue("@pMakine", DBNull.Value);

                    kmtServis.Parameters.AddWithValue("@p2", yeniKayit.GelisTarihi);
                    kmtServis.Parameters.AddWithValue("@p3", yeniKayit.CihazTuru);
                    kmtServis.Parameters.AddWithValue("@p4", yeniKayit.Marka);
                    kmtServis.Parameters.AddWithValue("@p5", yeniKayit.Model);
                    kmtServis.Parameters.AddWithValue("@p6", yeniKayit.ArizaAciklama);

                    // @p8 = Toplam Ücret (Parça + İşçilik)
                    kmtServis.Parameters.AddWithValue("@p8", yeniKayit.ParcaUcreti + yeniKayit.IscilikUcreti);

                    kmtServis.Parameters.AddWithValue("@p9", yeniKayit.ParcaID);
                    kmtServis.Parameters.AddWithValue("@p10", yeniKayit.ParcaUcreti);
                    kmtServis.Parameters.AddWithValue("@p11", yeniKayit.IscilikUcreti);
                    kmtServis.Parameters.AddWithValue("@p12", yeniKayit.UstaID);

                    kmtServis.ExecuteNonQuery();

                    // 2. STOKTAN DÜŞ (Burası Aynen Kaldı)
                    string stokSorgu = "UPDATE T_PARCA SET StokAdet = StokAdet - 1 WHERE ParcaID = @id";
                    SqlCommand kmtStok = new SqlCommand(stokSorgu, baglanti, trans);
                    kmtStok.Parameters.AddWithValue("@id", yeniKayit.ParcaID);
                    kmtStok.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    return false;
                }
            }

        }
        public Usta AyinElemaniniGetir()
        {
            Usta sampiyon = new Usta();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    // En çok iş bitiren ustayı bulan sorgu (TOP 1)
                    string sorgu = @"
                SELECT TOP 1 
                    U.AdSoyad, 
                    COUNT(*) as IsSayisi 
                FROM T_SERVIS S
                INNER JOIN T_USTA U ON S.UstaID = U.UstaID
                WHERE S.Durum = 'Tamamlandı'
                GROUP BY U.AdSoyad
                ORDER BY IsSayisi DESC";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        sampiyon.AdSoyad = oku["AdSoyad"].ToString();
                        sampiyon.TamamlananIsSayisi = Convert.ToInt32(oku["IsSayisi"]);
                    }
                    else
                    {
                        // Hiç iş yoksa
                        sampiyon.AdSoyad = "Henüz Yok";
                        sampiyon.TamamlananIsSayisi = 0;
                    }
                }
            }
            catch { }
            return sampiyon;
        }

        public DashboardVeri DashboardIstatistikleriniGetir()
        {
            DashboardVeri veri = new DashboardVeri();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    // 1. Toplam Müşteri Sayısı
                    SqlCommand kmt1 = new SqlCommand("SELECT COUNT(*) FROM T_MUSTERI", baglanti);
                    veri.ToplamMusteri = Convert.ToInt32(kmt1.ExecuteScalar());

                    // 2. Bekleyen Servis Sayısı
                    SqlCommand kmt2 = new SqlCommand("SELECT COUNT(*) FROM T_SERVIS WHERE Durum='Bekliyor'", baglanti);
                    veri.BekleyenServis = Convert.ToInt32(kmt2.ExecuteScalar());

                    // 3. Tamamlanan Servis Sayısı
                    SqlCommand kmt3 = new SqlCommand("SELECT COUNT(*) FROM T_SERVIS WHERE Durum='Tamamlandı'", baglanti);
                    veri.TamamlananServis = Convert.ToInt32(kmt3.ExecuteScalar());

                    // 4. Toplam Kazanç 
                    SqlCommand kmt4 = new SqlCommand("SELECT ISNULL(SUM(Ucret), 0) FROM T_SERVIS WHERE Durum='Tamamlandı'", baglanti);
                    veri.ToplamKazanc = Convert.ToDecimal(kmt4.ExecuteScalar());
                }
            }
            catch
            {
                // Hata olursa hepsi 0 kalsın
            }
            return veri;
        }
        public bool ServisDurumGuncelle(long servisID, string yeniDurum)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    // Sadece Durum sütununu güncelle
                    string sorgu = "UPDATE T_SERVIS SET Durum=@p1 WHERE ServisID=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", yeniDurum);
                    komut.Parameters.AddWithValue("@id", servisID);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<ServisDetay> ServisListesiGetir()
        {
            List<ServisDetay> liste = new List<ServisDetay>();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    // SQL KODU (JOIN)
                    string sorgu = @"
                SELECT 
                    S.ServisID,
                    M.Ad + ' ' + M.Soyad AS MusteriAdSoyad,
                    S.CihazTuru,
                    S.Marka + ' ' + S.Model AS MarkaModel,
                    S.Durum,
                    S.GelisTarihi,
                    S.Ucret
                FROM T_SERVIS S
                INNER JOIN T_MUSTERI M ON S.MusteriID = M.MusteriID
                ORDER BY S.GelisTarihi DESC";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    baglanti.Open();
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        liste.Add(new ServisDetay
                        {
                            ServisID = Convert.ToInt64(oku["ServisID"]),
                            MusteriAdSoyad = oku["MusteriAdSoyad"].ToString(),
                            CihazTuru = oku["CihazTuru"].ToString(),
                            MarkaModel = oku["MarkaModel"].ToString(),
                            Durum = oku["Durum"].ToString(),
                            GelisTarihi = Convert.ToDateTime(oku["GelisTarihi"]),
                            Ucret = Convert.ToDecimal(oku["Ucret"])
                        });
                    }
                }
            }
            catch (Exception)
            {
                // Hata olursa boş liste döner
            }
            return liste;
        }

        public void ServisDurumGuncelle(int servisID, string yeniDurum)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                // Sadece durumu güncelliyoruz
                string sorgu = "UPDATE T_SERVIS SET Durum = @p1 WHERE ServisID = @p2";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", yeniDurum);
                komut.Parameters.AddWithValue("@p2", servisID);
                komut.ExecuteNonQuery();
            }
        }

        public List<BakimMusteri> BakimListesiGetir()
        {
            List<BakimMusteri> liste = new List<BakimMusteri>();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    // SQL'in DATEDIFF fonksiyonu ile iki tarih arasındaki gün farkını hesaplatıyoruz
                    string sorgu = @"
                SELECT 
                    M.Ad + ' ' + M.Soyad AS AdSoyad,
                    M.Telefon,
                    S.CihazTuru,
                    MAX(S.GelisTarihi) as SonTarih,
                    DATEDIFF(day, MAX(S.GelisTarihi), GETDATE()) as GecenGun
                FROM T_SERVIS S
                INNER JOIN T_MUSTERI M ON S.MusteriID = M.MusteriID
                GROUP BY M.Ad, M.Soyad, M.Telefon, S.CihazTuru
                ORDER BY GecenGun DESC"; // En çok geciken en üstte çıksın

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        BakimMusteri kayit = new BakimMusteri();
                        kayit.AdSoyad = oku["AdSoyad"].ToString();
                        kayit.Telefon = oku["Telefon"].ToString();
                        kayit.Cihaz = oku["CihazTuru"].ToString();
                        kayit.SonGelisTarihi = Convert.ToDateTime(oku["SonTarih"]);
                        kayit.GecenGun = Convert.ToInt32(oku["GecenGun"]);

                        // --- RİSK ANALİZİ (KARAR MEKANİZMASI) ---
                        if (kayit.GecenGun > 365)
                            kayit.Durum = "🔴 ACİL BAKIM";
                        else if (kayit.GecenGun > 180)
                            kayit.Durum = "🟡 Yaklaşıyor";
                        else
                            kayit.Durum = "🟢 İyi Durumda";

                        liste.Add(kayit);
                    }
                }
            }
            catch { }
            return liste;
        }

        // Grafiği doldurmak için özel veri çekiyoruz (Dictionary: Anahtar-Değer ikilisi)
        public Dictionary<string, int> ArizaGrafigiGetir()
        {
            Dictionary<string, int> veriler = new Dictionary<string, int>();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    // Traktör: 5 tane, Biçerdöver: 3 tane gibi gruplayarak getir
                    string sorgu = "SELECT CihazTuru, COUNT(*) FROM T_SERVIS GROUP BY CihazTuru";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    baglanti.Open();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        veriler.Add(oku[0].ToString(), Convert.ToInt32(oku[1]));
                    }
                }
            }
            catch { }
            return veriler;
        }

        // 1. TÜM MAKİNELERİ GETİR
        public List<MakineTuru> MakineleriGetir()
        {
            List<MakineTuru> liste = new List<MakineTuru>();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM T_MAKINE_TURU", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        liste.Add(new MakineTuru
                        {
                            MakineTurID = Convert.ToInt32(oku["MakineTurID"]),
                            Ad = oku["Ad"].ToString()
                        });
                    }
                }
            }
            catch { }
            return liste;
        }

        // 2. SEÇİLEN MAKİNEYE GÖRE PARÇALARI GETİR (WHERE SORGUSU)
        public List<Parca> ParcalariGetir(int makineTurID)
        {
            List<Parca> liste = new List<Parca>();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    // Sadece seçilen makineye ait parçaları getiriyoruz
                    string sorgu = "SELECT ParcaID, ParcaAdi, BirimFiyat, StokAdet FROM T_PARCA WHERE MakineTurID = @p1";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", makineTurID);

                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        liste.Add(new Parca
                        {
                            ParcaID = Convert.ToInt32(oku["ParcaID"]),
                            ParcaAdi = oku["ParcaAdi"].ToString(),
                            BirimFiyat = Convert.ToDecimal(oku["BirimFiyat"]),
                            StokAdet = Convert.ToInt32(oku["StokAdet"])
                        });
                    }
                }
            }
            catch { }
            return liste;
        }

        public List<Usta> UstalariGetir(int parcaID)
        {
            List<Usta> liste = new List<Usta>();
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    
                    // 1. T_PARCA'dan bu parça hangi uzmanlığa giriyor (Motor mu, Elektrik mi?) bul.
                    // 2. T_USTA_UZMANLIK tablosundan o uzmanlığa sahip ustaları bul.
                    // 3. T_USTA tablosundan ustanın adını getir.

                    string sorgu = @"
                SELECT DISTINCT U.UstaID, U.AdSoyad 
                FROM T_USTA U
                INNER JOIN T_USTA_UZMANLIK UU ON U.UstaID = UU.UstaID
                INNER JOIN T_PARCA P ON P.UzmanlikID = UU.UzmanlikID
                WHERE P.ParcaID = @p1";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", parcaID);

                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        liste.Add(new Usta
                        {
                            UstaID = Convert.ToInt32(oku["UstaID"]),
                            AdSoyad = oku["AdSoyad"].ToString()
                        });
                    }
                }
            }
            catch { }
            return liste;
        }


    }
}