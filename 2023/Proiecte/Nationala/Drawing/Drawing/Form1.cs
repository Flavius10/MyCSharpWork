using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += Paint1;
        }

        public void Paint1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Graphics g;
            g = pictureBox1.CreateGraphics();
            e.Graphics.DrawEllipse(new Pen(Color.Red), new RectangleF(100, 100, 100, 100));
            g.DrawEllipse(new Pen(Color.Red), new RectangleF(100, 200, 100, 100));
        }
    }
}
