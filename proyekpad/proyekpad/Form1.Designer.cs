namespace proyekpad
{
    partial class Form1
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
            this.dtptanggal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbbarang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudjumlah = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnbayar = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudjumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // dtptanggal
            // 
            this.dtptanggal.Location = new System.Drawing.Point(82, 12);
            this.dtptanggal.Name = "dtptanggal";
            this.dtptanggal.Size = new System.Drawing.Size(243, 22);
            this.dtptanggal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal :";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(421, 12);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(172, 24);
            this.cmbcustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 479);
            this.dataGridView1.TabIndex = 4;
            // 
            // cmbbarang
            // 
            this.cmbbarang.FormattingEnabled = true;
            this.cmbbarang.Location = new System.Drawing.Point(115, 557);
            this.cmbbarang.Name = "cmbbarang";
            this.cmbbarang.Size = new System.Drawing.Size(169, 24);
            this.cmbbarang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Barang :";
            // 
            // nudjumlah
            // 
            this.nudjumlah.Location = new System.Drawing.Point(115, 600);
            this.nudjumlah.Name = "nudjumlah";
            this.nudjumlah.Size = new System.Drawing.Size(120, 22);
            this.nudjumlah.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jumlah :";
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(14, 655);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(84, 36);
            this.btntambah.TabIndex = 8;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = true;
            // 
            // btnbayar
            // 
            this.btnbayar.Location = new System.Drawing.Point(1205, 655);
            this.btnbayar.Name = "btnbayar";
            this.btnbayar.Size = new System.Drawing.Size(84, 36);
            this.btnbayar.TabIndex = 8;
            this.btnbayar.Text = "Bayar";
            this.btnbayar.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(165, 655);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(84, 36);
            this.btnhapus.TabIndex = 8;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 703);
            this.Controls.Add(this.btnbayar);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudjumlah);
            this.Controls.Add(this.cmbbarang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbcustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtptanggal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudjumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtptanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbbarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudjumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnbayar;
        private System.Windows.Forms.Button btnhapus;
    }
}

