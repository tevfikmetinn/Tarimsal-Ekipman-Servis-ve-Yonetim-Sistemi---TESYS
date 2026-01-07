using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Firat.Tesys.Interface; // Usta modeline ulaşmak için

namespace Firat.Tesys.Business
{
    public class SqlUstaService
    {
        
        private string baglantiCumlesi = @"Server=.\SQLEXPRESS; Database=DB_TESYS; Trusted_Connection=True; TrustServerCertificate=True;";

        public List<Usta> UstaListesiGetir()
        {
            List<Usta> liste = new List<Usta>();
            using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
            {
             
                string sql = @"SELECT u.UstaID, u.AdSoyad, 
                     (SELECT COUNT(*) FROM T_SERVIS s WHERE s.UstaID = u.UstaID) as TamamlananIsSayisi 
                     FROM T_USTA u";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Usta
                    {
                        UstaID = Convert.ToInt32(dr["UstaID"]),
                        AdSoyad = dr["AdSoyad"].ToString(),
                        TamamlananIsSayisi = Convert.ToInt32(dr["TamamlananIsSayisi"])
                    });
                }
            }
            return liste;
        }
        public string UstaEkle(Usta u)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    string sql = "INSERT INTO T_USTA (AdSoyad, TamamlananIsSayisi) VALUES (@p1, 0)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", u.AdSoyad);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
            catch (Exception ex) { return ex.Message; }
        }
        // Seçili ustanın bilgilerini günceller
        public string UstaGuncelle(Usta u)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    string sql = "UPDATE T_USTA SET AdSoyad = @p1, TamamlananIsSayisi = @p2 WHERE UstaID = @p3";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", u.AdSoyad);
                    cmd.Parameters.AddWithValue("@p2", u.TamamlananIsSayisi);
                    cmd.Parameters.AddWithValue("@p3", u.UstaID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
            catch (Exception ex) { return ex.Message; }
        }

        // Seçili ustayı veritabanından siler
        public string UstaSil(int ustaId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(baglantiCumlesi))
                {
                    string sql = "DELETE FROM T_USTA WHERE UstaID = @p1";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@p1", ustaId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return null;
                }
            }
            catch (Exception ex) { return ex.Message; }
        }
    }
}