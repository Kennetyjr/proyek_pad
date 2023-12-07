namespace proyekpad
{
    partial class Fmaster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryPenjualanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.produkToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.pegawaiToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryPenjualanToolStripMenuItem,
            this.entryPenjualanToolStripMenuItem1});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // produkToolStripMenuItem
            // 
            this.produkToolStripMenuItem.Name = "produkToolStripMenuItem";
            this.produkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produkToolStripMenuItem.Text = "Produk";
            this.produkToolStripMenuItem.Click += new System.EventHandler(this.produkToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // pegawaiToolStripMenuItem
            // 
            this.pegawaiToolStripMenuItem.Name = "pegawaiToolStripMenuItem";
            this.pegawaiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pegawaiToolStripMenuItem.Text = "Pegawai";
            this.pegawaiToolStripMenuItem.Click += new System.EventHandler(this.pegawaiToolStripMenuItem_Click);
            // 
            // entryPenjualanToolStripMenuItem
            // 
            this.entryPenjualanToolStripMenuItem.Name = "entryPenjualanToolStripMenuItem";
            this.entryPenjualanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.entryPenjualanToolStripMenuItem.Text = "Refill Stok";
            this.entryPenjualanToolStripMenuItem.Click += new System.EventHandler(this.entryPenjualanToolStripMenuItem_Click);
            // 
            // entryPenjualanToolStripMenuItem1
            // 
            this.entryPenjualanToolStripMenuItem1.Name = "entryPenjualanToolStripMenuItem1";
            this.entryPenjualanToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.entryPenjualanToolStripMenuItem1.Text = "Entry Penjualan";
            this.entryPenjualanToolStripMenuItem1.Click += new System.EventHandler(this.entryPenjualanToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Fmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 590);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fmaster";
            this.Text = "Fmaster";
            this.Load += new System.EventHandler(this.Fmaster_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryPenjualanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}