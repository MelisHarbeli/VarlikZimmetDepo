
namespace VarlıkZimmetDepo.UI
{
    partial class ZimmetAta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZimmetAta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.cmbNeden = new System.Windows.Forms.ComboBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.dateBAsla = new System.Windows.Forms.DateTimePicker();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.txtAcik = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zimmet Ata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Zimmet Sahibi Kişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Zimmet Nedeni ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Zimmet Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Zimmet Başlangıç Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Zimmet Bitiş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "*Açıklama";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(45, 54);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(200, 20);
            this.txtKullanici.TabIndex = 7;
            // 
            // cmbNeden
            // 
            this.cmbNeden.FormattingEnabled = true;
            this.cmbNeden.Items.AddRange(new object[] {
            "Remote Çalışma",
            "İstek"});
            this.cmbNeden.Location = new System.Drawing.Point(45, 108);
            this.cmbNeden.Name = "cmbNeden";
            this.cmbNeden.Size = new System.Drawing.Size(200, 21);
            this.cmbNeden.TabIndex = 8;
            this.cmbNeden.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Zimmet Sahibi Kişi",
            "Zimmet Sahibi Ekip"});
            this.cmbTur.Location = new System.Drawing.Point(45, 164);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(200, 21);
            this.cmbTur.TabIndex = 9;
            // 
            // dateBAsla
            // 
            this.dateBAsla.Location = new System.Drawing.Point(45, 218);
            this.dateBAsla.Name = "dateBAsla";
            this.dateBAsla.Size = new System.Drawing.Size(200, 20);
            this.dateBAsla.TabIndex = 10;
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(45, 276);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(200, 20);
            this.dateBitis.TabIndex = 11;
            // 
            // txtAcik
            // 
            this.txtAcik.Location = new System.Drawing.Point(46, 328);
            this.txtAcik.Name = "txtAcik";
            this.txtAcik.Size = new System.Drawing.Size(200, 20);
            this.txtAcik.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(84, 375);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 23);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Zimmet Ata";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ZimmetAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtAcik);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.dateBAsla);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.cmbNeden);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZimmetAta";
            this.Text = "Zimmet Ata";
            this.Load += new System.EventHandler(this.ZimmetAta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.ComboBox cmbNeden;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker dateBAsla;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.TextBox txtAcik;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}