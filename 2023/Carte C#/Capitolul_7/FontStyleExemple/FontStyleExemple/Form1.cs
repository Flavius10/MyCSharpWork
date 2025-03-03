using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontStyleExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font vechiulFont, noulFont;

            vechiulFont = this.richTextBox1.SelectionFont;


            if (vechiulFont.Bold)
            {
                noulFont = new Font(vechiulFont, vechiulFont.Style & ~ FontStyle.Bold);
            }
            else
            {
                noulFont = new Font(vechiulFont, vechiulFont.Style | FontStyle.Bold);
            }

            this.richTextBox1.SelectionFont = noulFont;
            this.richTextBox1.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font vechiulFont, noulFont;

            vechiulFont = this.richTextBox1.SelectionFont;

            if (vechiulFont.Italic)
            {
                noulFont = new Font(vechiulFont, vechiulFont.Style & ~ FontStyle.Italic);
            }
            else
            {
                noulFont = new Font(vechiulFont, vechiulFont.Style | FontStyle.Italic);
            }

            this.richTextBox1.SelectionFont = noulFont;
            this.richTextBox1.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font vechiuFont, noulFont;

            vechiuFont = this.richTextBox1.SelectionFont;

            if (vechiuFont.Underline)
            {
                noulFont = new Font(vechiuFont, vechiuFont.Style & ~ FontStyle.Underline);
            }
            else
            {
                noulFont = new Font(vechiuFont, vechiuFont.Style | FontStyle.Underline);
            }

            this.richTextBox1.SelectionFont = noulFont;
            this.richTextBox1.Focus();
        }
    }
}
