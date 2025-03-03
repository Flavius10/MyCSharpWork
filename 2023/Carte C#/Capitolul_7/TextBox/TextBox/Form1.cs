using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 1; i <= 10; i += 2)
            {
                if (TextWasChanged == true)
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.ForeColor = Color.Green;
                    TextWasChanged = false;
                }
                else
                {
                    textBox1.BackColor = Color.Green;
                    textBox1.ForeColor = Color.Red;
                    TextWasChanged = true;
                }
            }
        }

        public bool TextWasChanged = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            TextWasChanged = true;
        }
    }
}
