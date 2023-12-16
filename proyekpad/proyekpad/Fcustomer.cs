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

namespace proyekpad
{

    public partial class Fcustomer : Form
    {

        db_toko_alat_musikEntities db = new db_toko_alat_musikEntities();
        int idx = -1;
        string up = "";
        public Fcustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loaddgv()
        {
            var ld = from k in db.users     
                     select new
                     {
                         ID = k.us_id,
                         Nama = k.us_name,
                         Username = k.us_username,
                         Password = k.us_password,
                         Birth_Date = k.us_dateofbirth,
                         Status = k.us_status,
                         
                     };
            dataGridView1.DataSource = ld.ToList();
            var temp = dataGridView1.RowCount;
            txtid.Text = "US0" + (temp + 1).ToString();
        }
        private void Fcustomer_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnama.Text == "" || txtpassword.Text == "" || txtusername.Text == "" || cmbstatus.Text == "")
                {
                    ;
                    MessageBox.Show("Isi semua field");
                }
                else
                {
                    user usr = new user()
                    {
                        us_id = txtid.Text,
                        us_name = txtnama.Text,
                        us_username = txtusername.Text,
                        us_password = txtpassword.Text,
                        us_dateofbirth = dateTimePicker1.Value,
                        us_status = int.Parse(cmbstatus.Text),
                        us_priv = 1,
                   };
                    db.users.Add(usr);
                    db.SaveChanges();
                   
                    MessageBox.Show("Sukses");
                    txtnama.Text = "";
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    cmbstatus.Text = "";
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
            txtusername.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[idx].Cells[4].Value.ToString());
            cmbstatus.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            up = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        
    }

        private void btnedit_Click(object sender, EventArgs e)
        {
            user usr = db.users.FirstOrDefault(akn => akn.us_id == up);
            usr.us_id = txtid.Text;
            usr.us_name = txtnama.Text;
            usr.us_username = txtusername.Text;
            usr.us_password = txtpassword.Text;
            usr.us_dateofbirth = dateTimePicker1.Value;
            usr.us_status = int.Parse(cmbstatus.Text);
            usr.us_priv = 1;
            db.SaveChanges();
            idx = -1;
            up = "";
            
            MessageBox.Show("berhasil update");
            btnedit.Enabled = false;
            btntambah.Enabled = true;
            btnhapus.Enabled = false;
            txtnama.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            cmbstatus.Text = "";
            loaddgv();
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
                user deleted = db.users.FirstOrDefault(akn => akn.us_id == up);

                db.users.Remove(deleted);
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
