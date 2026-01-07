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
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        // Bu metot çağrıldığı an veritabanına gider ve tüm sayıları/grafikleri tazeler
        public void VerileriGuncelle()
        {
            // 1. MANAGER'I EN TEPEDE TANIMLIYORUZ (Artık her yerden erişilebilir)
            IServisService manager = new ServisManager();

            try
            {
                // 2. KARTLARI (Sayıları) GÜNCELLE
                var istatistik = manager.DashboardIstatistikleriniGetir();
                lblToplamMusteri.Text = istatistik.ToplamMusteri.ToString();
                lblBekleyenServis.Text = istatistik.BekleyenServis.ToString();
                lblTamamlananServis.Text = istatistik.TamamlananServis.ToString();
                lblToplamKazanc.Text = istatistik.ToplamKazanc.ToString("C2");

                // 3. GRAFİĞİ GÜNCELLE
                var grafikVerileri = manager.ArizaGrafigiGetir();
                chartArizalar.Series.Clear();
                DevExpress.XtraCharts.Series seri = new DevExpress.XtraCharts.Series("Arızalar", DevExpress.XtraCharts.ViewType.Pie);
                foreach (var veri in grafikVerileri)
                {
                    seri.Points.Add(new DevExpress.XtraCharts.SeriesPoint(veri.Key, veri.Value));
                }
                chartArizalar.Series.Add(seri);
                seri.Label.TextPattern = "{A}: {V}";

                // 4. TABLOYU GÜNCELLE
                gridKritikSeviye.DataSource = manager.BakimListesiGetir();
                // (Sütun ayarlarını Tasarımcıda yaptığımız için buraya kod yazmıyoruz)
            }
            catch (Exception)
            {
                // Veritabanı hatası olursa program kapanmasın
            }

            // 5. AYIN ELEMANI (Ayrı bir hata yakalama bloğu)
            try
            {
                var sampiyon = manager.AyinElemaniniGetir();
                lblAyinElemani.Text = sampiyon.AdSoyad;
                lblIsSayisi.Text = $"{sampiyon.TamamlananIsSayisi} Tamamlanan İş";
            }
            catch { }


        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            VerileriGuncelle(); // Program açılınca çalışır
                                // Risk Analizini Çalıştır ve Tabloya Bas
            Firat.Tesys.Service.SqlMakineService makineServis = new Firat.Tesys.Service.SqlMakineService();
            grdRiskliMakineler.DataSource = makineServis.RiskliMakineleriGetir();

            // Tabloyu biraz renklendirelim (Kırmızı Alarm!)
            grdwRiskliMakineler.Appearance.Row.BackColor = System.Drawing.Color.MistyRose; // Hafif kırmızı arka plan
        }

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            VerileriGuncelle(); // Ekrana her tıklandığında veya dönüldüğünde çalışır
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            // Sadece "Durum" sütununu boyayacağız
            if (e.Column.FieldName == "Durum")
            {
                // Hücredeki değeri al
                string durum = e.CellValue?.ToString();

                if (durum != null && durum.Contains("ACİL"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Red;      // Arkaplan Kırmızı
                    e.Appearance.ForeColor = System.Drawing.Color.White;    // Yazı Beyaz
                }
                else if (durum != null && durum.Contains("Yaklaşıyor"))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Orange;   // Arkaplan Turuncu
                }
                else if (durum != null && durum.Contains("İyi"))
                {
                    e.Appearance.ForeColor = System.Drawing.Color.Green;    // Sadece yazı Yeşil olsun
                    e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, System.Drawing.FontStyle.Bold); // Kalın yap
                }
            }
        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
