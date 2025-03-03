using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook
{
    public partial class CreeazaContFreeBook : Form
    {
        public CreeazaContFreeBook()
        {
            InitializeComponent();
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FreeBook.mdf;Integrated Security=True";

        public void InsertIntoDataBase(string email, string parola, string nume, string prenume)
        { 
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO utilizatori(email, parola, nume, prenume) VALUES (@email, @parola, @nume, @prenume)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@prenume", prenume);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        List<string> email_list = new List<string>();

        public string SelectEmail()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT email FROM utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                email_list.Add(dr[0].ToString());
            }

            return email_list.ToString();
        } 
        
        private void CreeazaContFreeBook_Load(object sender, EventArgs e)
        {
            SelectEmail();
        }

        public static bool ValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            return emailRegex.IsMatch(email);
        }
/*
        private void SelectAll()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM utilizatori";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
             dataGridView1.DataSource = dt;
            dr.Close();
            conn.Dispose();
            cmd.Dispose();
            conn.Close();
        }
*/

        bool ok_caracter = true;
        bool ok_email = true;
        bool ok_parola = true;

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            ok_email = true;
            ok_caracter = true;

            if (txtConfirmareaParolei.Text == string.Empty)
                ok_caracter = false;

            if (txtEmail.Text == string.Empty)
                ok_caracter = false;

            if(txtNume.Text == string.Empty)
                ok_caracter = false;

            if (txtParola.Text == string.Empty)
                ok_caracter = false;

            if (txtPrenume.Text == string.Empty)
                ok_caracter = false;

            
            foreach (string str in email_list)
            {
                if (txtEmail.Text == str && ValidEmail(txtEmail.Text))
                    ok_email = false;
            }

            if (txtParola.Text != txtConfirmareaParolei.Text)
            {
                ok_parola = false;
            }

            if (ok_caracter == true && ok_email == true && ok_parola == true)
            {
                InsertIntoDataBase(txtEmail.Text, txtParola.Text, txtNume.Text, txtPrenume.Text);
                txtEmail.Text = "";
                txtNume.Text = "";
                txtPrenume.Text = "";
                txtConfirmareaParolei.Text = "";
                txtParola.Text = "";
                MessageBox.Show("Multumim pt inregistrare!");


                this.Hide();
                MeniuFreeBook mfb = new MeniuFreeBook(txtEmail.Text);
                mfb.ShowDialog();
                this.Close();
            }
            if (ok_caracter == false)
                MessageBox.Show("Va rugam introduceti toate datele!");
            if (ok_email == false)
                MessageBox.Show("Email-ul este deja folosit!\nVa rugam sa introduceti alt cont de email");
            if (ok_parola == false)
                MessageBox.Show("Parola nu coincide cu textul din caseta de confirmare a parolei!\nVa rugam sa introduceti din nou parola");


            //SelectAll();
        }
    }
}
