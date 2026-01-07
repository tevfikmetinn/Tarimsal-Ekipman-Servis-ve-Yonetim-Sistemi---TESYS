namespace Firat.Tesys.Forms
{
    partial class FrmServisKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServisKayit));
            this.lkpMusteri = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.txtArizaAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateGelisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.btnServisKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkpMakineTur = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lkpParca = new DevExpress.XtraEditors.LookUpEdit();
            this.parcafiyati = new DevExpress.XtraEditors.LabelControl();
            this.txtParcaFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtIscilikFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lkpUsta = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cmbMusteriMakineleri = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArizaAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMakineTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpParca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIscilikFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUsta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMusteriMakineleri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkpMusteri
            // 
            this.lkpMusteri.Location = new System.Drawing.Point(162, 21);
            this.lkpMusteri.Name = "lkpMusteri";
            this.lkpMusteri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lkpMusteri.Properties.Appearance.Options.UseFont = true;
            this.lkpMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMusteri.Properties.NullText = "Bir Müşteri Seçiniz...";
            this.lkpMusteri.Size = new System.Drawing.Size(154, 24);
            this.lkpMusteri.TabIndex = 0;
            this.lkpMusteri.EditValueChanged += new System.EventHandler(this.lkpMusteri_EditValueChanged);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(158, 245);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtMarka.Properties.Appearance.Options.UseFont = true;
            this.txtMarka.Properties.ReadOnly = true;
            this.txtMarka.Size = new System.Drawing.Size(136, 24);
            this.txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(363, 246);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtModel.Properties.Appearance.Options.UseFont = true;
            this.txtModel.Properties.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(125, 24);
            this.txtModel.TabIndex = 3;
            // 
            // txtArizaAciklama
            // 
            this.txtArizaAciklama.Location = new System.Drawing.Point(46, 372);
            this.txtArizaAciklama.Name = "txtArizaAciklama";
            this.txtArizaAciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtArizaAciklama.Properties.Appearance.Options.UseFont = true;
            this.txtArizaAciklama.Size = new System.Drawing.Size(640, 144);
            this.txtArizaAciklama.TabIndex = 4;
            // 
            // dateGelisTarihi
            // 
            this.dateGelisTarihi.EditValue = null;
            this.dateGelisTarihi.Location = new System.Drawing.Point(158, 279);
            this.dateGelisTarihi.Name = "dateGelisTarihi";
            this.dateGelisTarihi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dateGelisTarihi.Properties.Appearance.Options.UseFont = true;
            this.dateGelisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGelisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGelisTarihi.Size = new System.Drawing.Size(136, 24);
            this.dateGelisTarihi.TabIndex = 5;
            // 
            // btnServisKaydet
            // 
            this.btnServisKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnServisKaydet.Appearance.Options.UseFont = true;
            this.btnServisKaydet.Location = new System.Drawing.Point(268, 522);
            this.btnServisKaydet.Name = "btnServisKaydet";
            this.btnServisKaydet.Size = new System.Drawing.Size(127, 29);
            this.btnServisKaydet.TabIndex = 7;
            this.btnServisKaydet.Text = "Arıza Kaydı Oluştur";
            this.btnServisKaydet.Click += new System.EventHandler(this.btnServisKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 17);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Müşteri Seçiniz:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Cihaz Türü:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 248);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Marka:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(310, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Model:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 282);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 17);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Geliş Tarihi:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(49, 349);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 17);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Arıza Açıklaması:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // lkpMakineTur
            // 
            this.lkpMakineTur.Location = new System.Drawing.Point(161, 108);
            this.lkpMakineTur.Name = "lkpMakineTur";
            this.lkpMakineTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lkpMakineTur.Properties.Appearance.Options.UseFont = true;
            this.lkpMakineTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMakineTur.Properties.NullText = "Makine seçiniz...";
            this.lkpMakineTur.Size = new System.Drawing.Size(154, 24);
            this.lkpMakineTur.TabIndex = 15;
            this.lkpMakineTur.EditValueChanged += new System.EventHandler(this.lkpMakineTur_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(46, 149);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 17);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Değişen Parça:";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // lkpParca
            // 
            this.lkpParca.Location = new System.Drawing.Point(161, 146);
            this.lkpParca.Name = "lkpParca";
            this.lkpParca.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lkpParca.Properties.Appearance.Options.UseFont = true;
            this.lkpParca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpParca.Properties.NullText = "Parça Seçiniz...";
            this.lkpParca.Size = new System.Drawing.Size(154, 24);
            this.lkpParca.TabIndex = 17;
            this.lkpParca.EditValueChanged += new System.EventHandler(this.lkpParca_EditValueChanged);
            // 
            // parcafiyati
            // 
            this.parcafiyati.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.parcafiyati.Appearance.Options.UseFont = true;
            this.parcafiyati.Location = new System.Drawing.Point(49, 317);
            this.parcafiyati.Name = "parcafiyati";
            this.parcafiyati.Size = new System.Drawing.Size(74, 17);
            this.parcafiyati.TabIndex = 18;
            this.parcafiyati.Text = "Parça Fiyatı:";
            // 
            // txtParcaFiyat
            // 
            this.txtParcaFiyat.Location = new System.Drawing.Point(158, 317);
            this.txtParcaFiyat.Name = "txtParcaFiyat";
            this.txtParcaFiyat.Properties.ReadOnly = true;
            this.txtParcaFiyat.Size = new System.Drawing.Size(136, 22);
            this.txtParcaFiyat.TabIndex = 19;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(310, 320);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 17);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "İşçilik:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // txtIscilikFiyat
            // 
            this.txtIscilikFiyat.Location = new System.Drawing.Point(363, 317);
            this.txtIscilikFiyat.Name = "txtIscilikFiyat";
            this.txtIscilikFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtIscilikFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtIscilikFiyat.Size = new System.Drawing.Size(125, 24);
            this.txtIscilikFiyat.TabIndex = 21;
            this.txtIscilikFiyat.EditValueChanged += new System.EventHandler(this.txtIscilikFiyat_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(494, 319);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 17);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "TOPLAM:";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(564, 318);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtToplamFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.txtToplamFiyat.Properties.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(125, 22);
            this.txtToplamFiyat.TabIndex = 23;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(46, 189);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(92, 17);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Atanacak Usta:";
            // 
            // lkpUsta
            // 
            this.lkpUsta.Enabled = false;
            this.lkpUsta.Location = new System.Drawing.Point(161, 187);
            this.lkpUsta.Name = "lkpUsta";
            this.lkpUsta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lkpUsta.Properties.Appearance.Options.UseFont = true;
            this.lkpUsta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpUsta.Properties.NullText = "Önce Parça Seçiniz...";
            this.lkpUsta.Size = new System.Drawing.Size(154, 24);
            this.lkpUsta.TabIndex = 25;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(907, 24);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(586, 446);
            this.pictureEdit1.TabIndex = 26;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // cmbMusteriMakineleri
            // 
            this.cmbMusteriMakineleri.Location = new System.Drawing.Point(162, 66);
            this.cmbMusteriMakineleri.Name = "cmbMusteriMakineleri";
            this.cmbMusteriMakineleri.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbMusteriMakineleri.Properties.Appearance.Options.UseFont = true;
            this.cmbMusteriMakineleri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMusteriMakineleri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbMusteriMakineleri.Size = new System.Drawing.Size(154, 24);
            this.cmbMusteriMakineleri.TabIndex = 27;
            this.cmbMusteriMakineleri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriMakineleri_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(46, 69);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(110, 17);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "Kayıtlı Makine Seç:";
            // 
            // FrmServisKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 764);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.cmbMusteriMakineleri);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lkpUsta);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtIscilikFiyat);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtParcaFiyat);
            this.Controls.Add(this.parcafiyati);
            this.Controls.Add(this.lkpParca);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lkpMakineTur);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnServisKaydet);
            this.Controls.Add(this.dateGelisTarihi);
            this.Controls.Add(this.txtArizaAciklama);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lkpMusteri);
            this.Name = "FrmServisKayit";
            this.Text = "FrmServisKayit";
            this.Load += new System.EventHandler(this.FrmServisKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArizaAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMakineTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpParca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcaFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIscilikFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUsta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMusteriMakineleri.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lkpMusteri;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.MemoEdit txtArizaAciklama;
        private DevExpress.XtraEditors.DateEdit dateGelisTarihi;
        private DevExpress.XtraEditors.SimpleButton btnServisKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lkpMakineTur;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit lkpParca;
        private DevExpress.XtraEditors.LabelControl parcafiyati;
        private DevExpress.XtraEditors.TextEdit txtParcaFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtIscilikFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtToplamFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lkpUsta;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMusteriMakineleri;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}