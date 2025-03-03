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

namespace DesenMouse
{
    public partial class DesenMouse : Form
    {
        Point px, py;
        Bitmap bmp;
        int index = 0;
        bool paint = false;
        Graphics g;

        public DesenMouse()
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

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        private void btnDesen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(new Pen(Color.Black, 2f), px, py);
                    py = px;
                }

            }

            pictureBox1.Invalidate();
        }

        }
    }
