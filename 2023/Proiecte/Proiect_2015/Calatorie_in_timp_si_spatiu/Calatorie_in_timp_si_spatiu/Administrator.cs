using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatorie_in_timp_si_spatiu
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Administrare administrator = new Administrare();
            administrator.ShowDialog();
           
        }
    }
}
