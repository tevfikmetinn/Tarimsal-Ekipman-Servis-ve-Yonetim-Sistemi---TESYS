namespace Firat.Tesys.Forms
{
    partial class FrmParcaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcaKayit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtParcaAdi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtBirimFiyat = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtStokAdet = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtKritikSeviye = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKritikSeviye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnKaydet);
            this.layoutControl1.Controls.Add(this.btnVazgec);
            this.layoutControl1.Controls.Add(this.txtKritikSeviye);
            this.layoutControl1.Controls.Add(this.txtStokAdet);
            this.layoutControl1.Controls.Add(this.txtBirimFiyat);
            this.layoutControl1.Controls.Add(this.txtParcaAdi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(633, 488);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(633, 488);
            this.Root.TextVisible = false;
            // 
            // txtParcaAdi
            // 
            this.txtParcaAdi.Location = new System.Drawing.Point(103, 14);
            this.txtParcaAdi.Name = "txtParcaAdi";
            this.txtParcaAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtParcaAdi.Properties.Appearance.Options.UseFont = true;
            this.txtParcaAdi.Size = new System.Drawing.Size(516, 24);
            this.txtParcaAdi.StyleController = this.layoutControl1;
            this.txtParcaAdi.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtParcaAdi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(609, 28);
            this.layoutControlItem1.Text = "Parça Adı:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(609, 272);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(103, 42);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtBirimFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(516, 24);
            this.txtBirimFiyat.StyleController = this.layoutControl1;
            this.txtBirimFiyat.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtBirimFiyat;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(609, 28);
            this.layoutControlItem2.Text = "Birim Fiyat:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 16);
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(103, 70);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtStokAdet.Properties.Appearance.Options.UseFont = true;
            this.txtStokAdet.Size = new System.Drawing.Size(516, 24);
            this.txtStokAdet.StyleController = this.layoutControl1;
            this.txtStokAdet.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtStokAdet;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(609, 28);
            this.layoutControlItem3.Text = "Stok Adet:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 16);
            // 
            // txtKritikSeviye
            // 
            this.txtKritikSeviye.Location = new System.Drawing.Point(103, 98);
            this.txtKritikSeviye.Name = "txtKritikSeviye";
            this.txtKritikSeviye.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtKritikSeviye.Properties.Appearance.Options.UseFont = true;
            this.txtKritikSeviye.Size = new System.Drawing.Size(516, 24);
            this.txtKritikSeviye.StyleController = this.layoutControl1;
            this.txtKritikSeviye.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtKritikSeviye;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(609, 28);
            this.layoutControlItem4.Text = "Kritik Seviye:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 16);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(14, 438);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(605, 36);
            this.btnVazgec.StyleController = this.layoutControl1;
            this.btnVazgec.TabIndex = 8;
            this.btnVazgec.Text = "İptal";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnVazgec;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 424);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(609, 40);
            this.layoutControlItem5.TextVisible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(14, 398);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(605, 36);
            this.btnKaydet.StyleController = this.layoutControl1;
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnKaydet;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 384);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(609, 40);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FrmParcaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 488);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmParcaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Parça Kaydı";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKritikSeviye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.TextEdit txtKritikSeviye;
        private DevExpress.XtraEditors.TextEdit txtStokAdet;
        private DevExpress.XtraEditors.TextEdit txtBirimFiyat;
        private DevExpress.XtraEditors.TextEdit txtParcaAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}