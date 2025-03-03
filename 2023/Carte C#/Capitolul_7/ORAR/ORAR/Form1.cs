using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string msg1 = "";
        public string msg2 = "";
        public string msg3 = "";
        public string msg4 = "";
        public string msg5 = "";
        public string msg6 = "";
        public string msg7 = "";

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count) 
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }

            msg1 += "Orar luni: " + '\n' + richTextBox1.Text + '\n'; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
            msg2 += "Orar marti: " + '\n' + richTextBox2.Text + '\n';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1; 
            }

            msg3 += "Orar miercuri: " + '\n' + richTextBox3.Text + '\n';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
            msg4 += "Orar joi: " + '\n' + richTextBox4.Text + '\n';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
            msg5 += "Orar vineri: " + '\n' + richTextBox5.Text + '\n';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
            msg6 += "Orar sambata: " + '\n' + richTextBox6.Text + '\n';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }

            msg7 += "Orar duminica: " + '\n' + richTextBox7.Text + '\n';

            richTextBox8.Text += msg1 + msg2 + msg3 + msg4 + msg5 + msg6 + msg7;
        }
    }
}
