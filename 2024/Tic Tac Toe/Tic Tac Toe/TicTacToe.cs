using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        Player currentPlayer;
        public TicTacToe()
        {
            InitializeComponent();
        }

        public enum Player
        {
            X, O
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            btn1.BackColor = Color.LightGreen;
            CheckBox();
            AiTimer.Start();
        }

        private void resetGame(object sender, EventArgs e)
        {
            label1.Text = "??";
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "?";
                    ((Button)x).BackColor = default(Color);
                }
            }
        }
            private void playAI(object sender, EventArgs e)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Text == "?" && x.Enabled)
                    {
                        x.Enabled = false;
                        currentPlayer = Player.O;
                        x.Text = currentPlayer.ToString();
                        x.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        AiTimer.Stop();
                        Check();
                        break;
                    }
                    else
                    {
                        AiTimer.Stop();
                    }
                }
            }
            private void Check()
            {
                if (btn1.Text == "X" && btn2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
                {
                    WON();
                    label1.Text = "X Wins";
                }
                else if (
                button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                87
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O" )
{
                WON();
                label1.Text = "O Wins";
            }
        }
        private void WON()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = false;
                    ((Button)x).BackColor = default(Color);
                }
            }
        }
    }
}
