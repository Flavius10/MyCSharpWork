using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_the_Eggs_Game
{
    public partial class Form1 : Form
    {
        bool goleft;
        bool goright;
        int speed = 8;
        int score = 0;
        int missed = 0;
        Random rndY = new Random();
        Random rndX = new Random(); 
        PictureBox splash = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTick(object sender, EventArgs e)
        {
            label1.Text = "Eggs Caught " + score;
            label2.Text = "Eggs missed " + score;

            if (goleft == true && chicken.Left > 0)
            {
                chicken.Left -= 12;
                chicken.Image = Properties.Resources.chicken_normal2;
            }

            if (goright == true && chicken.Left + chicken.Width < this.ClientSize.Width)
            {
                chicken.Left += 12;
                chicken.Image = Properties.Resources.chicken_normal;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "Eggs")
                {
                    x.Top += speed;
                }

                if (x.Top + x.Height > this.ClientSize.Height)
                {
                    splash.Image = Properties.Resources.splash;
                    splash.Location = x.Location;
                    splash.Height = 59;
                    splash.Width = 60;
                    splash.BackColor = Color.Transparent;

                    this.Controls.Add(splash);

                    x.Top = rndY.Next(80, 300) * -1; 
                    x.Left = rndX.Next(5, this.ClientSize.Width - x.Width); 
                    missed++; 
                    chicken.Image = Properties.Resources.chicken_hurt;
                }

                if (x.Bounds.IntersectsWith(chicken.Bounds))
                {
                    x.Top = rndY.Next(100, 300) * -1; 
                    x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                    score++;
                }
                
                if (score >= 20)
                {
                    speed = 16;
                }
               

                if (missed > 5)
                {
                    gameTimer.Stop();
                                      
                    MessageBox.Show("Game Over!! We lost good Eggs" + "\r\n" + "Click OK to restart");
                    reset();
                }

            }
        }

        private void reset()
        {
            foreach (Control X in this.Controls)
            {
               
                if (X is PictureBox && (string)X.Tag == "Eggs")
                {
                   
                    X.Top = rndY.Next(80, 300) * -1; 
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); 
                }
            }
            chicken.Left = this.ClientSize.Width / 2; 
            chicken.Image = Properties.Resources.chicken_normal2; 
            score = 0; 
            missed = 0; 
            speed = 8; 
            goleft = false; 
            goright = false; 
            gameTimer.Start(); 
        }
    }
}
