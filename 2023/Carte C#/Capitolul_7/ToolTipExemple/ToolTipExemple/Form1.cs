using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTipExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();

            t.SetToolTip(textBox1, "introduceti date");
            t.SetToolTip(textBox2, "introduceti date");
            t.SetToolTip(radioButton1, "introduceti date");
            t.SetToolTip(radioButton2, "introduceti date");
            t.SetToolTip(checkBox1, "introduceti date");
            t.SetToolTip(button1, "introduceti date");
            t.SetToolTip(button2, "introduceti date");
        }
    }
}
