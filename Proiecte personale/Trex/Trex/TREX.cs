using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trex
{
    public partial class TREX : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rnd = new Random();
        int position;
        bool GameOver = false;

        public TREX()
        {
            InitializeComponent();
            GameReset();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Trex1.Top += jumpSpeed;
            Score.Text = " Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if(jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (Trex1.Top > 366 && jumping == false)
            {
                force = 12;
                Trex1.Top = 367;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (Trex1.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        Trex1.Image = Properties.Resources.dead;
                        Score.Text = "Prees R to restart the game!";
                        GameOver = true;
                    }
                }
            }

            if(score > 5)
            {
                obstacleSpeed = 15;
            }


        }

        private void TREX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void TREX_KeyUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && GameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            Score.Text = "Score: " + score;
            Trex1.Image = Properties.Resources.running;
            GameOver = false;
            Trex1.Top = 367;

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rnd.Next(500, 800) + (x.Width * 10);

                    x.Left = position;

                }
            }

            gameTimer.Start();
        }
    }
}
