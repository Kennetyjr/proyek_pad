using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyekpad
{
    public partial class Fproduk : Form
    {
        db_toko_alat_musikEntities db = new db_toko_alat_musikEntities();
        int idx = -1;
        string up = "";
        public Fproduk()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void loaddgv()
        {
            var ld = from k in db.alatmusiks
                     select new
                     {
                         ID = k.al_id,
                         Nama_Alat_Musik = k.al_name,
                         Harga = k.al_price,
                         Stok = k.al_stock,
                     };
            dataGridView1.DataSource = ld.ToList();
            var temp = dataGridView1.RowCount;
            txtid.Text = "AL0" + (temp + 1).ToString();
        }

        private void Fproduk_Load(object sender, EventArgs e)
        {
            loaddgv();


            cmbbrand.Items.Clear();
            var dtbrand = db.brands.ToList();
            for (int i = 0; i < dtbrand.Count; i++)
            {
                cmbbrand.Items.Add(dtbrand[i].br_name);
            }

            cmbinstrument.Items.Clear();
            var dtinstru = db.instruments.ToList();
            for (int i = 0; i < dtinstru.Count; i++)
            {
                cmbinstrument.Items.Add(dtinstru[i].in_name);
            }
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnama.Text == "" || txtharga.Text == "" || int.Parse(txtharga.Text) < 0 ||
                    cmbstatus.Text == "" || cmbbrand.Text == "" || cmbinstrument.Text == "")
                {
                    MessageBox.Show("isi semua field");
                }
                else
                {
                    alatmusik newalat = new alatmusik()
                    {
                        al_id = txtid.Text,
                        al_name = txtnama.Text,
                        al_description = "no description",
                        al_price = decimal.Parse(txtharga.Text),
                        al_stock = Convert.ToInt32(txtstok.Text),
                        al_status = Convert.ToInt32(cmbstatus.Text),
                        al_br_id = cmbbrand.Text,
                        al_in_id = cmbinstrument.Text,
                    };

                    db.alatmusiks.Add(newalat);
                    db.SaveChanges();
                    MessageBox.Show("berhasil tambah produk");
                    txtnama.Text = "";
                    txtharga.Text = "";
                    txtstok.Text = "";
                    cmbstatus.Text = "";
                    cmbbrand.Text = "";
                    cmbinstrument.Text = "";
                    loaddgv();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnedit.Enabled = true;
            btntambah.Enabled = false;

            idx = e.RowIndex;

            txtid.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtnama.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            txtharga.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            txtharga.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            cmbstatus.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            cmbbrand.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
            cmbinstrument.Text = dataGridView1.Rows[idx].Cells[7].Value.ToString();

            up = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            alatmusik al = db.alatmusiks.FirstOrDefault(alatm => alatm.al_id == up);
            al.al_id = txtid.Text;
            al.al_name = txtnama.Text;
            al.al_description = "no description";
            al.al_price = Convert.ToInt32(txtharga.Text);
            al.al_stock = Convert.ToInt32(txtharga.Text);
            al.al_status = Convert.ToInt32(cmbstatus.Text);
            al.al_br_id = cmbbrand.Text;
            al.al_in_id = cmbinstrument.Text;
            db.SaveChanges();
            loaddgv();
            idx = -1;
            up = "";

            MessageBox.Show("berhasil update");
            btnedit.Enabled = false;
            btntambah.Enabled = true;
            btnhapus.Enabled = false;

            txtnama.Text = "";
            txtharga.Text = "";
            txtstok.Text = "";
            cmbstatus.Text = "";
            cmbbrand.Text = "";
            cmbinstrument.Text = "";
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
                alatmusik deleted = db.alatmusiks.FirstOrDefault(alatm => alatm.al_id == up);

                db.alatmusiks.Remove(deleted);
                db.SaveChanges();
                idx = -1;
                up = "";
                MessageBox.Show("Berhasil hapus");
                
                btntambah.Enabled = true;
                btnhapus.Enabled = false;
                loaddgv();
            }
            else
            {
                MessageBox.Show("pilih data yang mau dihapus");
            }
        }
    }
}
