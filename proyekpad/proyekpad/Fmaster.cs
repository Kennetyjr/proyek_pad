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
    public partial class Fmaster : Form
    {
        public Fmaster()
        {
            InitializeComponent();
        }

        private void Fmaster_Load(object sender, EventArgs e)
        {

        }    

        private void entryPenjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fpenjualan fp = new Fpenjualan();
            fp.ShowDialog();
        }

      

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fkategori fk = new Fkategori();
            fk.ShowDialog();
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fproduk fp = new Fproduk();
            fp.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fcustomer fc = new Fcustomer();
            fc.ShowDialog();
        }

      

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
