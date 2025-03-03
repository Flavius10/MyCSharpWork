using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opacity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = 1 - (double)trackBar1.Value / 10;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            this.Opacity = 1 - (double)domainUpDown1.SelectedIndex / 10;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = 1 - (double)numericUpDown1.Value / 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;

            trackBar1.Value = 0;
            numericUpDown1.Value = 0;
            domainUpDown1.Text = "Opacitate 100%";
        }
    }
}
