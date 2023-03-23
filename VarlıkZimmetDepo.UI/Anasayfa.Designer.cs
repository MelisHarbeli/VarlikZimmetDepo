
namespace VarlıkZimmetDepo.UI
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.varlıkDepoListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlıkEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varlıkDepoListeleToolStripMenuItem,
            this.yeniKayıtEkleToolStripMenuItem,
            this.varlıkEkranıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // varlıkDepoListeleToolStripMenuItem
            // 
            this.varlıkDepoListeleToolStripMenuItem.Name = "varlıkDepoListeleToolStripMenuItem";
            this.varlıkDepoListeleToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.varlıkDepoListeleToolStripMenuItem.Text = "Varlık-Depo Listele";
            this.varlıkDepoListeleToolStripMenuItem.Click += new System.EventHandler(this.varlıkDepoListeleToolStripMenuItem_Click);
            // 
            // yeniKayıtEkleToolStripMenuItem
            // 
            this.yeniKayıtEkleToolStripMenuItem.Name = "yeniKayıtEkleToolStripMenuItem";
            this.yeniKayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.yeniKayıtEkleToolStripMenuItem.Text = "Yeni Kayıt Ekle";
            this.yeniKayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtEkleToolStripMenuItem_Click);
            // 
            // varlıkEkranıToolStripMenuItem
            // 
            this.varlıkEkranıToolStripMenuItem.Name = "varlıkEkranıToolStripMenuItem";
            this.varlıkEkranıToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.varlıkEkranıToolStripMenuItem.Text = "Varlık Ekranı";
            this.varlıkEkranıToolStripMenuItem.Click += new System.EventHandler(this.varlıkEkranıToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 530);
            this.panel1.TabIndex = 2;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem varlıkDepoListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlıkEkranıToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}