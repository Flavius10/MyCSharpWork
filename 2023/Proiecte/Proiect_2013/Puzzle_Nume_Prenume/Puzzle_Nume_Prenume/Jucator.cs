using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Nume_Prenume
{
    public partial class FormJucator : Form
    {
        public FormJucator()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string ImgPath = "";
        public string final = "";
        private void btn4_Click(object sender, EventArgs e)
        {
            final = btn4.Text;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            final = btn9.Text;
        }
        private void jocNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"C:\Folders\Info\C#\Proiect_2013\c#\OTI_2013_C#\Resurse\Img\" + final;

            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK && final == btn4.Text)
            {
                ImgPath = folderBrowserDialog1.SelectedPath;

                this.Hide();
                FormJoc4 fj = new FormJoc4(ImgPath);
                fj.ShowDialog();
            }
            else
            {
                ImgPath = folderBrowserDialog1.SelectedPath;
                this.Hide();
                Puzzle9 puzzle9 = new Puzzle9();
                puzzle9.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
