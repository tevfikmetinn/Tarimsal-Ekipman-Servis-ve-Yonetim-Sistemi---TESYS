using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Firat.Tesys.Interface; // Parca modelinin olduğu yer

namespace Firat.Tesys.Business // Eğer klasör adın 'Service' ise burayı '.Service' yap
{
    public class SqlParcaService
    {
        
        private string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DB_TESYS; Trusted_Connection=True; TrustServerCertificate=True;";

        public List<Parca> ParcaListesiGetir()
        {
            List<Parca> liste = new List<Parca>();
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    // T_PARCA tablonun sütun isimleri: ParcaID, ParcaAdi, BirimFiyat, StokAdet
                    string sql = "SELECT * FROM T_PARCA";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        liste.Add(new Parca
                        {
                            ParcaID = Convert.ToInt32(dr["ParcaID"]),
                            ParcaAdi = dr["ParcaAdi"].ToString(),
                            BirimFiyat = Convert.ToDecimal(dr["BirimFiyat"]),
                            StokAdet = Convert.ToInt32(dr["StokAdet"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Parça listesi çekilirken hata oluştu: " + ex.Message);
            }
            return liste;
        }
        public string ParcaGuncelle(Parca p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    // SQL Sorgusu: ID'ye göre diğer tüm alanları güncelliyoruz
                    string sql = @"UPDATE T_PARCA SET 
                           ParcaAdi = @p1, 
                           BirimFiyat = @p2, 
                           StokAdet = @p3, 
                           KritikSeviye = @p4 
                           WHERE ParcaID = @p5";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", p.ParcaAdi);
                    cmd.Parameters.AddWithValue("@p2", p.BirimFiyat);
                    cmd.Parameters.AddWithValue("@p3", p.StokAdet);
                    cmd.Parameters.AddWithValue("@p4", p.KritikSeviye);
                    cmd.Parameters.AddWithValue("@p5", p.ParcaID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return null; // Hata yoksa null döner
                }
            }
            catch (Exception ex)
            {
                return ex.Message; // Hata varsa mesajı döner
            }
        }
        public string ParcaEkle(Parca p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    string sql = @"INSERT INTO T_PARCA (ParcaAdi, BirimFiyat, StokAdet, KritikSeviye) 
                           VALUES (@p1, @p2, @p3, @p4)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", p.ParcaAdi);
                    cmd.Parameters.AddWithValue("@p2", p.BirimFiyat);
                    cmd.Parameters.AddWithValue("@p3", p.StokAdet);
                    cmd.Parameters.AddWithValue("@p4", p.KritikSeviye);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return null; // Başarılı
                }
            }
            catch (Exception ex)
            {
                return ex.Message; // Hata mesajını döndür
            }
        }
    }
}