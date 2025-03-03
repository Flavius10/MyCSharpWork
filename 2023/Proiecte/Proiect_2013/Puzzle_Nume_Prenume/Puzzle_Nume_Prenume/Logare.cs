using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Nume_Prenume
{
    public partial class FormLogare : Form
    {
        public FormLogare()
        {
            InitializeComponent();

        }
        private void jucatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLogare.Text = jucatorToolStripMenuItem.Text;
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLogare.Text = administratorToolStripMenuItem.Text;

        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (txtNume.Text == "jucator" && txtParola.Text == "jucator" && btnLogare.Text == jucatorToolStripMenuItem.Text)
            {
                this.Hide();
                FormJucator fj = new FormJucator();
                fj.ShowDialog();
                this.Close();
            }
            else if (txtNume.Text == "administrator" && txtParola.Text == "administrator" && btnLogare.Text == administratorToolStripMenuItem.Text)
            {
                this.Hide();
                FormAdminisrator fa = new FormAdminisrator();
                fa.ShowDialog();
                this.Close();
            }
        }
    }
}
