using DevExpress.XtraEditors;
using Firat.Tesys.Business;
using Firat.Tesys.Interface;
using Firat.Tesys.Service;
using System;
using System.Windows.Forms;

namespace Firat.Tesys.Forms
{
    public partial class FrmMusteriTanim : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriTanim()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Empty;
        }

        // FORM YÜKLENİRKEN LİSTEYİ GETİR
        private void FrmMusteriTanim_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        // LİSTEYİ YENİLEMEK İÇİN YARDIMCI METOT
        private void ListeyiYenile()
        {
            IMusteriService servis = new MusteriManager();
            gridMusteriler.DataSource = servis.MusteriListele();
        }

        // 1. KAYDET BUTONU
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.Ad = txtAd.Text;
            yeniMusteri.Soyad = txtSoyad.Text;

            if (!string.IsNullOrEmpty(txtSicilNo.Text))
                yeniMusteri.SicilNo = Convert.ToInt64(txtSicilNo.Text);

            IMusteriService musteriYoneticisi = new MusteriManager();
            bool sonuc = musteriYoneticisi.MusteriKaydet(yeniMusteri);

            if (sonuc)
            {
                XtraMessageBox.Show("Müşteri başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeyiYenile();
            }
            else
            {
                XtraMessageBox.Show("Hata: Ad ve Soyad alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. SİL BUTONU
        private void btnSil_Click(object sender, EventArgs e)
        {
            var seciliID = gridView1.GetFocusedRowCellValue("MusteriID");

            if (seciliID != null)
            {
                if (XtraMessageBox.Show("Seçili kaydı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    long id = Convert.ToInt64(seciliID);
                    IMusteriService servis = new MusteriManager();
                    if (servis.MusteriSil(id))
                    {
                        XtraMessageBox.Show("Kayıt silindi.", "Bilgi");
                        ListeyiYenile();
                    }
                }
            }
        }

        // 3. TABLOYA TIKLAYINCA BİLGİLERİ GETİRME
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var seciliKayit = gridView1.GetFocusedRow() as Firat.Tesys.Interface.Musteri;
            if (seciliKayit != null)
            {
                txtAd.Text = seciliKayit.Ad;
                txtSoyad.Text = seciliKayit.Soyad;
                txtSicilNo.Text = seciliKayit.SicilNo.ToString();
            }
            MakineleriListele();
        }

        void MakineleriListele()
        {
            // Eğer müşteri seçili değilse dur
            if (gridView1.GetFocusedRow() == null) return;

            // Seçili müşterinin ID'sini al (Senin kolon adın 'MusteriID' olmalı)
            long id = Convert.ToInt64(gridView1.GetFocusedRowCellValue("MusteriID"));

            // Veritabanından o müşterinin makinelerini çek
            IMakineService servis = new SqlMakineService();
            grdMakineler.DataSource = servis.MusteriMakineleriniGetir(id);
        }

        // 4. GÜNCELLE BUTONU
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var seciliID = gridView1.GetFocusedRowCellValue("MusteriID");

            if (seciliID != null)
            {
                long id = Convert.ToInt64(seciliID);

                Musteri guncelMusteri = new Musteri();
                guncelMusteri.MusteriID = id;
                guncelMusteri.Ad = txtAd.Text;
                guncelMusteri.Soyad = txtSoyad.Text;

                if (!string.IsNullOrEmpty(txtSicilNo.Text))
                    guncelMusteri.SicilNo = Convert.ToInt64(txtSicilNo.Text);

                IMusteriService servis = new MusteriManager();
                if (servis.MusteriGuncelle(guncelMusteri))
                {
                    XtraMessageBox.Show("Bilgiler güncellendi!", "Bilgi");
                    ListeyiYenile();
                }
                else
                {
                    XtraMessageBox.Show("Güncelleme başarısız. İsimleri kontrol ediniz.", "Hata");
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen listeden bir kayıt seçiniz.", "Uyarı");
            }
        }

        private void btnMakineEkle_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null) return;

            long id = Convert.ToInt64(gridView1.GetFocusedRowCellValue("MusteriID"));

            // Formu aç
            FrmMakineTanim frm = new FrmMakineTanim(id);
            frm.ShowDialog();

            // Kapanınca listeyi tazele
            MakineleriListele();
        }
    }
}