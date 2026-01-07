namespace Firat.Tesys.Forms
{
    partial class FrmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMusteriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnArizaKayit = new DevExpress.XtraBars.BarButtonItem();
            this.btnServisListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnParcaTanimlama = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTemaDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnUstaTanimlama = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnMusteriListesi,
            this.btnArizaKayit,
            this.btnServisListesi,
            this.btnParcaTanimlama,
            this.btnUstaTanimlama});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(778, 183);
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.Caption = "Müşteri Tanımlama";
            this.btnMusteriListesi.Id = 1;
            this.btnMusteriListesi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMusteriListesi.ImageOptions.SvgImage")));
            this.btnMusteriListesi.LargeWidth = 80;
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriListesi_ItemClick);
            // 
            // btnArizaKayit
            // 
            this.btnArizaKayit.Caption = "Arıza Kaydı";
            this.btnArizaKayit.Id = 2;
            this.btnArizaKayit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnArizaKayit.ImageOptions.SvgImage")));
            this.btnArizaKayit.LargeWidth = 80;
            this.btnArizaKayit.Name = "btnArizaKayit";
            this.btnArizaKayit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArizaKayit_ItemClick);
            // 
            // btnServisListesi
            // 
            this.btnServisListesi.Caption = "Servis Listesi";
            this.btnServisListesi.Id = 3;
            this.btnServisListesi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnServisListesi.ImageOptions.SvgImage")));
            this.btnServisListesi.LargeWidth = 80;
            this.btnServisListesi.Name = "btnServisListesi";
            this.btnServisListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnServisListesi_ItemClick);
            // 
            // btnParcaTanimlama
            // 
            this.btnParcaTanimlama.Caption = "Parça Tanımlama";
            this.btnParcaTanimlama.Id = 4;
            this.btnParcaTanimlama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParcaTanimlama.ImageOptions.Image")));
            this.btnParcaTanimlama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnParcaTanimlama.ImageOptions.LargeImage")));
            this.btnParcaTanimlama.Name = "btnParcaTanimlama";
            this.btnParcaTanimlama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnParcaTanimlama_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnArizaKayit);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnServisListesi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Müşteri ve Servis";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnParcaTanimlama);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ENVANTER VE STOK";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUstaTanimlama);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "YÖNETİM";
            // 
            // btnTemaDegistir
            // 
            this.btnTemaDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemaDegistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemaDegistir.ImageOptions.SvgImage")));
            this.btnTemaDegistir.ImageOptions.SvgImageSize = new System.Drawing.Size(13, 13);
            this.btnTemaDegistir.Location = new System.Drawing.Point(755, 0);
            this.btnTemaDegistir.Name = "btnTemaDegistir";
            this.btnTemaDegistir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTemaDegistir.Size = new System.Drawing.Size(23, 25);
            this.btnTemaDegistir.TabIndex = 2;
            this.btnTemaDegistir.Click += new System.EventHandler(this.btnTemaDegistir_Click);
            // 
            // btnUstaTanimlama
            // 
            this.btnUstaTanimlama.Caption = "Usta Tanımlama";
            this.btnUstaTanimlama.Id = 5;
            this.btnUstaTanimlama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUstaTanimlama.ImageOptions.Image")));
            this.btnUstaTanimlama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUstaTanimlama.ImageOptions.LargeImage")));
            this.btnUstaTanimlama.Name = "btnUstaTanimlama";
            this.btnUstaTanimlama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUstaTanimlama_ItemClick);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 487);
            this.Controls.Add(this.btnTemaDegistir);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmAnaMenu.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmAnaMenu";
            this.Text = "FrmAnaMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnMusteriListesi;
        private DevExpress.XtraBars.BarButtonItem btnArizaKayit;
        private DevExpress.XtraBars.BarButtonItem btnServisListesi;
        private DevExpress.XtraEditors.SimpleButton btnTemaDegistir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnParcaTanimlama;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnUstaTanimlama;
    }
}