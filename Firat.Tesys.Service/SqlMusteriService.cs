using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; 
using Firat.Tesys.Interface; 

namespace Firat.Tesys.Service
{
   
    public class SqlMusteriService : IMusteriService
    {
        
        private string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DB_TESYS; Trusted_Connection=True; TrustServerCertificate=True;";

        // 1. KAYDETME İŞLEMİ
        public bool MusteriKaydet(Musteri yeniMusteri)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string sorgu = "INSERT INTO T_MUSTERI (SicilNo, Ad, Soyad) VALUES (@p1, @p2, @p3)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    // SQL Injection önlemi ve veri tiplerinin eşleştirilmesi
                    komut.Parameters.AddWithValue("@p1", yeniMusteri.SicilNo);
                    komut.Parameters.AddWithValue("@p2", yeniMusteri.Ad);
                    komut.Parameters.AddWithValue("@p3", yeniMusteri.Soyad);

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
        public bool MusteriSil(long musteriID)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string sorgu = "DELETE FROM T_MUSTERI WHERE MusteriID = @id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", musteriID);

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
        public bool MusteriGuncelle(Musteri guncellenecekMusteri)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    
                    string sorgu = "UPDATE T_MUSTERI SET Ad=@p1, Soyad=@p2, SicilNo=@p3 WHERE MusteriID=@id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", guncellenecekMusteri.Ad);
                    komut.Parameters.AddWithValue("@p2", guncellenecekMusteri.Soyad);
                    komut.Parameters.AddWithValue("@p3", guncellenecekMusteri.SicilNo);
                    komut.Parameters.AddWithValue("@id", guncellenecekMusteri.MusteriID); 

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

        // 2. LİSTELEME İŞLEMİ 
        public List<Musteri> MusteriListele()
        {
            List<Musteri> musteriler = new List<Musteri>();

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string sorgu = "SELECT MusteriID, SicilNo, Ad, Soyad FROM T_MUSTERI";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    baglanti.Open();
                    SqlDataReader oku = komut.ExecuteReader();

                    // Veritabanındaki her satırı tek tek oku ve listeye ekle
                    while (oku.Read())
                    {
                        Musteri m = new Musteri
                        {
                            MusteriID = Convert.ToInt64(oku["MusteriID"]),
                            SicilNo = Convert.ToInt64(oku["SicilNo"]),
                            Ad = oku["Ad"].ToString(),
                            Soyad = oku["Soyad"].ToString()
                        };
                        musteriler.Add(m);
                    }
                }
            }
            catch (Exception)
            {
                
            }

            return musteriler;
        }
    }
}