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

namespace Puzzle_Nume_Prenume
{
    public partial class FormJoc4 : Form
    {
        public FormJoc4()
        {
            InitializeComponent();
        }

        public string path1;
        public FormJoc4(string path)
        {
            InitializeComponent();
            path1 = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Deschide IMG";
            openFileDialog1.Filter = "Imagine (*.jpg) | *.jpg";

            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = path1;
            openFileDialog1.CheckFileExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile((string)openFileDialog1.FileName);
            }

        }

        int value = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Secunde: " + value.ToString();
            value++;
        }
    }
}
