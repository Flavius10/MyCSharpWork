using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Pictures
{
    public partial class _9_elemente : Form
    {
        int secunde = 0;
        int milisecunde = 0;
        int cnt = 0;
        PictureBox[] boxes;
        public _9_elemente()
        {
            InitializeComponent();

            boxes = new PictureBox[] { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };
        }

        private void _9_elemente_Load(object sender, EventArgs e)
        {
            Imagini();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ++secunde;
            label1.Text = secunde.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ++milisecunde;
            if (milisecunde == 60)
                milisecunde = 0;

            label2.Text = milisecunde.ToString();
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var target = (PictureBox)sender;
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                var source = (PictureBox)e.Data.GetData(typeof(PictureBox));
                if (source != target)
                {
                    SwapImages(source, target);

                    return;
                }
            }
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            ++cnt;
            if (cnt == 1)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }

            e.Effect = DragDropEffects.Move;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                var pb = (PictureBox)sender;
                if (pb.Image != null)
                {
                    pb.DoDragDrop(pb, DragDropEffects.Move);
                }
            }
        }

        private void SwapImages(PictureBox source, PictureBox target)
        {
            if (source.Image == null && target.Image == null)
            {
                return;
            }

            var temp = target.Image;
            target.Image = source.Image;
            source.Image = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            if (label1.Text == string.Empty)
            {
                MessageBox.Show("Ati completat puzzle-ul in 0 secunde si " + label2.Text, "PUZZLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Ati completat puzzle-ul in " + label1.Text + "secunde si " + label2.Text, "PUZZLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imagini();
        }

        private void Imagini()
        {
            List<int> Numere = new List<int>();
            using (var openFile = new FolderBrowserDialog())
            {
                DialogResult dr = openFile.ShowDialog();
                if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(openFile.SelectedPath))
                {
                    string[] files = Directory.GetFiles(openFile.SelectedPath);


                    pb1.Image = Image.FromFile(files[6]);
                    pb2.Image = Image.FromFile(files[3]);
                    pb3.Image = Image.FromFile(files[7]);
                    pb4.Image = Image.FromFile(files[1]);
                    pb5.Image = Image.FromFile(files[5]);
                    pb6.Image = Image.FromFile(files[8]);
                    pb7.Image = Image.FromFile(files[0]);
                    pb8.Image = Image.FromFile(files[4]);
                    pb9.Image = Image.FromFile(files[2]);


                    pb10.Image = Image.FromFile(files[9]);
                }


                foreach (var box in boxes)
                {
                    box.AllowDrop = true;
                    box.DragDrop += PictureBox_DragDrop;
                    box.DragEnter += PictureBox_DragEnter;
                    box.MouseMove += PictureBox_MouseMove;
                }

            }
        }

    }
}
