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

namespace Proiect_info
{
    public partial class AlegeMasina : Form
    {
        int id = 0;
        string path = Directory.GetCurrentDirectory();
        string filePath = "";

        public AlegeMasina()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filePath = Path.Combine(path, "1.png");
            this.Hide();
            id = 1;
            Proiect p = new Proiect(id, filePath);
            p.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            filePath = Path.Combine(path, "2.png");
            this.Hide();
            id = 2;
            Proiect p = new Proiect(id, filePath);
            p.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            filePath = Path.Combine(path, "3.png");
            this.Hide();
            id = 3;
            Proiect p = new Proiect(id, filePath);
            p.ShowDialog();
            this.Close();
        }
    }
}
