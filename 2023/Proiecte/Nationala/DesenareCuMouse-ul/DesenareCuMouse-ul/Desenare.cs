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

namespace DesenareCuMouse_ul
{
    public partial class Desenare : Form
    {
        Point px, py;
        bool paint = false;
        int cnt;
        Pen pen = new Pen(Color.Black, 2f);
        Graphics g;
        Bitmap bmp;

        public Desenare()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;

            pictureBox1.MouseDown += PictureBox_MouseDown;
            pictureBox1.MouseMove += PictureBox_MouseMove;
            pictureBox1.MouseUp += PictureBox_MouseUp;
        }

        public void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        public void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (cnt == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt = 1;
        }
    }
}
