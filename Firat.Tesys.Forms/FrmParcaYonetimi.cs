using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Firat.Tesys.Business; // SqlParcaService hangi klasördeyse onu yaz
using Firat.Tesys.Interface; // Parca modeline ulaşmak için

namespace Firat.Tesys.Forms
{
    public partial class FrmParcaYonetimi : DevExpress.XtraEditors.XtraForm
    {
        public FrmParcaYonetimi()
        {
            InitializeComponent();
        }

        // Form açıldığında verileri yükle
        private void FrmParcaYonetimi_Load(object sender, EventArgs e)
        {
            ParcaListele();
        }

        public void ParcaListele()
        {
            try
            {
                SqlParcaService servis = new SqlParcaService();

                // DİKKAT: Tasarımda GridControl'e verdiğin isim 'grdParcaListesi' olmalı
                grdParcaListesi.DataSource = servis.ParcaListesiGetir();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            FrmParcaKayit frm = new FrmParcaKayit();

            
            frm.ShowDialog();

            
            ParcaListele();
        }

        private void btnParcaSil_Click(object sender, EventArgs e)
        {
            var seciliParca = gvParcalar.GetFocusedRow() as Parca;

            if (seciliParca != null)
            {
                DialogResult onay = XtraMessageBox.Show($"{seciliParca.ParcaAdi} isimli parçayı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    // Buraya SqlParcaService üzerinden Silme metodu gelecek
                    XtraMessageBox.Show("Parça başarıyla silindi.");
                    ParcaListele();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Parca seciliParca = gvParcalar.GetFocusedRow() as Parca;

            if (seciliParca != null)
            {
                // 2. Servisimizi çağırıyoruz
                SqlParcaService servis = new SqlParcaService();
                string sonuc = servis.ParcaGuncelle(seciliParca);

                // 3. Kontrol ediyoruz
                if (sonuc == null)
                {
                    XtraMessageBox.Show("Değişiklikler başarıyla kaydedildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ParcaListele(); // Tabloyu yeniliyoruz
                }
                else
                {
                    XtraMessageBox.Show("Güncelleme sırasında hata oluştu: " + sonuc, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}