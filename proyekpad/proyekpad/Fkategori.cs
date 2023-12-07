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
        proyekpadEntities1 ppad = new proyekpadEntities1();
        int idx = -1;
        long up = -1;
        public Fkategori()
        {
            InitializeComponent();
        }

        private void loaddgv()
        {
            var ld = from k in ppad.Categories
                     select new
                     {
                         ID = k.ProdukCategotyID,
                         Nama_Kategori = k.Name,
                     };
            dataGridView1.DataSource = ld.ToList();
            var temp = dataGridView1.RowCount;
            lbid.Text = (temp + 1).ToString();
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
                Category newkategori = new Category()
                {
                    ProdukCategotyID = int.Parse(lbid.Text),
                    Name = txtkategori.Text
                };
                ppad.Categories.Add(newkategori);
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
            Category updt = ppad.Categories.FirstOrDefault(Category => Category.ProdukCategotyID == up);
            updt.ProdukCategotyID = int.Parse(lbid.Text);
            updt.Name = txtkategori.Text;
            ppad.SaveChanges();
            idx = -1;
            up = -1;
            loaddgv();
            MessageBox.Show("berhasil update kategori");
            btnedit.Enabled = false;
            btntambah.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnedit.Enabled = true;
            btntambah.Enabled = false;
            
            idx = e.RowIndex;

            lbid.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtkategori.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            up = Int64.Parse(dataGridView1.Rows[idx].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnhapus.Enabled = true;
            idx = e.RowIndex;
            up = Int64.Parse(dataGridView1.Rows[idx].Cells[0].Value.ToString());
            
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (idx >= 0)
            {
                Category deleted = ppad.Categories.FirstOrDefault(Category => Category.ProdukCategotyID == up);
                //Untuk Delete data dari Entity model
                ppad.Categories.Remove(deleted);
                ppad.SaveChanges();
                idx = -1;
                up = -1;
                MessageBox.Show("Berhasil hapus kategori");
                lbid.Text = "";
                txtkategori.Text = "";
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
