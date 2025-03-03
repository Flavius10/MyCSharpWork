using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghicește_un_număr__varianta_cu_cronometru_
{
    public partial class Ghiceste : Form
    {

        Random rnd = new Random();
        private int numar;
        private int secunde = 0;
        public Ghiceste()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            txtAlege.Hide();
            txtTimp.Hide();
            btnEvalueaza.Hide();
            label4.Hide();
            GameTimer.Start();
            label5.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            numar = rnd.Next(1, 100);
            label2.Show();
            txtAlege.Show();
            txtTimp.Show();
            btnEvalueaza.Show();
            label3.Show();
            label4.Show();
            label5.Show();

        }

        private void GameTimerTick(object sender, EventArgs e)
        {
            secunde++;
            txtTimp.Text = secunde.ToString();
        }

        private void btnEvalueaza_Click(object sender, EventArgs e)
        {
            int numar1 = Int32.Parse(txtAlege.Text);

            if (numar1 == numar)
            {
                GameTimer.Stop();
                MessageBox.Show("FELICITARI! AI GHICIT IN " + secunde.ToString() + " SECUNDE", "GHICIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (numar1 > numar)
                    label5.Text = "Numar mai mic";
                else
                    label5.Text = "Numar mai mare";

                txtAlege.Text = string.Empty;
            }
        }
    }
}
