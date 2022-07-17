
namespace TechnicalServices.Formlar
{
    partial class FrmYeniKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TxtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "YENİ KATEGORİ EKLEME";
            this.textEdit7.Location = new System.Drawing.Point(143, 45);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit7.Size = new System.Drawing.Size(176, 30);
            this.textEdit7.TabIndex = 26;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Location = new System.Drawing.Point(140, 167);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(220, 3);
            this.panelControl1.TabIndex = 25;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.EditValue = "Kategori Adı";
            this.TxtUrunAd.Location = new System.Drawing.Point(140, 133);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrunAd.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtUrunAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.TxtUrunAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtUrunAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtUrunAd.Size = new System.Drawing.Size(220, 26);
            this.TxtUrunAd.TabIndex = 24;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(78, 124);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(47, 48);
            this.pictureEdit1.TabIndex = 23;
            // 
            // BtnIptal
            // 
            this.BtnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIptal.Appearance.Options.UseFont = true;
            this.BtnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIptal.ImageOptions.Image")));
            this.BtnIptal.Location = new System.Drawing.Point(65, 207);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(142, 35);
            this.BtnIptal.TabIndex = 28;
            this.BtnIptal.Text = "İPTAL";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(254, 207);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(142, 35);
            this.BtnEkle.TabIndex = 27;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(477, 360);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit TxtUrunAd;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnIptal;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
    }
}