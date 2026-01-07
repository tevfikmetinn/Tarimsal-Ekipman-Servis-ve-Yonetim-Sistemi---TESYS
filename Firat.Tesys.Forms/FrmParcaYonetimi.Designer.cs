namespace Firat.Tesys.Forms
{
    partial class FrmParcaYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcaYonetimi));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grdParcaListesi = new DevExpress.XtraGrid.GridControl();
            this.gvParcalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnParcaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnParcaSil = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdParcaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParcalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnGuncelle);
            this.layoutControl1.Controls.Add(this.btnParcaSil);
            this.layoutControl1.Controls.Add(this.btnParcaEkle);
            this.layoutControl1.Controls.Add(this.grdParcaListesi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(998, 562);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(998, 562);
            this.Root.TextVisible = false;
            // 
            // grdParcaListesi
            // 
            this.grdParcaListesi.Location = new System.Drawing.Point(14, 94);
            this.grdParcaListesi.MainView = this.gvParcalar;
            this.grdParcaListesi.Name = "grdParcaListesi";
            this.grdParcaListesi.Size = new System.Drawing.Size(970, 454);
            this.grdParcaListesi.TabIndex = 4;
            this.grdParcaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvParcalar});
            // 
            // gvParcalar
            // 
            this.gvParcalar.GridControl = this.grdParcaListesi;
            this.gvParcalar.Name = "gvParcalar";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdParcaListesi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(974, 458);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnParcaEkle.Appearance.Options.UseFont = true;
            this.btnParcaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaEkle.ImageOptions.Image")));
            this.btnParcaEkle.Location = new System.Drawing.Point(14, 14);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.Size = new System.Drawing.Size(483, 36);
            this.btnParcaEkle.StyleController = this.layoutControl1;
            this.btnParcaEkle.TabIndex = 5;
            this.btnParcaEkle.Text = "Yeni Parça Ekle";
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnParcaEkle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(487, 40);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnParcaSil
            // 
            this.btnParcaSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnParcaSil.Appearance.Options.UseFont = true;
            this.btnParcaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaSil.ImageOptions.Image")));
            this.btnParcaSil.Location = new System.Drawing.Point(501, 14);
            this.btnParcaSil.Name = "btnParcaSil";
            this.btnParcaSil.Size = new System.Drawing.Size(483, 36);
            this.btnParcaSil.StyleController = this.layoutControl1;
            this.btnParcaSil.TabIndex = 6;
            this.btnParcaSil.Text = "Seçili Parçayı Sil";
            this.btnParcaSil.Click += new System.EventHandler(this.btnParcaSil_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnParcaSil;
            this.layoutControlItem3.Location = new System.Drawing.Point(487, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(487, 40);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(14, 54);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(970, 36);
            this.btnGuncelle.StyleController = this.layoutControl1;
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnGuncelle;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(974, 40);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmParcaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmParcaYonetimi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parça ve Stok Yönetimi";
            this.Load += new System.EventHandler(this.FrmParcaYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdParcaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParcalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnParcaSil;
        private DevExpress.XtraEditors.SimpleButton btnParcaEkle;
        private DevExpress.XtraGrid.GridControl grdParcaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvParcalar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}