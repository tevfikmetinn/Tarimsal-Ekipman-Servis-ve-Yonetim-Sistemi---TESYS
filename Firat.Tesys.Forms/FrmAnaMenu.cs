using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Firat.Tesys.Forms
{
    public partial class FrmAnaMenu : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            FrmDashboard frm = new FrmDashboard();
            frm.MdiParent = this;
            frm.Show();
        }

        // YARDIMCI METOT: Form zaten açıksa tekrar açma, öne getir
        private void FormGetir(Form form)
        {
            form.MdiParent = this; 
            form.Show(); // Göster
        }

        // 1. MÜŞTERİ TANIMLAMA BUTONU
        private void btnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Yeni bir müşteri formu oluştur ve aç
            FrmMusteriTanim frm = new FrmMusteriTanim();
            FormGetir(frm);
        }

        // 2. ARIZA KAYIT BUTONU
        private void btnArizaKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Yeni bir servis formu oluştur ve aç
            FrmServisKayit frm = new FrmServisKayit();
            FormGetir(frm);
        }

        private void btnServisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Listeleme formunu oluştur ve ana ekranın içinde aç
            FrmServisListesi frm = new FrmServisListesi();
            frm.MdiParent = this; // Ana menünün çocuğu ol
            frm.Show();
        }

        private void btnTemaDegistir_Click(object sender, EventArgs e)
        {
            var suankiPalet = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSvgPaletteName;

            // Eğer şu an Koyu ise -> AÇIK (Bembeyaz) Yap
            if (suankiPalet.Contains("Dark"))
            {
                // "Calmness" paleti en temiz beyazı verir
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI", "Calmness");
                btnTemaDegistir.Text = "Koyu Mod";
            }
            // Değilse -> KOYU Yap
            else
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI", "Darkness");
                btnTemaDegistir.Text = "Açık Mod";
            }
        }

        private void btnParcaTanimlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmParcaYonetimi frm = new FrmParcaYonetimi();
            frm.MdiParent = this; // Ana menünün içinde açılmasını sağlar
            frm.Show();
        }

        private void btnUstaTanimlama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUstaYonetimi frm = new FrmUstaYonetimi();
            frm.MdiParent = this; // Ana menüye hapseder
            frm.Show();
        }
    }
}

