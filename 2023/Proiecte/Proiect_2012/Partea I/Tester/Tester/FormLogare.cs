using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class FormLogare : Form
    {
        public FormLogare()
        {
            InitializeComponent();
            txtNumeUtilizator.Visible = false;
            txtPass.Visible = false;

            lblNumeUtilizator.Visible = false;
            lblPass.Visible = false;
           

            btnLogare.Visible = false;
        }

        private void lansareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNumeUtilizator.Visible = true;
            txtPass.Visible = true;

            lblNumeUtilizator.Visible = true;
            lblPass.Visible = true;
 

            btnLogare.Visible = true;
        }

        private void inchidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (txtNumeUtilizator.Text == "candidat" &&  txtPass.Text == "cia2012")
            {
                this.Hide();
                FormTest ft = new FormTest();
                ft.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nume utilizator sau parolă gresită!! Vă rugăm reluati!”");
                txtNumeUtilizator.Text = "";
                txtPass.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
