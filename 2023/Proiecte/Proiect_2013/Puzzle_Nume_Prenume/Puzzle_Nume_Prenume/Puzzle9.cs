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
    public partial class Puzzle9 : Form
    {
        public Puzzle9()
        {
            InitializeComponent();
        }

        public string path1;
        public Puzzle9(string path)
        {
            InitializeComponent();
            path1 = path;
        }


        private void btnDeschide_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Deschide IMG";
            openFileDialog1.Filter = "Imagine (*.jpeg) | *.jpeg";


            openFileDialog1.Multiselect = true;
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = path1;
            openFileDialog1.CheckFileExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbOriginal.Image = Image.FromFile((string)openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile((string)openFileDialog1.FileName);
            }
        }  

        int value = 0;
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = "Secunde: " + value.ToString();
            value++;
        }
    }
}
