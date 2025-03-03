using Pictures.Properties;
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

namespace Pictures
{
    public partial class _4_elemente : Form
    {
        private int cnt = 0;
        private int secunde = 0;
        private int milisecunde = 0;
        PictureBox[] boxes;
        string[] files;

        public _4_elemente()
        {
            InitializeComponent();

            boxes = new PictureBox[] { pb1, pb2, pb3, pb4 };

            foreach (var box in boxes)
            {
                box.AllowDrop = true;
                box.DragDrop += PictureBox_DragDrop;
                box.DragEnter += PictureBox_DragEnter;
                box.MouseMove += PictureBox_MouseMove;
            }

        }

        private void _4_elemente_Load(object sender, EventArgs e)
        {
            Imagini();
        }

        private void Imagini()
        {
            using (var openDialog = new FolderBrowserDialog())
            {
                DialogResult dr = openDialog.ShowDialog();

                if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(openDialog.SelectedPath))
                {
                    files = Directory.GetFiles(openDialog.SelectedPath);

                    pb1.Image = Image.FromFile(files[2]);
                    pb2.Image = Image.FromFile(files[1]);
                    pb3.Image = Image.FromFile(files[0]);
                    pb4.Image = Image.FromFile(files[3]);

                    pbImagine.Image = Image.FromFile(files[4]);

                }
            }
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
    }
}
