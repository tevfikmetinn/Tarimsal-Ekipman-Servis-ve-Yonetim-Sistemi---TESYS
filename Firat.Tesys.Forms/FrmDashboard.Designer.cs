namespace Firat.Tesys.Forms
{
    partial class FrmDashboard
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Firat.Tesys.Forms.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblToplamMusteri = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslikMusteri = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblBekleyenServis = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslikBekleyen = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblTamamlananServis = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslikBiten = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblToplamKazanc = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslikKasa = new DevExpress.XtraEditors.LabelControl();
            this.gridKritikSeviye = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartArizalar = new DevExpress.XtraCharts.ChartControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblIsSayisi = new DevExpress.XtraEditors.LabelControl();
            this.lblAyinElemani = new DevExpress.XtraEditors.LabelControl();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.grdRiskliMakineler = new DevExpress.XtraGrid.GridControl();
            this.grdwRiskliMakineler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKritikSeviye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartArizalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRiskliMakineler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwRiskliMakineler)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lblToplamMusteri);
            this.panelControl1.Controls.Add(this.lblBaslikMusteri);
            this.panelControl1.Location = new System.Drawing.Point(3, 94);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(161, 124);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lblToplamMusteri
            // 
            this.lblToplamMusteri.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblToplamMusteri.Appearance.Options.UseFont = true;
            this.lblToplamMusteri.Location = new System.Drawing.Point(9, 54);
            this.lblToplamMusteri.Name = "lblToplamMusteri";
            this.lblToplamMusteri.Size = new System.Drawing.Size(151, 27);
            this.lblToplamMusteri.TabIndex = 1;
            this.lblToplamMusteri.Text = "labelControl2";
            // 
            // lblBaslikMusteri
            // 
            this.lblBaslikMusteri.Location = new System.Drawing.Point(9, 16);
            this.lblBaslikMusteri.Name = "lblBaslikMusteri";
            this.lblBaslikMusteri.Size = new System.Drawing.Size(89, 16);
            this.lblBaslikMusteri.TabIndex = 0;
            this.lblBaslikMusteri.Text = "Toplam Müşteri";
            this.lblBaslikMusteri.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.lblBekleyenServis);
            this.panelControl2.Controls.Add(this.lblBaslikBekleyen);
            this.panelControl2.Location = new System.Drawing.Point(169, 94);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(161, 124);
            this.panelControl2.TabIndex = 1;
            // 
            // lblBekleyenServis
            // 
            this.lblBekleyenServis.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblBekleyenServis.Appearance.Options.UseFont = true;
            this.lblBekleyenServis.Location = new System.Drawing.Point(4, 54);
            this.lblBekleyenServis.Name = "lblBekleyenServis";
            this.lblBekleyenServis.Size = new System.Drawing.Size(151, 27);
            this.lblBekleyenServis.TabIndex = 2;
            this.lblBekleyenServis.Text = "labelControl4";
            // 
            // lblBaslikBekleyen
            // 
            this.lblBaslikBekleyen.Location = new System.Drawing.Point(4, 16);
            this.lblBaslikBekleyen.Name = "lblBaslikBekleyen";
            this.lblBaslikBekleyen.Size = new System.Drawing.Size(126, 16);
            this.lblBaslikBekleyen.TabIndex = 2;
            this.lblBaslikBekleyen.Text = "Bekleyen Servis Sayısı";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.lblTamamlananServis);
            this.panelControl3.Controls.Add(this.lblBaslikBiten);
            this.panelControl3.Location = new System.Drawing.Point(335, 94);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(161, 124);
            this.panelControl3.TabIndex = 1;
            // 
            // lblTamamlananServis
            // 
            this.lblTamamlananServis.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblTamamlananServis.Appearance.Options.UseFont = true;
            this.lblTamamlananServis.Location = new System.Drawing.Point(4, 54);
            this.lblTamamlananServis.Name = "lblTamamlananServis";
            this.lblTamamlananServis.Size = new System.Drawing.Size(151, 27);
            this.lblTamamlananServis.TabIndex = 3;
            this.lblTamamlananServis.Text = "labelControl6";
            // 
            // lblBaslikBiten
            // 
            this.lblBaslikBiten.Location = new System.Drawing.Point(4, 16);
            this.lblBaslikBiten.Name = "lblBaslikBiten";
            this.lblBaslikBiten.Size = new System.Drawing.Size(151, 16);
            this.lblBaslikBiten.TabIndex = 4;
            this.lblBaslikBiten.Text = "Tamamlanan Servis Sayısı";
            this.lblBaslikBiten.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Controls.Add(this.lblToplamKazanc);
            this.panelControl4.Controls.Add(this.lblBaslikKasa);
            this.panelControl4.Location = new System.Drawing.Point(501, 94);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(161, 124);
            this.panelControl4.TabIndex = 1;
            // 
            // lblToplamKazanc
            // 
            this.lblToplamKazanc.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblToplamKazanc.Appearance.Options.UseFont = true;
            this.lblToplamKazanc.Location = new System.Drawing.Point(4, 54);
            this.lblToplamKazanc.Name = "lblToplamKazanc";
            this.lblToplamKazanc.Size = new System.Drawing.Size(151, 27);
            this.lblToplamKazanc.TabIndex = 5;
            this.lblToplamKazanc.Text = "labelControl8";
            // 
            // lblBaslikKasa
            // 
            this.lblBaslikKasa.Location = new System.Drawing.Point(4, 16);
            this.lblBaslikKasa.Name = "lblBaslikKasa";
            this.lblBaslikKasa.Size = new System.Drawing.Size(87, 16);
            this.lblBaslikKasa.TabIndex = 6;
            this.lblBaslikKasa.Text = "Toplam Kazanç";
            // 
            // gridKritikSeviye
            // 
            this.gridKritikSeviye.Location = new System.Drawing.Point(3, 238);
            this.gridKritikSeviye.MainView = this.gridView1;
            this.gridKritikSeviye.Name = "gridKritikSeviye";
            this.gridKritikSeviye.Size = new System.Drawing.Size(486, 252);
            this.gridKritikSeviye.TabIndex = 2;
            this.gridKritikSeviye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridKritikSeviye;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Müşteri Adı";
            this.gridColumn1.FieldName = "AdSoyad";
            this.gridColumn1.MinWidth = 22;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 206;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Durum";
            this.gridColumn2.FieldName = "Durum";
            this.gridColumn2.MinWidth = 22;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Gün Farkı";
            this.gridColumn3.FieldName = "GecenGun";
            this.gridColumn3.MinWidth = 22;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 70;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Telefon";
            this.gridColumn4.FieldName = "Telefon";
            this.gridColumn4.MinWidth = 22;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cihaz";
            this.gridColumn5.FieldName = "Cihaz";
            this.gridColumn5.MinWidth = 22;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Son Geliş";
            this.gridColumn6.FieldName = "SonGelisTarihi";
            this.gridColumn6.MinWidth = 22;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 87;
            // 
            // chartArizalar
            // 
            this.chartArizalar.Location = new System.Drawing.Point(494, 238);
            this.chartArizalar.Name = "chartArizalar";
            this.chartArizalar.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartArizalar.Size = new System.Drawing.Size(262, 200);
            this.chartArizalar.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblIsSayisi);
            this.groupControl1.Controls.Add(this.lblAyinElemani);
            this.groupControl1.Location = new System.Drawing.Point(761, 238);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(230, 200);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "🥇 AYIN ELEMANI";
            // 
            // lblIsSayisi
            // 
            this.lblIsSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblIsSayisi.Appearance.Options.UseFont = true;
            this.lblIsSayisi.Location = new System.Drawing.Point(5, 60);
            this.lblIsSayisi.Name = "lblIsSayisi";
            this.lblIsSayisi.Size = new System.Drawing.Size(104, 17);
            this.lblIsSayisi.TabIndex = 1;
            this.lblIsSayisi.Text = "0 Tamamlanan İş";
            // 
            // lblAyinElemani
            // 
            this.lblAyinElemani.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblAyinElemani.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAyinElemani.Appearance.Options.UseFont = true;
            this.lblAyinElemani.Appearance.Options.UseForeColor = true;
            this.lblAyinElemani.Location = new System.Drawing.Point(5, 32);
            this.lblAyinElemani.Name = "lblAyinElemani";
            this.lblAyinElemani.Size = new System.Drawing.Size(106, 21);
            this.lblAyinElemani.TabIndex = 0;
            this.lblAyinElemani.Text = "Yükleniyor...";
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider1.AutoSlideInterval = 3000;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images3"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images4"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images5"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images6"))));
            this.ımageSlider1.Location = new System.Drawing.Point(997, 94);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(692, 531);
            this.ımageSlider1.TabIndex = 5;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // grdRiskliMakineler
            // 
            this.grdRiskliMakineler.Location = new System.Drawing.Point(2, 583);
            this.grdRiskliMakineler.MainView = this.grdwRiskliMakineler;
            this.grdRiskliMakineler.Name = "grdRiskliMakineler";
            this.grdRiskliMakineler.Size = new System.Drawing.Size(990, 370);
            this.grdRiskliMakineler.TabIndex = 6;
            this.grdRiskliMakineler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdwRiskliMakineler});
            // 
            // grdwRiskliMakineler
            // 
            this.grdwRiskliMakineler.GridControl = this.grdRiskliMakineler;
            this.grdwRiskliMakineler.Name = "grdwRiskliMakineler";
            this.grdwRiskliMakineler.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 523);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(444, 28);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "RİSK VE SAĞLIK ANALİZ SIRALAMASI";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl1.ImageOptions.SvgImage")));
            this.labelControl1.Location = new System.Drawing.Point(2, 517);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 40);
            this.labelControl1.TabIndex = 9;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1698, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grdRiskliMakineler);
            this.Controls.Add(this.ımageSlider1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.chartArizalar);
            this.Controls.Add(this.gridKritikSeviye);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmDashboard.IconOptions.Icon")));
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmDashboard_Activated);
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKritikSeviye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartArizalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRiskliMakineler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwRiskliMakineler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblToplamMusteri;
        private DevExpress.XtraEditors.LabelControl lblBaslikMusteri;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblBekleyenServis;
        private DevExpress.XtraEditors.LabelControl lblBaslikBekleyen;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblTamamlananServis;
        private DevExpress.XtraEditors.LabelControl lblBaslikBiten;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl lblToplamKazanc;
        private DevExpress.XtraEditors.LabelControl lblBaslikKasa;
        private DevExpress.XtraGrid.GridControl gridKritikSeviye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraCharts.ChartControl chartArizalar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblIsSayisi;
        private DevExpress.XtraEditors.LabelControl lblAyinElemani;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraGrid.GridControl grdRiskliMakineler;
        private DevExpress.XtraGrid.Views.Grid.GridView grdwRiskliMakineler;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}