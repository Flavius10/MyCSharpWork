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

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer_Stop;
        }

        PictureBox joc = new PictureBox();
        PictureBox Snake = new PictureBox();
        PictureBox Mancare = new PictureBox();
        PictureBox[] Coada = new PictureBox[1001];
        Label lblPunctaj = new Label();

        int dx = 1;
        int dy = 0;
        int cl = 0;
        int punctaj = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 600;
            this.Width = 700;

            lblPunctaj.Text = "punctaj";

            joc.Height = joc.Width = 500;
            joc.Location = new Point(30, 30);
            joc.BackColor = Color.Black;
            this.Controls.Add(joc);

            Random r = new Random();
            int x = r.Next(24) * 20;
            int y = r.Next(24) * 20;

            Snake.Height = Snake.Width = 18;
            Snake.Location = new Point(x, y);
            Snake.BackColor = Color.Green;
            joc.Controls.Add(Snake);

            int x1 = r.Next(24) * 20;
            int y1 = r.Next(24) * 20;

            Mancare.Height = Mancare.Width = 18;
            Mancare.BackColor = Color.Red;
            Mancare.Location = new Point(x1, y1);
            joc.Controls.Add(Mancare);
            timer1.Enabled = true;

            lblPunctaj.Font = new Font("Arial", 12);
            lblPunctaj.Location = new Point(560, 30);
            this.Controls.Add(lblPunctaj);


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                dx = 0;
                dy = -1;
            }

            if (e.KeyCode == Keys.Down)
            {
                dx = 0;
                dy = 1;
            }

            if ( e.KeyCode == Keys.Right)
            {
                dx = 1;
                dy = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                dx = -1;
                dy = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = cl; i >= 2; --i)
            {
                Coada[i].Location = Coada[i - 1].Location;
            }

            if (cl > 0)
                Coada[1].Location = Snake.Location;

            Snake.Location = new Point(Snake.Location.X + dx * 20, Snake.Location.Y + dy * 20);

            for (int i = 1; i <= cl; ++i)
            {
                if (Snake.Location == Coada[i].Location)
                {
                    timer1.Enabled = false;
                }

            }
            
            int x1 = Snake.Location.X;
            int y1 = Snake.Location.Y;

            if (x1 >= 500)
                x1 = 0;

            if (x1 < 0)
                x1 = 480;

            if (y1 >= 500)
                y1 = 0;

            if (y1 < 0)
                y1 = 480;

            Snake.Location = new Point(x1, y1);

            if (Snake.Location == Mancare.Location)
            {
                Random r = new Random();
                int x = r.Next(24) * 20;
                int y = r.Next(24) * 20;
                Mancare.Location = new Point(x, y);
                Coada[++cl] = new PictureBox();
                Coada[cl].Location = Snake.Location;
                Coada[cl].BackColor = Color.LightGreen;
                Coada[cl].Height = Coada[cl].Width = 18;
                joc.Controls.Add(Coada[cl]);
                punctaj += 10;
                lblPunctaj.Text = punctaj.ToString() + " de puncte";
            }

        }

        public void Timer_Stop(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                MessageBox.Show("Punctajul dumneavoastra este " + punctaj.ToString(), "Ati pierdut!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
