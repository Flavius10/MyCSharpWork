using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatorie_in_timp_si_spatiu
{
    public partial class Turist : Form
    {
        public Turist()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turistiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            TuristValidare tv = new TuristValidare();
            tv.ShowDialog();
        }
    }
}
