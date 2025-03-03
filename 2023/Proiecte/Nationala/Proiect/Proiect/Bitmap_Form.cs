using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Bitmap_Form : Form
    {
        Bitmap bmp;
        Graphics g;
        int px = 0, py = 0;

        public Bitmap_Form()
        {
            InitializeComponent();
            
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            SmoothingMode smoothingMode = SmoothingMode.AntiAlias;
            g.SmoothingMode = smoothingMode;
            g.DrawEllipse(new Pen(Color.Red, 2f), new RectangleF(200, 200, 200,200));
            pictureBox1.Image = bmp;

            pictureBox1.MouseClick += MouseClick;

        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (px != 0 && py != 0)
            {
                g.DrawwLine
            }
        }
    }
}
