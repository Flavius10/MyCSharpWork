using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Iesire : Form
    {
        public Iesire()
        {
            InitializeComponent();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Iesire_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doriti sa inchideti aplicatia?", "inchidere", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dr == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Iesire_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormIesire fi = new FormIesire();
            fi.ShowDialog();
        }
    }
}
