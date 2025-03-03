using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Player currentPlayer;
        int cnt_x = 0;
        int cnt_o = 0;

        public Form1()
        {
            InitializeComponent();
            btnResetarePuncte.BackColor = Color.FromArgb(255, 215, 0);
        }

        public enum Player
        {
            X, 
            O
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.FromArgb(255, 71, 26);
            Check();
            AITimer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblWin.Text = "??";

            foreach(Control control in this.Controls)
            {
                if (control is Button && control.Tag == "play")
                {
                    ((Button)control).Enabled = true;
                    ((Button)control).Text = "?";
                    ((Button)control).BackColor = default(Color);
                }
            }
        }

        private void playAi(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text == "?" && control.Enabled)
                {
                    control.Enabled = false;
                    currentPlayer = Player.O;
                    control.Text = currentPlayer.ToString();
                    control.BackColor = Color.LightGoldenrodYellow;
                    AITimer.Stop();
                    Check();
                    break;
                }
                else
                {
                    AITimer.Stop();
                }
            }
        }

        private void Check()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
                btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
                btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" ||
                btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
                btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
                btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
                btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
                btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                WON();
                lblWin.Text = "X Wins";
                cnt_x++;
                lblX.Text = "X: " + cnt_x.ToString();
              
            }

            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
                btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
                btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" ||
                btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
                btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
                btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" ||
                btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
                btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                WON();            
                lblWin.Text = "O Wins";
                cnt_o++;
                lblO.Text = "O: " + cnt_o.ToString();
            }
        }

        private void WON()
        {
            foreach(Control control in this.Controls) 
            { 
                if (control is Button && control.Tag == "play")
                {
                    ((Button)control).Enabled = false;
                    ((Button)control).BackColor = default(Color);
                }
            }

        }

        private void btnResetarePuncte_Click(object sender, EventArgs e)
        {
            cnt_x = 0;
            cnt_o = 0;

            lblX.Text = "X: " + cnt_x.ToString();
            lblO.Text = "O: " + cnt_o.ToString();
        }
    }
}
