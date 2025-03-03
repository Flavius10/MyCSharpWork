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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 f;

        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form2();

            f.ShowDialog();
            if (f.Item != "")
            {
                listBox1.Items.Add(f.Item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
