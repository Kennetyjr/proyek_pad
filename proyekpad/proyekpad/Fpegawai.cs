using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyekpad
{
    public partial class Fpegawai : Form
    {
        proyekpadEntities ppad = new proyekpadEntities();
        int idx = -1;
        string up = "";
        public Fpegawai()
        {
            InitializeComponent();
        }
        
        private void loaddgv()
        {
            var ld = from k in ppad.Employees
                     select new
                     {
                         ID = k.EmployeeID,
                         Nama_Employee = k.Nama_Employee,
                         Password = k.Password_Employee,
                         Gender = k.Gender,
                     };
            dataGridView1.DataSource = ld.ToList();
            var temp = dataGridView1.RowCount;
            txtemployeeid.Text = "EID0" + (temp + 1).ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            if(txtnama.Text == "" || cmbgender.Text == "" || txtnama.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Semua field harus diisi");
            }
            else
            {
                Employee emp = new Employee() 
                {
                    EmployeeID = txtemployeeid.Text,
                    Nama_Employee = txtnama.Text,
                    Password_Employee = txtpassword.Text,
                    Gender = cmbgender.Text,
                };

                ppad.Employees.Add(emp);
                ppad.SaveChanges();
                txtnama.Text = "";
                txtpassword.Text = "";
                cmbgender.Text = "";
                loaddgv();
                MessageBox.Show("Berhasil tambah Employee");
            }
        }

        private void Fpegawai_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Employee emp = ppad.Employees.FirstOrDefault(Employee => Employee.EmployeeID == up);

            emp.EmployeeID = txtemployeeid.Text;
            emp.Nama_Employee = txtnama.Text;
            emp.Password_Employee = txtpassword.Text;
            emp.Gender = cmbgender.Text;
            ppad.SaveChanges();
            up = "";
            idx = -1;
            loaddgv();
            MessageBox.Show("berhasil update");
            btntambah.Enabled = true;
            txtemployeeid.Enabled = false;
            btnedit.Enabled = false;
            btnhapus.Enabled = false;
            txtemployeeid.Text = "";
            txtnama.Text = "";
            txtpassword.Text = "";
            cmbgender.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btntambah.Enabled = false;
            txtemployeeid.Enabled = true;
            btnedit.Enabled = true;
            

            idx = e.RowIndex;

            txtemployeeid.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtnama.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            cmbgender.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();

            up = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnhapus.Enabled = true;
            btntambah.Enabled = false;
            idx = e.RowIndex;
            up = dataGridView1.Rows[idx].Cells[0].Value.ToString();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (idx >= 0)
            {
                Employee deleted = ppad.Employees.FirstOrDefault(Employee => Employee.EmployeeID == up);

                ppad.Employees.Remove(deleted);
                ppad.SaveChanges();
                idx = -1;
                up = "";
                MessageBox.Show("Berhasil hapus employee");
                txtemployeeid.Text = "";
                txtnama.Text = "";
                txtpassword.Text = "";
                cmbgender.Text = "";
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
