namespace Firat.Tesys.Forms
{
    partial class FrmUstaYonetimi
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnUstaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUstaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.grdUstaListesi = new DevExpress.XtraGrid.GridControl();
            this.gvUstalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUstaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUstalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnUstaEkle);
            this.layoutControl1.Controls.Add(this.btnUstaSil);
            this.layoutControl1.Controls.Add(this.btnGuncelle);
            this.layoutControl1.Controls.Add(this.grdUstaListesi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(837, 535);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnUstaEkle
            // 
            this.btnUstaEkle.Location = new System.Drawing.Point(14, 432);
            this.btnUstaEkle.Name = "btnUstaEkle";
            this.btnUstaEkle.Size = new System.Drawing.Size(809, 27);
            this.btnUstaEkle.StyleController = this.layoutControl1;
            this.btnUstaEkle.TabIndex = 7;
            this.btnUstaEkle.Text = "Usta Ekle";
            this.btnUstaEkle.Click += new System.EventHandler(this.btnUstaEkle_Click);
            // 
            // btnUstaSil
            // 
            this.btnUstaSil.Location = new System.Drawing.Point(14, 463);
            this.btnUstaSil.Name = "btnUstaSil";
            this.btnUstaSil.Size = new System.Drawing.Size(809, 27);
            this.btnUstaSil.StyleController = this.layoutControl1;
            this.btnUstaSil.TabIndex = 6;
            this.btnUstaSil.Text = "Usta Sil";
            this.btnUstaSil.Click += new System.EventHandler(this.btnUstaSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(14, 494);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(809, 27);
            this.btnGuncelle.StyleController = this.layoutControl1;
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // grdUstaListesi
            // 
            this.grdUstaListesi.Location = new System.Drawing.Point(14, 14);
            this.grdUstaListesi.MainView = this.gvUstalar;
            this.grdUstaListesi.Name = "grdUstaListesi";
            this.grdUstaListesi.Size = new System.Drawing.Size(809, 414);
            this.grdUstaListesi.TabIndex = 4;
            this.grdUstaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUstalar});
            // 
            // gvUstalar
            // 
            this.gvUstalar.GridControl = this.grdUstaListesi;
            this.gvUstalar.Name = "gvUstalar";
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
            this.Root.Size = new System.Drawing.Size(837, 535);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdUstaListesi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(813, 418);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnGuncelle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 480);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(813, 31);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnUstaSil;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 449);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(813, 31);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnUstaEkle;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 418);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(813, 31);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmUstaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 535);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmUstaYonetimi";
            this.Text = "FrmUstaYonetimi";
            this.Load += new System.EventHandler(this.FrmUstaYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUstaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUstalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnUstaEkle;
        private DevExpress.XtraEditors.SimpleButton btnUstaSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraGrid.GridControl grdUstaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUstalar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}