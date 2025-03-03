using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Poluare.mdf;Integrated Security=True";
        public string nume;

        public string SelectNume()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT NumeUtilizator FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                nume = dr[0].ToString() + ' ';
            }

            return nume;
        }

        public void InsertDate(string nume, string parola, string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(NumeUtilizator, Parola, EmailUtilizator) VALUES (@nume, @parola, @email)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public string[] nume_ut;
        public bool ok_nume = true;
        bool ok_parola = true;
        bool ok_email = true;

        public static bool ValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            return emailRegex.IsMatch(email);
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            SelectNume();
        }

        public string nume_util = "oti2022";

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            ok_parola = true;
            ok_nume = true;
            ok_email = true;

            nume_ut = nume_util.Split(' ');

            for (int i = 0; i < nume_ut.Length; i++)
            {
                if (txtNume.Text == nume_ut[i])
                {
                    ok_nume = false;
                }
            }

            if (txtNume.Text.Length <= 4)
            {
                ok_nume = false;
            }

            if (txtParola.Text != txtConfirmare.Text)
            {
                ok_parola = false;
            }

            if (txtParola.Text.Length < 6)
            {
                ok_parola = false;
            }

            if (txtParola.Text == "")
            {
                ok_parola = false;
            }

            if (!ValidEmail(txtEmail.Text))
            {
                ok_email = false;
            }

            if (ok_nume == false && txtNume.TextLength > 4)
            {
                MessageBox.Show("Nume de utilizator folosit!");
            }

            if (ok_nume == false && txtNume.TextLength <= 4)
            {
                MessageBox.Show("Introduceti un nume din mai mult de 4 caractere");
            }

            if(ok_parola == false && txtParola.Text.Length >= 6)
            {
                MessageBox.Show("Parola nu corespunde cu parola confirmata!'\n'Va rugam reintroduceti parola");
            }
            else if (ok_parola == false && txtParola.Text.Length < 6)
            {
                MessageBox.Show("Introduceti o parola cu mai mult de 6 caractere");
            }

            if (ok_email == false)
            {
                MessageBox.Show("Formatul emailuli este gresit!'\n'Va rugam reintroduceti emailul");
            }           
            
            if ((ok_nume == true && ok_parola == true) && ok_parola == true)
            {
                InsertDate(txtNume.Text, txtParola.Text, txtEmail.Text);
                nume_util += ' ' + txtNume.Text + ' ';
                txtConfirmare.Text = null;
                txtParola.Text = null;
                txtNume.Text = null;
                txtEmail.Text = null;
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificare a = new Autentificare();
            a.ShowDialog();
            this.Close();
        }
    }
}
