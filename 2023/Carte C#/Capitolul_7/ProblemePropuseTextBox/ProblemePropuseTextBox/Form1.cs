using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemePropuseTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (textBox1.Text == "Schimba culoare")
                {
                    MessageBox.Show("Parola e corecta");
                    textBox1.BackColor = Color.Gold;
                    textBox1.ForeColor = Color.Brown;
                    textBox1.Font = new Font("Roboto", 20);
                }
                else
                    MessageBox.Show("Parola nu este corecta!");
        }
    }
}
