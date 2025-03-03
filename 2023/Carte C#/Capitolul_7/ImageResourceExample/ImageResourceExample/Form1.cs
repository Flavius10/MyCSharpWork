using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResourceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int zoom;

        private void button1_Click(object sender, EventArgs e)
        {
            zoom = 2;

            int W = pictureBox1.Size.Width + zoom;
            int H = pictureBox1.Size.Height + zoom;

            pictureBox1.ClientSize = new Size(W, H);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoom = -2;

            int W = pictureBox1.Size.Width + zoom;
            int H = pictureBox1.Size.Height + zoom;

            pictureBox1.ClientSize = new Size(W, H);
        }
    }
}
