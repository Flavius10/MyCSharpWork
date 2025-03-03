using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FontDrawingExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fnt = new InstalledFontCollection();

            foreach(FontFamily fam in fnt.Families)
                comboBox1.Items.Add(fam.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();  
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(comboBox1.Text, new Font(comboBox1.Text, 40), Brushes.Black, 10, 50);
            }

            catch(ArgumentException exe)
            {
                MessageBox.Show(exe.Message);
            }

        }
    }
}
