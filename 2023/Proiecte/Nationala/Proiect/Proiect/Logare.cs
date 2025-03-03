using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Logare : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Utilizator.mdf;Integrated Security=True";
        bool ok_email = false;
        bool ok_nume = false;
        bool ok_nume1 = false;
        bool email1 = false;
        bool parola = false;

        public Logare()
        {
            InitializeComponent();
        }

        private void CitesteDate()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader(); 

            while(dr.Read())
            {
                if (txtEmail.Text == dr[2].ToString())
                    ok_email = true;
                if (txtNume.Text == dr[1].ToString())
                    ok_nume = true;
                if (txtParola.Text == dr[3].ToString())
                    parola = true;
            }

            dr.Close();
            cmd.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private bool ValidareEmail(string email)
        {
            var trimmedemail = email.Trim();

            if (trimmedemail.EndsWith("."))
                return false;

            try
            {
                var adresa = new MailAddress(email);
                return trimmedemail == adresa.Address;
            }
            catch
            { 
                return false;
            }
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            CitesteDate();

            if (ValidareEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email nevalid\nReintroduceti email", "EMAIL GRESIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Text = string.Empty;
            }

            if (ok_email == false)
            {
                MessageBox.Show("Email folosit\nReintroduceti email", "EMAIL GRESIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Text = string.Empty;
            }

            if (ok_nume == false)
            {
                MessageBox.Show("Nume de utilizator folosit\nReintroduceti un nume", "NUME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNume.Text = string.Empty;
            }

            if(parola == false)
            {
                MessageBox.Show("Parola gresita\nReintroduceti parola", "PAROLA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtParola.Text = string.Empty;
            }

            if (parola && ok_nume && ok_email && ValidareEmail(txtEmail.Text))
            {
                this.Hide();
                Bitmap_Form bf = new Bitmap_Form();
                bf.ShowDialog();
                this.Close();
            }
        }
    }
}
