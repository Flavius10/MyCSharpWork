using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Dialog_modal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string item1;
        private string item2;

        public string Item1
        {
            get { return item1; }
        }

        public string Item2
        {
            get { return item2; }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;

            button2.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item1 = "Nume: " + textBox1.Text.Trim();
            item2 = "Nr de telefon: " + textBox2.Text.Trim();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }
    }
}
