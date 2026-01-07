using DevExpress.XtraEditors;
using Firat.Tesys.Business;
using Firat.Tesys.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firat.Tesys.Forms
{
    public partial class FrmParcaKayit : DevExpress.XtraEditors.XtraForm
    {
        public FrmParcaKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Nesneyi oluştururken yeni verdiğimiz Name'leri kullanıyoruz
                Parca yeni = new Parca
                {
                    ParcaAdi = txtParcaAdi.Text,
                    BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text),
                    StokAdet = Convert.ToInt32(txtStokAdet.Text),
                    KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text)
                };

                SqlParcaService servis = new SqlParcaService();
                string hata = servis.ParcaEkle(yeni);

                if (hata == null)
                {
                    XtraMessageBox.Show("Parça başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Kayıt sonrası formu kapat
                }
                else
                {
                    XtraMessageBox.Show("Hata oluştu: " + hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lütfen tüm alanları doğru formatta doldurun! " + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}