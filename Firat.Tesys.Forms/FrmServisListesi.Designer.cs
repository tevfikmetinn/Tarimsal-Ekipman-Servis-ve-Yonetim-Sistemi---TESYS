namespace Firat.Tesys.Forms
{
    partial class FrmServisListesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServisListesi));
            this.gridServisler = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durumTamamlandıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.durumuTamamlandıYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPDF = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridServisler)).BeginInit();
            this.contextMenuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridServisler
            // 
            this.gridServisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridServisler.EmbeddedNavigator.ContextMenuStrip = this.contextMenuStrip4;
            this.gridServisler.Location = new System.Drawing.Point(0, 0);
            this.gridServisler.MainView = this.gridView1;
            this.gridServisler.Name = "gridServisler";
            this.gridServisler.Size = new System.Drawing.Size(700, 450);
            this.gridServisler.TabIndex = 0;
            this.gridServisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridServisler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridServisler_MouseUp);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumTamamlandıToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(212, 28);
            // 
            // durumTamamlandıToolStripMenuItem
            // 
            this.durumTamamlandıToolStripMenuItem.Name = "durumTamamlandıToolStripMenuItem";
            this.durumTamamlandıToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.durumTamamlandıToolStripMenuItem.Text = "Durum: Tamamlandı";
            this.durumTamamlandıToolStripMenuItem.Click += new System.EventHandler(this.durumTamamlandıToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridServisler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumuTamamlandıYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // durumuTamamlandıYapToolStripMenuItem
            // 
            this.durumuTamamlandıYapToolStripMenuItem.Name = "durumuTamamlandıYapToolStripMenuItem";
            this.durumuTamamlandıYapToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.durumuTamamlandıYapToolStripMenuItem.Text = "Durumu: Tamamlandı Yap";
            this.durumuTamamlandıYapToolStripMenuItem.Click += new System.EventHandler(this.durumuTamamlandıYapToolStripMenuItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPDF);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(700, 69);
            this.panelControl1.TabIndex = 1;
            // 
            // btnPDF
            // 
            this.btnPDF.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnPDF.Appearance.Options.UseFont = true;
            this.btnPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.ImageOptions.Image")));
            this.btnPDF.Location = new System.Drawing.Point(143, 22);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(122, 29);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "PDF\'e Aktar";
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(12, 22);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(125, 29);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmServisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridServisler);
            this.Name = "FrmServisListesi";
            this.Text = "FrmServisListesi";
            this.Load += new System.EventHandler(this.FrmServisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServisler)).EndInit();
            this.contextMenuStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridServisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem durumuTamamlandıYapToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPDF;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem durumTamamlandıToolStripMenuItem;
    }
}