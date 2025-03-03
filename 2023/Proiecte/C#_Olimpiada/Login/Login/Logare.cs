using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Login
{
    public partial class Logare : Form
    {
        private string nume = "";
        private string parola = "";
        private string conf_parola = "";
        private string email = "";
        private bool ok_parola = false;
        private bool ok_email = true;
        private bool ok_tot = false;

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Utilizatori.mdf;Integrated Security=True";

        public Logare()
        {
            InitializeComponent();
            txtNume.Select();
        }  
        
        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            nume = txtNume.Text;
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            parola = txtParola.Text;
        }

        private void txtConfirmareParola_TextChanged(object sender, EventArgs e)
        {
            conf_parola = txtConfirmareParola.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        private bool ValidateEmail(string email)
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

        List<string> email_1 = new List<string>();

        private void SelectFrom()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Email FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader(); 

            while (dr.Read())
            {
                email_1.Add(dr[0].ToString());
            }

            dr.Close();
            dr.Dispose();
        }

        private void InsertInto(string nume, string parola, string email)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Utilizatori(Nume, Parola, Email) VALUES (@nume, @parola, @email)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private bool scris_email = true;
        private bool scris_parola = true;
        private bool scris_nume = true;
        private bool scris_con = true;
        private bool scris_tot = false;

        public void FunctieLogare()
        {

            if (email == "")
            {
                scris_email = false;
            }

            if (nume == "")
            {
                scris_nume = false;
            }

            if (parola == "")
            {
                scris_parola = false;
            }

            if (conf_parola == "")
            {
                scris_con = false;
            }

            if (scris_nume == true)
            {
                scris_tot = true;
            }

            if (scris_parola == true)
            {
                scris_tot = true;
            }

            if (scris_con == true)
            {
                scris_tot = true;
            }

            if (scris_email == true)
            {
                scris_email = true;
            }

            foreach (string e in email_1)
            {
                if (email == e.ToString())
                    ok_email = false;
            }

            if (parola == conf_parola)
            {
                ok_parola = true;
            }

            if (ok_parola == false)
            {
                MessageBox.Show("Parola nu corespunde cu parola confirmata", "Parola gresita!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtParola.Text = "";
                txtConfirmareParola.Text = "";
                txtParola.Select();
                ok_parola = false;
            }

            if (ValidateEmail(email) == false)
            {
                MessageBox.Show("Email nevalid\nVa rugam sa reintroduceti email-ul sub o forma valida", "Email gresit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Text = "";
                txtEmail.Select();
            }
            else if (ok_email == false)
            {
                MessageBox.Show("Email folosit\nVa rugam introduceti alt email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Text = "";
                txtEmail.Select();
            }

            if (ok_parola && ok_email)
            {
                ok_tot = true;
            }

            if (ok_tot && ValidateEmail(email))
            {
                this.Hide();
                Iesire i = new Iesire();
                i.ShowDialog();
                this.Close();
            }
        }


        private void btnLogare_Click(object sender, EventArgs e)
        {       
            if (scris_tot)
            {
                MessageBox.Show("Introduceti toate datele!", "Introducere date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SelectFrom();
            FunctieLogare();

            if (ok_tot && ValidateEmail(email))
            {
                SelectFrom();
                InsertInto(nume, parola, email); 
            }     
        }

        private void btnLogare_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            SelectFrom();
            FunctieLogare();

            if (ok_tot && ValidateEmail(email))
            {
                SelectFrom();
                InsertInto(nume, parola, email);
            }
        }


    }
}
