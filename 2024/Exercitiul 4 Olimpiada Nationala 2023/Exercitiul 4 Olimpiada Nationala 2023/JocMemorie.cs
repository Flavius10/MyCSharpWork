using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul_4_Olimpiada_Nationala_2023
{
    public partial class JocMemorie : Form
    {
        int n = 2;
        PictureBox[] pictures;
        int secunde = 100;
        public JocMemorie()
        {
            n++;
            InitializeComponent();
            CreateGUI();
            timer1.Enabled = true;
        }

        private void CreateGUI()
        {
            pictures = new PictureBox[n];

            for(int i = 0; i < n; ++i)
            {
                pictures[i] = new PictureBox()
                {
                    Location = new Point(100 + i * 150, 100),
                    Size = new Size(100, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Red
                };

                this.Controls.Add(pictures[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artificii a = new Artificii();
            a.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secunde--;
            lblSecunde.Text = "Numar secunde:" + ' ' + secunde.ToString();
        }

        private void 

    }
}
