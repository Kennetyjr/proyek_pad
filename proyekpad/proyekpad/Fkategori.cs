using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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
        db_toko_alat_musikEntities db = new db_toko_alat_musikEntities();
        int idx = -1;
        string up = "";
        public Fkategori()
        {
            InitializeComponent();
        }

        private void loaddgv()
        {
            var ld = from k in db.instruments
                     select new
                     {
                         ID = k.in_id,
                         Nama_Kategori = k.in_name,
                     };
            dataGridView1.DataSource = ld.ToList();
            var temp = dataGridView1.RowCount;
            lbid.Text = "IN0"+(temp + 1).ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkategori.Text != "")
                {
                    instrument newinstru = new instrument()
                    {
                        in_id = lbid.Text,
                        in_name = txtkategori.Text
                    };
                    db.instruments.Add(newinstru);
                    db.SaveChanges();
                    
                    txtkategori.Text = "";
                    MessageBox.Show("Berhasil tambah");
                    loaddgv();
                }
                else
                {
                    MessageBox.Show("Isi semua field");
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show(
                            $"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            
        }

        private void Fkategori_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            instrument updt = db.instruments.FirstOrDefault(intrum => intrum.in_id == up);
            updt.in_id = lbid.Text;
            updt.in_name = txtkategori.Text;
            db.SaveChanges();
            idx = -1;
            up = "";
            
            MessageBox.Show("berhasil update");
            btnedit.Enabled = false;
            btntambah.Enabled = true;
            btnhapus.Enabled = false;
            txtkategori.Text = "";
            loaddgv();
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
                instrument deleted = db.instruments.FirstOrDefault(Category => Category.in_id == up);
               
                db.instruments.Remove(deleted);
                db.SaveChanges();
                idx = -1;
                up = "";
                MessageBox.Show("Berhasil hapus");
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
