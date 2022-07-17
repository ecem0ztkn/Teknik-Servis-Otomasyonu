
namespace TechnicalServices.Formlar
{
    partial class FrmFaturaKalemleri
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1371, 502);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "SERİ NO:";
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(63, 8);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.BeepOnError = false;
            this.TxtSeriNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSeriNo.Properties.MaskSettings.Set("mask", "A");
            this.TxtSeriNo.Size = new System.Drawing.Size(155, 20);
            this.TxtSeriNo.TabIndex = 1;
            this.TxtSeriNo.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(693, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 22);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "ARA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtSiraNo
            // 
            this.TxtSiraNo.Location = new System.Drawing.Point(276, 8);
            this.TxtSiraNo.Name = "TxtSiraNo";
            this.TxtSiraNo.Properties.BeepOnError = false;
            this.TxtSiraNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSiraNo.Properties.MaskSettings.Set("mask", "99999");
            this.TxtSiraNo.Size = new System.Drawing.Size(155, 20);
            this.TxtSiraNo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(224, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "SIRA NO:";
            // 
            // TxtFaturaID
            // 
            this.TxtFaturaID.Location = new System.Drawing.Point(501, 9);
            this.TxtFaturaID.Name = "TxtFaturaID";
            this.TxtFaturaID.Properties.BeepOnError = false;
            this.TxtFaturaID.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtFaturaID.Properties.MaskSettings.Set("mask", "A");
            this.TxtFaturaID.Size = new System.Drawing.Size(155, 20);
            this.TxtFaturaID.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(437, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "FATURA ID:";
            // 
            // FrmFaturaKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.TxtFaturaID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtSiraNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaKalemleri";
            this.Text = "FrmFaturaKalemleri";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit TxtSiraNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtFaturaID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}