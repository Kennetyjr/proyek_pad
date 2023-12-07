using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyekpad
{
    public partial class Fkategori : Form
    {
        proyekpadEntities ppad = new proyekpadEntities();
        int idx = -1;
        string up = "";
        public Fkategori()
        {
            InitializeComponent();
        }

        private void loaddgv()
        {
            var ld = from k in ppad.CategoryProducts
                     select new
                     {
                         ID = k.ProductID,
                         Nama_Kategori = k.Nama_Product,
                     };
            dataGridView1.DataSource = ld.ToList();
            var temp = dataGridView1.RowCount;
            lbid.Text = "PID0"+(temp + 1).ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
            Fmaster fm = new Fmaster();
            fm.ShowDialog();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if(txtkategori.Text != "")
            {
                CategoryProduct newkategori = new CategoryProduct()
                {
                    ProductID = lbid.Text,
                    Nama_Product = txtkategori.Text
                };
                ppad.CategoryProducts.Add(newkategori);
                ppad.SaveChanges();
                loaddgv();
                txtkategori.Text = "";
                MessageBox.Show("Berhasil tambah kategori");
            }
            else
            {
                MessageBox.Show("Isi nama kategori");
            }
        }

        private void Fkategori_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            CategoryProduct updt = ppad.CategoryProducts.FirstOrDefault(Category => Category.ProductID == up);
            updt.ProductID = lbid.Text;
            updt.Nama_Product = txtkategori.Text;
            ppad.SaveChanges();
            idx = -1;
            up = "";
            loaddgv();
            MessageBox.Show("berhasil update kategori");
            btnedit.Enabled = false;
            btntambah.Enabled = true;
            btnhapus.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnedit.Enabled = true;
            btntambah.Enabled = false;
            
            idx = e.RowIndex;

            lbid.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            up = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnhapus.Enabled = true;
            idx = e.RowIndex;
            up = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (idx >= 0)
            {
                CategoryProduct deleted = ppad.CategoryProducts.FirstOrDefault(Category => Category.ProductID == up);
               
                ppad.CategoryProducts.Remove(deleted);
                ppad.SaveChanges();
                idx = -1;
                up = "";
                MessageBox.Show("Berhasil hapus kategori");
                lbid.Text = "";
                txtkategori.Text = "";
                btntambah.Enabled = true;
                btnhapus.Enabled = false;
                loaddgv();
            }
            else
            {
                MessageBox.Show("pilih data yang mau dihapus");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
