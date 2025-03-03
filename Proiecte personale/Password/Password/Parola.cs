using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class Parola : Form
    {
        public Parola()
        {
            InitializeComponent();
            this.BackColor = Color.Gainsboro;
            this.ForeColor = Color.Navy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = txtParola.Text;
        }
    }
}
