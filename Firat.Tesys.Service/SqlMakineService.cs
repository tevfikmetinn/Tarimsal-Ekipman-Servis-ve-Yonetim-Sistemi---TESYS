using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Firat.Tesys.Interface; // Interface'i görmesi için

namespace Firat.Tesys.Service
{
    public class SqlMakineService : IMakineService
    {
        
        private string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DB_TESYS; Trusted_Connection=True; TrustServerCertificate=True;";

        // 1. MAKİNE KAYDETME METODU
        public string MakineEkle(Makine m)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    // SADECE KayitTarihi sütununu ve @p7 parametresini ekledik
                    string sql = @"INSERT INTO T_MAKINE (MusteriID, CihazTuru, Marka, Model, SeriNo, UretimYili, KayitTarihi) 
                           VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", m.MusteriID);
                    cmd.Parameters.AddWithValue("@p2", m.CihazTuru);
                    cmd.Parameters.AddWithValue("@p3", m.Marka);
                    cmd.Parameters.AddWithValue("@p4", m.Model);
                    cmd.Parameters.AddWithValue("@p5", m.SeriNo);
                    cmd.Parameters.AddWithValue("@p6", m.UretimYili);

                    // YENİ SATIR: Formdan gelen tarihi veritabanına gönderiyoruz
                    cmd.Parameters.AddWithValue("@p7", m.KayitTarihi);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // 2. MÜŞTERİNİN MAKİNELERİNİ LİSTELEME
        public List<Makine> MusteriMakineleriniGetir(long musteriId)
        {
            List<Makine> liste = new List<Makine>();
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    string sql = "SELECT * FROM T_MAKINE WHERE MusteriID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", musteriId);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Makine m = new Makine();
                        m.MakineID = Convert.ToInt64(dr["MakineID"]);
                        m.MusteriID = Convert.ToInt64(dr["MusteriID"]);
                        m.CihazTuru = dr["CihazTuru"].ToString();
                        m.Marka = dr["Marka"].ToString();
                        m.Model = dr["Model"].ToString();
                        m.SeriNo = dr["SeriNo"].ToString();
                        m.UretimYili = Convert.ToInt32(dr["UretimYili"]);

                        // YENİ SATIR: Veritabanındaki tarihi alıp nesneye aktarıyoruz
                        // dr["KayitTarihi"] boş bile olsa DateTime varsayılan değerini alır, sistem çökmez.
                        m.KayitTarihi = dr["KayitTarihi"] != DBNull.Value ? Convert.ToDateTime(dr["KayitTarihi"]) : DateTime.Now;

                        m.Durum = MakineDurumAnalizi(m.MakineID);
                        liste.Add(m);
                    }
                }
            }
            catch { /* Hata olursa boş liste döner */ }
            return liste;
        }


        // Makinenin servis geçmişine bakıp durumunu söyler
        public string MakineDurumAnalizi(long makineId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    // Bu makine en son ne zaman servise geldi?
                    string sql = "SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", makineId);
                    conn.Open();

                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != DBNull.Value && sonuc != null)
                    {
                        DateTime sonServis = Convert.ToDateTime(sonuc);
                        TimeSpan fark = DateTime.Now - sonServis;

                        // Analiz Mantığı: 365 günü geçtiyse KIRMIZI ALARM
                        if (fark.TotalDays > 365)
                            return "KRİTİK: Bakım Geçmiş! (" + (int)fark.TotalDays + " gün)";
                        else if (fark.TotalDays > 300)
                            return "DİKKAT: Bakım Yaklaşıyor";
                        else
                            return "İYİ: Sorun Görünmüyor";
                    }
                    else
                    {
                        return "BİLGİ: Hiç Servis Kaydı Yok";
                    }
                }
            }
            catch
            {
                return "Analiz Hatası";
            }
        }
        // 🔥 DASHBOARD İÇİN ÖZEL ANALİZ METODU 🔥
        public System.Data.DataTable RiskliMakineleriGetir()
        {
            System.Data.DataTable tablo = new System.Data.DataTable();

            using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
            {
                // SQL ANALİZ MOTORU
                // 1. Kural: 2026 yılından üretim yılını çıkarıp YAŞ PUANI veriyoruz (Yaş * 2 Puan)
                // 2. Kural: Son servisten geçen AY sayısını alıp İHMAL PUANI veriyoruz (Ay * 5 Puan)
                // 3. Kural: Hiç servise gelmediyse direkt 999 Puan verip en üste koyuyoruz.

                string sql = @"
                    SELECT TOP 15
                        M.Ad + ' ' + M.Soyad AS Musteri,
                        K.CihazTuru + ' - ' + K.Marka AS Makine,
                        
                        -- Bilgi Amaçlı Sütunlar
                        (2026 - K.UretimYili) AS Yas,
                        ISNULL(DATEDIFF(DAY, (SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = K.MakineID), GETDATE()), 0) AS GunFarki,

                        -- DURUM KARAR MEKANİZMASI (CASE WHEN)
                        CASE 
                            -- Hiç kaydı yoksa
                            WHEN (SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = K.MakineID) IS NULL 
                                THEN '⚠️ RİSKLİ (HİÇ BAKIM YOK)'
                            
                            -- Puan > 80 ise (Çok eski veya çok ihmal edilmiş)
                            WHEN (
                                    ((2026 - K.UretimYili) * 2) + 
                                    (DATEDIFF(MONTH, (SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = K.MakineID), GETDATE()) * 5)
                                 ) > 80 
                                THEN '🔴 KRİTİK (REVİZYON ŞART)'

                            -- Puan > 40 ise
                            WHEN (
                                    ((2026 - K.UretimYili) * 2) + 
                                    (DATEDIFF(MONTH, (SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = K.MakineID), GETDATE()) * 5)
                                 ) > 40 
                                THEN '🟡 DİKKAT (BAKIM ZAMANI)'

                            -- Diğerleri
                            ELSE '🟢 İYİ DURUMDA'
                        END AS Durum

                    FROM T_MAKINE K
                    INNER JOIN T_MUSTERI M ON K.MusteriID = M.MusteriID
                    
                    -- SIRALAMA: En yüksek riskliler en üstte
                    ORDER BY 
                        CASE 
                            WHEN (SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = K.MakineID) IS NULL THEN 1000
                            ELSE ((2026 - K.UretimYili) * 2) + (DATEDIFF(MONTH, (SELECT MAX(GelisTarihi) FROM T_SERVIS WHERE MakineID = K.MakineID), GETDATE()) * 5)
                        END DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(tablo);
            }
            return tablo;
        }
    }
}
