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
        public Fpegawai()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Fmaster fm = new Fmaster();
            fm.ShowDialog();
        }
    }
}
