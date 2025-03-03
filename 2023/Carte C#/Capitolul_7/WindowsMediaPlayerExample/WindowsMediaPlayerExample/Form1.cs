using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaPlayerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                wmp.settings.autoStart = false;

                wmp.URL = openFileDialog1.FileName;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.pause();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
        }
    }
}
