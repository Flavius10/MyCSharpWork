using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint_F
{
    public partial class Paint_F : Form
    {
        Bitmap bmp;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;
        ColorDialog cd = new ColorDialog();
        Color culoare;
        Color new_color;

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(pen, cx, cy, sx, sy);
                }

                if (index == 4)
                {
                    g.DrawRectangle(pen, cx, cy, sx, sy);
                }

                if (index == 5)
                {
                    g.DrawLine(pen, cx, cy, x, y);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bmp;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            culoare = cd.Color;
            pic_color.BackColor = culoare;
            pen.Color = culoare;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            pen.Color = new_color;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }

            pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            //sx = x - cx;
            //sy = y - cy;

                if (index == 3)
                {
                    g.DrawEllipse(pen, cx, cy, sx, sy);
                }

                if (index == 4)
                {
                    g.DrawRectangle(pen, cx, cy, sx, sy);
                }

                if (index == 5)
                {
                    g.DrawLine(pen, cx, cy, x, y);
                }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bmp, point.X, point.Y, new_color);

            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        public Paint_F()
        {
            InitializeComponent();

            bmp = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pic.Image = bmp;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Image.Width / pb.Width;
            float py = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);

            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));

            bm.SetPixel(x, y, new_color);
            if (old_color == new_color)
            {
                return;
            }

            while(pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();

                if (pt.X >= 0 && pt.Y >= 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1) 
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);

                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_color);

                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);

                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_color);
                }
            }
        }
    }
}
