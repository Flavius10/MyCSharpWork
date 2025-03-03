using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void decupeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void lipesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
        }

        private void copiazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void decupeazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void lipesteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
