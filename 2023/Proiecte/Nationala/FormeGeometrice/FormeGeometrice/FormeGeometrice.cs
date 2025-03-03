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

namespace FormeGeometrice
{
    public partial class Geometrie : Form
    {

        PictureBox square;
        PictureBox circle;
        Random r = new Random();
        int dx = 0;
        int dy = 0, dy1 = 0;
        private int cnt_square = 0;
        private int cnt_circle = 0;
        private int dx_square, dy_square;
        private int dx_circle, dy_circle;
        int punctaj_patrat = 0;
        int punctaj_cerc = 0;
        bool paint = false;
        Point py = new Point();
        Point px = new Point();
        int index = 0;
        Graphics g;

        public Geometrie()
        {
            InitializeComponent();

            square = new PictureBox();
            circle = new PictureBox();

            square.Location = new Point(200, 0);
            dx_square = 200;
            dy_square = 0;
            circle.Location = new Point(800, 0);
            dx_circle = 800;
            dy_circle = 0;
            circle.Size = new Size(100, 100);
            square.Size = new Size(100, 100);

            square.BackColor = Color.LightYellow;
            circle.BackColor = Color.LightYellow;

           // square.Paint += PictureBoxSquare_Paint;
           // circle.Paint += PictureBoxCircle_Paint;

            square.MouseDown += PictureBox_MouseDown;
            circle.MouseDown += PictureBox_MouseDown;
            circle.MouseUp += PictureBox_MouseUp;
            circle.MouseMove += PictureBox_MouseMove;
            square.MouseUp += PictureBox_MouseUp;
            square.MouseMove += PictureBox_MouseMove;

            pictureBox1.Click += PictureBox_Click;

            pictureBox1.Controls.Add(square);
            pictureBox1.Controls.Add(circle);

            dy = r.Next(3, 9);
            dy1 = r.Next(3, 9);
        }

        public void PictureBoxSquare_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(0, 0, 80, 80));
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(new Pen(Color.Red), px, py);
                    py = px;
                }
            }
            pb.Refresh();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }


        public void PictureBoxCircle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawEllipse(new Pen(Color.Orange), new RectangleF(0, 0, 80, 80));
        }

        public void PictureBox_Click(object sender, EventArgs e)
        {
                timer1.Enabled = true;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            cnt_square++;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            cnt_circle++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dy = r.Next(3, 10);
            dy1 = r.Next(3, 10);

            if (600 - square.Location.Y < 100)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Paratul a ajuns primul", "PATRAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (cnt_square > 0)
                    {
                        punctaj_patrat += 10;
                        lblSquare.Text = "Punctaj:" + ' ' + punctaj_patrat.ToString();
                    }

                    if (cnt_circle > 0)
                    {
                        punctaj_patrat += 10;
                        lblSquare.Text = "Punctaj:" + ' ' + punctaj_patrat.ToString();
                    }

                    square.Location = new Point(dx_square, dy_square);
                    circle.Location = new Point(dx_circle, dy_circle);
                    cnt_circle = 0;
                    cnt_square = 0;
            }

            if (cnt_circle > 0)
                if (600 - circle.Location.Y < 100)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Cercul a ajuns primul", "CERC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (cnt_circle > 0)
                    {
                        punctaj_cerc += 10;
                        lblCircle.Text = "Punctaj:" + ' ' + punctaj_cerc.ToString();
                    }

                    if (cnt_square > 0)
                    {
                        punctaj_cerc += 10;
                        lblCircle.Text = "Punctaj:" + ' ' + punctaj_cerc.ToString();
                    }

                    square.Location = new Point(dx_square, dy_square);
                    circle.Location = new Point(dx_circle, dy_circle);
                    
                    cnt_circle = 0;
                    cnt_square = 0;
                }

            if (cnt_square > 0 || cnt_circle > 0)
                if ((600 - circle.Location.Y == 600 - square.Location.Y) && (600 - circle.Location.Y < 100) && (600 - square.Location.Y < 100))
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Cercul si patratul sunt la egal", "PATRAT SI CERC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (cnt_square > 0 || cnt_circle > 0)
                    {
                        punctaj_patrat += 10;
                        punctaj_cerc += 10;
                        lblSquare.Text = "Punctaj:" + ' ' + punctaj_patrat.ToString();
                        lblCircle.Text = "Punctaj:" + ' ' + punctaj_patrat.ToString();
                    }
                    square.Location = new Point(dx_square, dy_square);
                    circle.Location = new Point(dx_circle, dy_circle);

                    cnt_circle = 0;
                    cnt_square = 0;

                }

            square.Location = new Point(square.Location.X, square.Location.Y + dy);
            circle.Location = new Point(circle.Location.X, circle.Location.Y + dy1);
        }
    }
}
