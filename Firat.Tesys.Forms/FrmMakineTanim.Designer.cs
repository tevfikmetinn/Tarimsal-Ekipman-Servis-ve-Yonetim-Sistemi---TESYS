namespace Firat.Tesys.Forms
{
    partial class FrmMakineTanim
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
            this.cmbCihazTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbMarka = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbUretimYili = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCihazTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUretimYili.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCihazTuru
            // 
            this.cmbCihazTuru.EditValue = "Cihaz Türü:";
            this.cmbCihazTuru.Location = new System.Drawing.Point(32, 54);
            this.cmbCihazTuru.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbCihazTuru.Name = "cmbCihazTuru";
            this.cmbCihazTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbCihazTuru.Properties.Appearance.Options.UseFont = true;
            this.cmbCihazTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCihazTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCihazTuru.Size = new System.Drawing.Size(156, 24);
            this.cmbCihazTuru.TabIndex = 0;
            // 
            // cmbMarka
            // 
            this.cmbMarka.EditValue = "Marka:";
            this.cmbMarka.Location = new System.Drawing.Point(32, 122);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbMarka.Properties.Appearance.Options.UseFont = true;
            this.cmbMarka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMarka.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbMarka.Size = new System.Drawing.Size(156, 24);
            this.cmbMarka.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.EditValue = "Model:";
            this.txtModel.Location = new System.Drawing.Point(32, 199);
            this.txtModel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtModel.Properties.Appearance.Options.UseFont = true;
            this.txtModel.Size = new System.Drawing.Size(156, 24);
            this.txtModel.TabIndex = 2;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.EditValue = "Seri / Şasi No:";
            this.txtSeriNo.Location = new System.Drawing.Point(32, 275);
            this.txtSeriNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.txtSeriNo.Size = new System.Drawing.Size(156, 24);
            this.txtSeriNo.TabIndex = 3;
            // 
            // cmbUretimYili
            // 
            this.cmbUretimYili.EditValue = "Üretim Yılı:";
            this.cmbUretimYili.Location = new System.Drawing.Point(32, 349);
            this.cmbUretimYili.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbUretimYili.Name = "cmbUretimYili";
            this.cmbUretimYili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbUretimYili.Properties.Appearance.Options.UseFont = true;
            this.cmbUretimYili.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUretimYili.Size = new System.Drawing.Size(156, 24);
            this.cmbUretimYili.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(32, 426);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 36);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "(Kaydet)";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // FrmMakineTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(710, 472);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbUretimYili);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.cmbCihazTuru);
            this.Name = "FrmMakineTanim";
            this.Text = "FrmMakineTanim";
            ((System.ComponentModel.ISupportInitialize)(this.cmbCihazTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUretimYili.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbCihazTuru;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMarka;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUretimYili;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}