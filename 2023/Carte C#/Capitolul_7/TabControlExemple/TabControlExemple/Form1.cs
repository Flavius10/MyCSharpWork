using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char[] sep = new char[] { '\\' };

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string[] aux;
            string fullPath;
            string imgName;

            openFileDialog1.Filter = "Fisiere suportate" +
                "(*.jpg;*.png;*.ico;*.gif;*.bmp;*.tiff)" +
                "| *.jpg;*.png;*.ico;*.gif;*.bmp;*.tiff" +
                "| All files (*.*) | *.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fullPath = openFileDialog1.FileName;

                aux = fullPath.Split(sep);

                imgName = aux[aux.Length - 1];

                TabPage tab = new TabPage(imgName);
                PictureBox pictureBox = new PictureBox();

                pictureBox.Image = Image.FromFile(fullPath);

                pictureBox.SetBounds((tabControl1.Width / 2 - pictureBox.Width / 2),
                    (tabControl1.Height/2 - pictureBox.Height/2),
                    pictureBox.Image.Width, pictureBox.Image.Height);

             tab.Controls.Add(pictureBox);   


            tabControl1.TabPages.Add(tab);

                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex - 1 >= 0)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            while(tabControl1.TabPages.Count > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
