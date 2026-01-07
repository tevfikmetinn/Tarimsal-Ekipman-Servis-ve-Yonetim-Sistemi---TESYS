using DevExpress.XtraEditors;
using Firat.Tesys.Business; 
using Firat.Tesys.Interface; 
using System;
using System.Windows.Forms;

namespace Firat.Tesys.Forms
{
    public partial class FrmServisKayit : DevExpress.XtraEditors.XtraForm
    {
        long _seciliMakineID = 0; // Seçilen makinenin kimliğini burada tutacağız
        public FrmServisKayit()
        {
            InitializeComponent();
        }

        
        private void FrmServisKayit_Load(object sender, EventArgs e)
        {
            // 1. Makine Türlerini Doldur
            IServisService manager = new ServisManager();
            var makineler = manager.MakineleriGetir();

            // LookUpEdit Ayarları (Görünen: Ad, Arkadaki Değer: ID)
            lkpMakineTur.Properties.DataSource = makineler;
            lkpMakineTur.Properties.DisplayMember = "Ad";
            lkpMakineTur.Properties.ValueMember = "MakineTurID";

            // Parça kutusu şimdilik kapalı kalsın
            lkpParca.Enabled = false;


            IMusteriService servis = new MusteriManager();
            var musteriListesi = servis.MusteriListele();

            
            lkpMusteri.Properties.DataSource = musteriListesi; 
            lkpMusteri.Properties.DisplayMember = "Ad"; 
            lkpMusteri.Properties.ValueMember = "MusteriID"; 

            
            lkpMusteri.Properties.PopulateColumns(); 
            lkpMusteri.Properties.Columns["MusteriID"].Visible = false; 
            lkpMusteri.Properties.Columns["SicilNo"].Visible = false;
            lkpMusteri.Properties.Columns["Adres"].Visible = false;
            lkpMusteri.Properties.Columns["Telefon"].Visible = false;
        }

        
        private void btnServisKaydet_Click(object sender, EventArgs e)
        {

            // 1. Boş Alan Kontrolü (Basit Validasyon)
            if (lkpMusteri.EditValue == null || lkpMakineTur.EditValue == null || lkpParca.EditValue == null || lkpUsta.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Müşteri, Makine ve Parça seçimlerini yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Verileri Topla
            Servis yeniKayit = new Servis();
            
            yeniKayit.MakineID = _seciliMakineID; // <-- BU SATIRI EKLE (Çok Önemli)
            yeniKayit.MusteriID = Convert.ToInt64(lkpMusteri.EditValue);
            yeniKayit.MusteriID = Convert.ToInt64(lkpMusteri.EditValue);

            
            yeniKayit.CihazTuru = lkpMakineTur.Text;

            yeniKayit.Marka = txtMarka.Text;
            yeniKayit.Model = txtModel.Text;
            yeniKayit.GelisTarihi = Convert.ToDateTime(dateGelisTarihi.EditValue); // Veya DateTime.Now
            yeniKayit.ArizaAciklama = txtArizaAciklama.Text;

            // --- YENİ ALANLAR ---
            yeniKayit.ParcaID = Convert.ToInt32(lkpParca.EditValue);
            yeniKayit.UstaID = Convert.ToInt32(lkpUsta.EditValue);

            // Fiyatları sayıya çevir (Boşsa 0 kabul et)
            decimal pUcret = 0, iUcret = 0;
            decimal.TryParse(txtParcaFiyat.Text, out pUcret); // 450,00 TL gibi metinleri sayıya çevirir
            decimal.TryParse(txtIscilikFiyat.Text, out iUcret);

            yeniKayit.ParcaUcreti = pUcret;
            yeniKayit.IscilikUcreti = iUcret;

            // 3. Kaydetmeye Gönder
            IServisService manager = new ServisManager();
            bool sonuc = manager.ArizaKaydiOlustur(yeniKayit);

            if (sonuc)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Arıza kaydı açıldı ve parça stoktan düşüldü!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
        private void ToplamHesapla()
        {
            decimal parca = 0;
            decimal iscilik = 0;

            decimal.TryParse(txtParcaFiyat.Text, out parca);
            decimal.TryParse(txtIscilikFiyat.Text, out iscilik);

            txtToplamFiyat.Text = (parca + iscilik).ToString("C2"); // Para birimi olarak yaz
        }

        private void lkpMakineTur_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpMakineTur.EditValue != null)
            {
                int secilenMakineID = Convert.ToInt32(lkpMakineTur.EditValue);

                // 2. Seçilen makineye göre parçaları getir
                IServisService manager = new ServisManager();
                var parcalar = manager.ParcalariGetir(secilenMakineID);

                lkpParca.Properties.DataSource = parcalar;
                lkpParca.Properties.DisplayMember = "ParcaAdi"; // Ekranda adı görünsün
                lkpParca.Properties.ValueMember = "ParcaID";   // Arkada ID tutulsun
                lkpParca.Properties.Columns.Clear();
                lkpParca.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ParcaAdi", "Parça Adı", 100));
                lkpParca.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StokAdet", "Stok", 30));
                lkpParca.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimFiyat", "Fiyat", 40));

                // Parça kutusunu aktif et
                lkpParca.Enabled = true;
            }
        }

