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
    public partial class Artificii : Form
    {
        string[] files = new string[33];
        int nr = -1;
        int secunde = 0;
        Label text;

        public Artificii()
        {
            InitializeComponent();
            Files();
            pbArtificii.SizeMode = PictureBoxSizeMode.StretchImage;
            text = new Label();
            text.Text = "FELICITARI, ATI CASTIGAT JOCUL";
            text.Location = new Point(280, 320);
            text.Size = new Size(250, 100);
            text.ForeColor = Color.Green;
            text.BackColor = Color.Transparent;
            text.Font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            pbArtificii.Controls.Add(text);
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void Files()
        {
            files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Artificii\");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr++;
            pbArtificii.Image = Image.FromFile(files[nr]);

            if (nr == files.Length - 1)
            {
                nr = -1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            secunde++;
            if (secunde == 2)
            {
                this.Hide();
                JocMemorie jm = new JocMemorie();
                jm.ShowDialog();
                this.Close();
            }
        }
    }
}
