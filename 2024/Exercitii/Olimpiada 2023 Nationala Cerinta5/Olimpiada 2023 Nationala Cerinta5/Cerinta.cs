using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpiada_2023_Nationala_Cerinta5
{
    public partial class Cerinta : Form
    {

        int nr_secunde = 100;
        string path = Directory.GetCurrentDirectory() + @"\Imagini";
        string[] files;
        string file1, file2;
        string nume1, nume2;
        PictureBox bila;
        int dx = 0;
        int dy = -1;
        int nr = 0;
        Label[] lbl;
        string[] litere_cuvinte;
        int nr_litere = 0;
        bool ok_litere = true;
        string cuvant;
        int nr_lit = 0;

        public Cerinta()
        {
            InitializeComponent();
            files = Directory.GetFiles(path);
            Files1();

            nr = nume1.Length + nume2.Length;

            bila = new PictureBox();
            bila.Size = new Size(30, 30);
            bila.SizeMode = PictureBoxSizeMode.StretchImage;
            bila.Image = Image.FromFile("ball.png");

            pbPanou.Controls.Add(bila);

            bila.Location = new Point(400,270);

            litere_cuvinte = new string[nr];

            for (int i = 0; i < nume1.Length; i++)
            {
                litere_cuvinte[nr_litere++] = nume1[i].ToString();
            }

            for (int i = 0; i < nume2.Length; i++)
            {
                litere_cuvinte[nr_litere++] = nume2[i].ToString();
            }


            CreateGUI();

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void CreateGUI()
        {
            lbl = new Label[nr];

            for (int i = nr - 1; i >= 0; --i)
            {
                lbl[i] = new Label()
                {
                    Text = litere_cuvinte[i].ToString(),
                    Size = new Size(30, 30),
                    Location = new Point(150 + i * 50,20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20, FontStyle.Bold)
                };
                pbPanou.Controls.Add(lbl[i]);
            }
        }

        private void Files1()
        {
            var random = new Random();
            file1 = files[random.Next(files.Length)];
            file2 = files[random.Next(files.Length)];

            nume1 = Path.GetFileNameWithoutExtension(file1);
            nume2 = Path.GetFileNameWithoutExtension(file2);

            pb1.Image = Image.FromFile(file1);
            pb2.Image = Image.FromFile(file2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr_secunde--;
            lblSecunde.Text = "Timp: " + nr_secunde.ToString() + " secunde";
        }

        private void lblCuvant_TextChanged(object sender, EventArgs e)
        {
            nr_lit++;
            cuvant = lblCuvant.Text;
            label1.Text = cuvant;   
            string cuvant1 = string.Empty;

            for (int i = 0; i < nr_lit; ++i)
            {
                cuvant1 = nume1[i].ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bila.Location = new Point(bila.Location.X + dx * 10, bila.Location.Y + dy * 10);
            if (bila.Location.Y <= 0)
            {
                bila.Location = new Point(400, 270);
            }

            for (int i = 0; i < nr; ++i)
            {
                if (bila.Location == lbl[i].Location)
                {
                    lblCuvant.Text += lbl[i].Text;
                    lbl[i].Text = string.Empty; 
                }
            }

            if (lblCuvant.Text == nume1)
            {
                pb1.Image = null;
                lblCuvant.Text = string.Empty;
            }

            if (lblCuvant.Text == nume2)
            {
                pb2.Image = null;
                lblCuvant.Text= string.Empty;
            }

            if (nr_secunde == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Game over", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }

        private void Cerinta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                dx = 0;
                dy = -1;
            }

            if (e.KeyCode == Keys.A)
            {
                dx = -1;
                dy = 0;
            }

            if (e.KeyCode == Keys.D)
            {
                dx = 1;
                dy = 0;
            }
        }
    }
}