        private void lkpParca_EditValueChanged(object sender, EventArgs e)
        {
            if (lkpParca.EditValue != null)
            {
                // Seçilen parçanın nesnesini al (Fiyatını bulmak için)
                // LookUpEdit'in 'GetDataSourceRowByKeyValue' metodu satırı getirir
                var secilenParca = lkpParca.GetSelectedDataRow() as Parca;

                // (Eğer yukarıdaki satır çalışmazsa alternatif yöntem aşağıdadır, önce bunu dene)
                // DevExpress LookUpEdit bazen nesneyi direkt vermez, ID verir.
                // O yüzden en garantisi ID'den tekrar bulmaktır ama şimdilik şunu deneyelim:

                object row = lkpParca.Properties.GetDataSourceRowByKeyValue(lkpParca.EditValue);
                if (row is Parca p)
                {
                    txtParcaFiyat.Text = p.BirimFiyat.ToString();
                    ToplamHesapla(); // Aşağıdaki metodu çağır
                }
            }
            // --- 3. GÖREV: AKILLI USTA FİLTRELEME ---
            // Seçilen parçanın ID'sini al
            int secilenParcaID = Convert.ToInt32(lkpParca.EditValue);

            IServisService manager = new ServisManager();

            // Sadece bu parçanın uzmanlık alanına giren ustaları getir
            var uygunUstalar = manager.UstalariGetir(secilenParcaID);

            // Listeyi kutuya doldur
            lkpUsta.Properties.DataSource = uygunUstalar;
            lkpUsta.Properties.DisplayMember = "AdSoyad"; // Ekranda ismi görünsün
            lkpUsta.Properties.ValueMember = "UstaID";   // Arkada ID tutulsun

            // Kutuyu aktifleştir ve temizle
            lkpUsta.Enabled = true;
            lkpUsta.EditValue = null; // Eski seçimi temizle ki yanlış usta kalmasın
        }

        private void txtIscilikFiyat_EditValueChanged(object sender, EventArgs e)
        {
            ToplamHesapla(); // Az önce aşağıya yapıştırdığımız o metodu çağır
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkpMusteri_EditValueChanged(object sender, EventArgs e)
        {
            // 1. Önce temizlik
            cmbMusteriMakineleri.Properties.Items.Clear();
            cmbMusteriMakineleri.Text = "";
            _seciliMakineID = 0;

            // 2. Müşteri ID'sini al
            if (lkpMusteri.EditValue == null) return;
            long musteriId = Convert.ToInt64(lkpMusteri.EditValue);

            // 3. Veritabanından makineleri çek
            Firat.Tesys.Service.SqlMakineService makineServis = new Firat.Tesys.Service.SqlMakineService();
            var makineler = makineServis.MusteriMakineleriniGetir(musteriId);

            // 4. ComboBox'a doldur
            foreach (var m in makineler)
            {
                // Görünen Yazı: "Traktör - New Holland (TD 110)"
                string gorunen = m.CihazTuru + " - " + m.Marka + " (" + m.Model + ")";
                cmbMusteriMakineleri.Properties.Items.Add(gorunen);
            }
        }

        private void cmbMusteriMakineleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbMusteriMakineleri.SelectedIndex;
            if (index == -1) return;

            // Veriyi tekrar çekip doğru makineyi buluyoruz
            long musteriId = Convert.ToInt64(lkpMusteri.EditValue);
            Firat.Tesys.Service.SqlMakineService makineServis = new Firat.Tesys.Service.SqlMakineService();
            var makineler = makineServis.MusteriMakineleriniGetir(musteriId);

            // Listeden seçilen sıradaki makineyi al
            var secilenMakine = makineler[index];

            // --- OTOMATİK DOLDURMA ---
            txtMarka.Text = secilenMakine.Marka;
            txtModel.Text = secilenMakine.Model;

            // Eğer 'Cihaz Türü' kutusu (lkpMakineTur) bir ComboBox ise Text'ini ayarla, 
            // LookUpEdit ise EditValue ile ID'sini bulman gerekebilir. 
            // Şimdilik sadece Text'i deneyelim (Hata verirse burayı yoruma al):
            lkpMakineTur.Text = secilenMakine.CihazTuru;

            // ID'yi hafızaya al
            _seciliMakineID = secilenMakine.MakineID;
        }
    }
}