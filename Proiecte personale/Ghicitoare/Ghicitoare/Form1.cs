using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghicitoare
{
    public partial class Form1 : Form
    {
        private int numar;
        private int numar_random;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            btnVerifica.Enabled = false;
            txtNumarGhicit.Focus(); 
        }

        private void btnGhiceste_Click(object sender, EventArgs e)
        {
            btnVerifica.Enabled = true;
            numar = Int32.Parse(txtNumarGhicit.Text);
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numar_random = rnd.Next(1, 100);

            txtNumarRandom.Text = numar_random.ToString();

            if (numar_random == numar)
            {
                MessageBox.Show("Ai ghicit numarul!");
                score += 1000;

                lblScore.Text = score.ToString();

                txtNumarGhicit.Text = string.Empty;
                txtNumarRandom.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Nu ai ghicit numarul!");
                score -= 10;

                lblScore.Text = score.ToString();

                txtNumarGhicit.Text = string.Empty;
                txtNumarRandom.Text = string.Empty;
            }
        }

        private void btnReseteaza_Click(object sender, EventArgs e)
        {
            txtNumarGhicit.Text = string.Empty;
            txtNumarRandom.Text = string.Empty;
            btnVerifica.Enabled = false;
            score = 0;
            lblScore.Text = string.Empty;
        }
    }
}
