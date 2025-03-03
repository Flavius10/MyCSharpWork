using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxExemple
{
    public partial class TextBoxEx : Form
    {
        public TextBoxEx()
        {
            InitializeComponent();

            parolaTextBox.PasswordChar = '*';

            parolaTextBox.Enabled = false;

            cnpLabel1.Visible = false;
            cnpTextBox.Visible = false;
            autentifButton.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                if (idTextBox.Text == "ionel")
                    parolaTextBox.Enabled = true;
                else
                    MessageBox.Show("Utilizatorul nu exista");

        }

        private void parolaTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (parolaTextBox.Text == "Flavius")
                {
                    cnpLabel1.Visible = true;
                    cnpTextBox.Visible = true;

                    cnpTextBox.Focus();

                    autentifButton.Visible = true;
                }
            else
                {
                    MessageBox.Show("Ai gresit parola");
                    parolaTextBox.Clear();
                }

        }

        private void cnpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void autentifButton_Click(object sender, EventArgs e)
        {
            if (cnpTextBox.Text.Length != 13)
            {
                MessageBox.Show("CNP gresit");
                cnpTextBox.Clear();
            }
            else
                MessageBox.Show("Autentificare cu succes!");
        }
    }
}
