using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            btnValidare.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doriti sa inchideti aplicatia?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
                this.Hide();
            else
                e.Cancel = true;
        }       
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Iesire i = new Iesire();
            i.ShowDialog();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool EmailValidare(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var adress = new System.Net.Mail.MailAddress(email);
                return adress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnValidare_Click(object sender, EventArgs e)
        {
            if (EmailValidare(txtEmail.Text))
            {
                MessageBox.Show("Email valid!");
            }
            else
            {
                MessageBox.Show("Email nevalid!");
            }
        }

        private void btnValidare_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (btnValidare.Focus())
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (EmailValidare(txtEmail.Text))
                    {
                        MessageBox.Show("Email valid!");
                    }
                    else
                    {
                        MessageBox.Show("Email nevalid!");
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnValidare.Select();
        }

    }
}
