using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient; // SQL kütüphanesi

namespace Firat.Tesys.Forms
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // GİRİŞ BUTONU
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. Bağlantı Cümlesi 
            string baglantiAdresi = @"Server=.\SQLEXPRESS; Database=DB_TESYS; Trusted_Connection=True; TrustServerCertificate=True;";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
                {
                    baglanti.Open();

                    // 2. SQL Sorgusu: Bu kullanıcı adı ve şifreye sahip biri var mı?
                    string sorgu = "SELECT COUNT(*) FROM T_ADMIN WHERE KullaniciAdi=@p1 AND Sifre=@p2";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                    // 3. Sonucu Kontrol Et (1 ise var, 0 ise yok)
                    int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        // GİRİŞ BAŞARILI!
                        FrmAnaMenu anaMenu = new FrmAnaMenu();
                        anaMenu.Show(); // Ana menüyü aç
                        this.Hide();    // Giriş ekranını gizle
                    }
                    else
                    {
                        // HATA
                        XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Kritik Hata");
            }
        }

        // ÇIKIŞ (X) BUTONU
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programı tamamen kapat
        }
    }
}