using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class FrmServisListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmServisListesi()
        {
            InitializeComponent();
        }

        // FORM YÜKLENİRKEN
        private void FrmServisListesi_Load(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        // LİSTEYİ DOLDURAN METOT
        private void ListeyiGetir()
        {
            // Business katmanındaki yöneticiyi çağırıyoruz
            IServisService servisManager = new ServisManager();

            // Grid'in veri kaynağına listeyi bağlıyoruz
            gridServisler.DataSource = servisManager.ServisListesiGetir();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void durumuTamamlandıYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Tablodan seçili olan satırın 'ServisID'sini al
            var seciliDeger = gridView1.GetFocusedRowCellValue("ServisID");

            if (seciliDeger != null)
            {
                long id = Convert.ToInt64(seciliDeger);

                // 2. İşlemi yapacak yöneticiyi çağır
                IServisService manager = new ServisManager();

                // 3. Durumu güncelle
                bool sonuc = manager.ServisDurumGuncelle(id, "Tamamlandı");

                if (sonuc)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Servis durumu 'Tamamlandı' olarak güncellendi!", "Bilgi");

                    // 4. Listeyi yenile 
                    ListeyiGetir();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("İşlem başarısız oldu.", "Hata");
                }
            }
        }

        private void gridServisler_MouseUp(object sender, MouseEventArgs e)
        {
            // Sadece SAĞ TIK (Right Click) yapıldıysa çalış
            if (e.Button == MouseButtons.Right)
            {
                // Tıklanan noktanın koordinatlarını al
                var nokta = new System.Drawing.Point(e.X, e.Y);

                
                var view = gridServisler.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                var hitInfo = view.CalcHitInfo(nokta);

                
                if (hitInfo.InRow || hitInfo.InRowCell)
                {
                    // Menüyü tam fare imlecinin olduğu yerde aç
                    contextMenuStrip1.Show(gridServisler, nokta);
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Dosyası|*.xlsx"; // Sadece Excel seçebilsin

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Tabloyu Excel'e dönüştür
                gridServisler.ExportToXlsx(dialog.FileName);

                if (DevExpress.XtraEditors.XtraMessageBox.Show("Aktarım tamamlandı. Dosyayı açmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Dosyayı oluşturduktan sonra otomatik aç
                    System.Diagnostics.Process.Start(dialog.FileName);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF Dosyası|*.pdf"; // Sadece PDF seçebilsin

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Tabloyu PDF'e dönüştür
                gridServisler.ExportToPdf(dialog.FileName);

                DevExpress.XtraEditors.XtraMessageBox.Show("PDF dosyası başarıyla oluşturuldu.", "Bilgi");
            }
        }

        private void durumTamamlandıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. GridView'i (Tablonun kontrol mekanizmasını) al
            var gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridServisler.MainView;

            // 2. Eğer bir satır seçiliyse işlem yap
            if (gridView.GetFocusedRow() != null)
            {
                // Seçili satırdaki "ServisID" değerini al
                object idDegeri = gridView.GetFocusedRowCellValue("ServisID");

                if (idDegeri != null)
                {
                    int id = Convert.ToInt32(idDegeri);

                    // 3. Veritabanında durumu güncelle
                    IServisService manager = new ServisManager();
                    manager.ServisDurumGuncelle(id, "Tamamlandı");

                    // 4. Listeyi Yenile (Ekranda da değişsin)
                    ListeyiGetir();

                    // 5. Başarılı mesajı ver
                    DevExpress.XtraEditors.XtraMessageBox.Show("Servis başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}