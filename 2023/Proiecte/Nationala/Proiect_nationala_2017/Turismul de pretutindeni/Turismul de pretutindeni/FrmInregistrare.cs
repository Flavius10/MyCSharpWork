using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismul_de_pretutindeni
{
    public partial class FrmInregistrare : Form
    {
        private bool ok_email = false;
        private bool ok_parola = false;
        private bool lungime_parola = false;
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Datadirectory|\TurismDB.mdf;Integrated Security=True";
        private int cnt = 0;
        private bool ok_email_db = false;
        Random r = new Random();
        private string path = Directory.GetCurrentDirectory();
        private string filePath = "";
        private string fileName = "";
        private bool ok_cod = false;
        private string files = "";

        public FrmInregistrare()
        {
            InitializeComponent();
            filePath = Path.Combine(path + @"\Logare");
            GetFile();
            fileName = Path.GetFileNameWithoutExtension(files);
            pbVerificare.Image = Image.FromFile(files);
        }

        private void GetFile()
        {
             var file = Directory.GetFiles(filePath, "*.png");
             files = file[r.Next(file.Length)];
        }

        private void InsertIntoUtilizatori(string nume, string prenume, string email, string parola, int tip)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(Nume, Prenume, Email, Parola, TipCont) VALUES (@nume, @prenume, @email, @parola, @tip)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@prenume", prenume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Parameters.AddWithValue("@tip", tip);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        private void SelectAll()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Email FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() == txtEmail.Text)
                {
                    
                    ok_email_db = true;
                    break;
                }
            }
            
            dr.Close();
            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        private bool ValidateEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var adress = new System.Net.Mail.MailAddress(email);
                return adress.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != null)
            {
                cnt++;
            }
            if (txtPrenume.Text != null)
            {
                cnt++;
            }
            if (txtEmail.Text != null)
            {
                cnt++;
            }
            if (txtParola.Text != null)
            {
                cnt++;
            }
            if (txtCod.Text != null)
            {
                cnt++;
            }
            if (txtConfirmare.Text != null)
            {
                cnt++;
            }

            if (ValidateEmail(txtEmail.Text))
            {
                ok_email = true;
            }

            if (txtParola.Text == txtConfirmare.Text)
            {
                ok_parola = true;
            }
            else
            {
                MessageBox.Show("Parola nu coincide cu parola confirmata\nReintroduceti parola", "Nu coincide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtParola.Text = "";
                txtConfirmare.Text = "";
                cnt--;
            }

            if (txtParola.TextLength >= 3)
            {
                lungime_parola = true;
            }
            else
            {
                MessageBox.Show("Parola trebuie sa aiba minim trei caractere\nReintroduceti parola", "Caractere insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtParola.Text = "";
                cnt--;
            }

            SelectAll();

            if (ok_email_db == true)
            {
                MessageBox.Show("Adresa de Email folosita\nVa rugam introduceti o adresa nefolosita!", "Adresa folosita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                cnt--;
            }

            if (txtCod.Text == fileName)
            {
                ok_cod = true;
            }
            else
            {
                MessageBox.Show("Cod gresit\nVa rugam reintroduceti", "Cod gresit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbVerificare.Image = Image.FromFile(files); 
                fileName = Path.GetFileNameWithoutExtension(files);
                cnt--;
            }

            if (cnt == 6)
            {
                InsertIntoUtilizatori(txtNume.Text, txtPrenume.Text, txtEmail.Text, txtParola.Text, 1);
                this.Hide();
                FrmAutentificare frmAutentificare = new FrmAutentificare();
                frmAutentificare.ShowDialog();
                this.Close();
            }
               
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAutentificare frmAutentificare = new FrmAutentificare();
            frmAutentificare.ShowDialog();
            this.Close();
        }
    }
}
