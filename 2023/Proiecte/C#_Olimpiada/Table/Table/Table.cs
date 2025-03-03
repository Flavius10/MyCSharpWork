using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Table : Form
    {

        private PictureBox[,] pb = null;
        private int n = 7;
        private int m = 8;
        private string path = null;
        private string[] files = null;
        private Random rd = null;

        public Table()
        {
            InitializeComponent();
            path = Directory.GetCurrentDirectory();
            path += @"\foto\";

            files = Directory.GetFiles(path);

            rd = new Random();
            pb = new PictureBox[n, m];
            DrawPicture(false);
        }

        private void DrawPicture(bool created)
        {
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (!created)
                        pb[i, j] = new PictureBox();

                    pb[i, j].Click += pictureBox_Click;
                    pb[i, j].Size = new Size(70, 70);

                    pb[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    pb[i, j].Padding = new Padding(1, 1, 1, 1);
                    pb[i, j].Image = Image.FromFile(files[rd.Next() % files.Length]);
                    table1.Controls.Add(pb[i, j], j , i);
                }
            }
        }

        private void btnSchimba_Click(object sender, EventArgs e)
        {
            this.table1.Controls.Clear();
            this.table1.SuspendLayout();
            DrawPicture(true);
            this.table1.ResumeLayout(false);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            pictureBox.Image = Image.FromFile(files[rd.Next() % files.Length]);
        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; ++j)
                {
                    pb[i, j].Image = Image.FromFile(files[rd.Next() % files.Length]);
                }
            }
        }
    }
}
