using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogExemple
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string item;

        public string Item
        {
            get { return item; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item = textBox1.Text.Trim();

            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                item = textBox1.Text.Trim();
                Close();
            }
        }
    }
}
