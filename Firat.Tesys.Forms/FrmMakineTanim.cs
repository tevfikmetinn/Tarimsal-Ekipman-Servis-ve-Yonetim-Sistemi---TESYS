using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firat.Tesys.Interface;
using Firat.Tesys.Service;

namespace Firat.Tesys.Forms
{
    public partial class FrmMakineTanim : DevExpress.XtraEditors.XtraForm
    {
        private long _musteriId; // Bu makine kime eklenecek?

        public FrmMakineTanim(long musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;

            // 1. Cihaz Türlerini Yükle (Sabit Liste)
            cmbCihazTuru.Properties.Items.AddRange(new string[] {
                "Traktör", "Biçerdöver", "Balya Makinesi", "Ekim Makinesi", "Pulluk", "Pülverizatör", "Römork"
            });

            // 2. Yılları Yükle (1980 - 2026)
            for (int i = 2026; i >= 1980; i--)
                cmbUretimYili.Properties.Items.Add(i.ToString());

            // Olayı (Event) Tanımla: Cihaz türü değişirse ne olsun?
            cmbCihazTuru.SelectedIndexChanged += CihazTuru_Degisti;
        }

        // Cihaza Göre Marka Getirme
        private void CihazTuru_Degisti(object sender, EventArgs e)
        {
            cmbMarka.Properties.Items.Clear(); // Önceki markaları temizle
            cmbMarka.Text = ""; // Seçimi sıfırla

            string secim = cmbCihazTuru.Text;

            if (secim == "Traktör")
                cmbMarka.Properties.Items.AddRange(new string[] { "New Holland", "Deutz Fahr", "Başak", "Hattat", "John Deere" });

            else if (secim == "Biçerdöver")
                cmbMarka.Properties.Items.AddRange(new string[] { "New Holland", "Claas", "John Deere", "Fendt", "Deutz Fahr" });

            else if (secim == "Balya Makinesi")
                cmbMarka.Properties.Items.AddRange(new string[] { "New Holland", "Eryiğit", "MT Makina", "Başak", "Mofem" });

            else if (secim == "Ekim Makinesi")
                cmbMarka.Properties.Items.AddRange(new string[] { "New Holland", "Başak", "Rottman", "Bacca", "Agrimerin" });

            else if (secim == "Pulluk")
                cmbMarka.Properties.Items.AddRange(new string[] { "Kverneland", "Lemken", "Alpler", "Türkay", "Ünlü" });

            else if (secim == "Pülverizatör")
                cmbMarka.Properties.Items.AddRange(new string[] { "BARTECH", "Orac", "Palmera" });

            else if (secim == "Römork")
                cmbMarka.Properties.Items.AddRange(new string[] { "Çetiner", "HAKSAN", "Ziraat", "BRANTNER" });
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Basit Doğrulama
            if (string.IsNullOrEmpty(cmbCihazTuru.Text) || string.IsNullOrEmpty(cmbMarka.Text))
            {
                MessageBox.Show("Lütfen cihaz türü ve markasını seçiniz.");
                return;
            }

            // Makine Nesnesi Oluştur
            Makine yeniMakine = new Makine();
            yeniMakine.MusteriID = _musteriId;
            yeniMakine.CihazTuru = cmbCihazTuru.Text;
            yeniMakine.Marka = cmbMarka.Text;
            yeniMakine.Model = txtModel.Text;
            yeniMakine.SeriNo = txtSeriNo.Text;
            yeniMakine.UretimYili = cmbUretimYili.Text == "" ? 0 : Convert.ToInt32(cmbUretimYili.Text);

            // Servise Gönder
            IMakineService servis = new SqlMakineService();
            string sonuc = servis.MakineEkle(yeniMakine);

            if (sonuc == null)
            {
                MessageBox.Show("Makine başarıyla eklendi! 🚜");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata: " + sonuc);
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            // 1. Basit Doğrulama: Boş mu?
            if (string.IsNullOrEmpty(cmbCihazTuru.Text) || string.IsNullOrEmpty(cmbMarka.Text))
            {
                MessageBox.Show("Lütfen cihaz türü ve markasını seçiniz.");
                return;
            }

            // 2. Makine Nesnesi Oluştur
            Makine yeniMakine = new Makine();
            yeniMakine.MusteriID = _musteriId; // Form açılırken aldığımız müşteri ID'si
            yeniMakine.CihazTuru = cmbCihazTuru.Text;
            yeniMakine.Marka = cmbMarka.Text;
            yeniMakine.Model = txtModel.Text;
            yeniMakine.SeriNo = txtSeriNo.Text;

            // Yıl seçilmediyse 0 yap, yoksa seçilen yılı al
            yeniMakine.UretimYili = string.IsNullOrEmpty(cmbUretimYili.Text) ? 0 : Convert.ToInt32(cmbUretimYili.Text);
            yeniMakine.KayitTarihi = DateTime.Now;
            // 3. Servise Gönder (Veritabanına Kayıt)
            IMakineService servis = new SqlMakineService();
            string sonuc = servis.MakineEkle(yeniMakine);

            // 4. Sonuç Kontrolü
            if (sonuc == null)
            {
                MessageBox.Show("Makine başarıyla eklendi! 🚜", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // İşlem bitince formu kapat
            }
            else
            {
                MessageBox.Show("Hata oluştu: " + sonuc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}