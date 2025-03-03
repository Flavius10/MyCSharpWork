using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Doriti sa iesiti din aplicatie?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            

            if (dg == DialogResult.No)
                e.Cancel = true;

            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { 
            IEsire i = new IEsire();
            i.ShowDialog();
        }
    }
}
