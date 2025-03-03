using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenare_PictureBox
{
    public partial class Desenare : Form
    {
        int dx = 1, dy = 0;

        Random rx = new Random();
        Random ry = new Random();
        PictureBox obiect;
        PictureBox obiect1;
        int xp, yp;
        Timer timer_miscare = new Timer();
        int xpr, ypr;

        private void Desenare_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.Left)
            {
                dx = -1;
                dy = 0;
            }

            if (e.KeyCode == Keys.Right)
            {
                dx = 1;
                dy = 0;
            }
        }

        public Desenare()
        {
            InitializeComponent();

            timer_miscare.Enabled = true;
            timer_miscare.Interval = 100;
            timer_miscare.Tick += TimerTick;

            panel1.BackColor = Color.Black;
            xp = rx.Next(35) * 20;
            yp = ry.Next(25) * 20;

            xpr = rx.Next(35) * 20;
            ypr = ry.Next(25) * 20;

            obiect = new PictureBox();
            obiect1 = new PictureBox();

            obiect.Location = new Point(xp, yp);
            obiect1.Location = new Point(xpr, ypr);

            obiect1.Size = new Size(20, 20);
            obiect.Size = new Size(20, 20);

            obiect.BackColor = Color.White;
            obiect1.BackColor = Color.Red;

            panel1.Controls.Add(obiect);
            panel1.Controls.Add(obiect1);
        }

        public void TimerTick(object sender, EventArgs e)
        {
            obiect.Location = new Point(obiect.Location.X + 20 * dx, obiect.Location.Y + 10 * dy);

            if (obiect.Location.X > 800)
                obiect.Location = new Point(0, obiect.Location.Y);
            if (obiect.Location.X < 0)
                obiect.Location = new Point(800, obiect.Location.Y);

            if (obiect.Location.Y >= 450)
                obiect.Location = new Point(obiect.Location.X, 0);
            if (obiect.Location.Y < 0)
                obiect.Location = new Point(obiect.Location.X, 450);

            if (obiect.Location == obiect1.Location)
            {
                timer_miscare.Enabled = false;
                this.Hide();
                CropForm cf = new CropForm();
                cf.ShowDialog();
                this.Close();
            }
        }
    }
}
