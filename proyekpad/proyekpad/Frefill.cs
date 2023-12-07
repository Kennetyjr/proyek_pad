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
    public partial class Frefill : Form
    {
        public Frefill()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Fmaster fm = new Fmaster();
            fm.ShowDialog();
            Close();
        }

        private void Frefill_Load(object sender, EventArgs e)
        {

        }
    }
}
