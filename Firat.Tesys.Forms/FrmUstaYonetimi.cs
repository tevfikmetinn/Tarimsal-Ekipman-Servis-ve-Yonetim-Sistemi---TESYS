using DevExpress.XtraEditors;
using Firat.Tesys.Business; 
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

namespace Firat.Tesys.Forms
{
    public partial class FrmUstaYonetimi : DevExpress.XtraEditors.XtraForm
    {
        public FrmUstaYonetimi()
        {
            InitializeComponent();
        }

        // Form açıldığında liste otomatik yüklensin
        private void FrmUstaYonetimi_Load(object sender, EventArgs e)
        {
            UstaListele();
        }

        public void UstaListele()
        {
            try
            {
                SqlUstaService servis = new SqlUstaService();
                // Tasarımda GridControl'e verdiğin ismin 'grdUstaListesi' olduğundan emin ol
                grdUstaListesi.DataSource = servis.UstaListesiGetir();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Usta listesi yüklenirken hata: " + ex.Message);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Usta seciliUsta = gvUstalar.GetFocusedRow() as Usta;

            if (seciliUsta != null)
            {
                SqlUstaService servis = new SqlUstaService();
                string sonuc = servis.UstaGuncelle(seciliUsta);

                if (sonuc == null)
                {
                    XtraMessageBox.Show("Usta bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UstaListele();
                }
                else
                {
                    XtraMessageBox.Show("Hata: " + sonuc, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUstaSil_Click(object sender, EventArgs e)
        {
            Usta seciliUsta = gvUstalar.GetFocusedRow() as Usta;

            if (seciliUsta != null)
            {
                DialogResult onay = XtraMessageBox.Show($"{seciliUsta.AdSoyad} isimli ustayı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    SqlUstaService servis = new SqlUstaService();
                    string sonuc = servis.UstaSil(seciliUsta.UstaID);

                    if (sonuc == null)
                    {
                        XtraMessageBox.Show("Usta başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UstaListele();
                    }
                    else
                    {
                        XtraMessageBox.Show("Hata: " + sonuc, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUstaEkle_Click(object sender, EventArgs e)
        {
            FrmUstaKayit frm = new FrmUstaKayit();
            frm.ShowDialog();
            UstaListele(); // Liste otomatik yenilensin
        }
    }
}