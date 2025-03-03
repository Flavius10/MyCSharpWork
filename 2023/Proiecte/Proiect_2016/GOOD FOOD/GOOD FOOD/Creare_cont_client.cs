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

namespace GOOD_FOOD
{
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
            SelectEmail();

        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";
        
        List<string> email = new List<string>();

        public void SelectEmail()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string qouery = "SELECT email FROM Clienti";
            SqlCommand cmd = new SqlCommand(qouery, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                email.Add(dr[0].ToString());
            }

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        private void SelectAll()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Clienti";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            //dataGridView1.DataSource = dt;
            dr.Close();
            conn.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void InsertDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Clienti(parola, nume, prenume, adresa, email) VALUES (@parola, @nume, @prenume, @adresa, @email)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@parola", txtParola.Text);
            cmd.Parameters.AddWithValue("@nume", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenume", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@adresa", txtAdresa.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public static bool ValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

            return emailRegex.IsMatch(email);
        }


        bool ok = true;
        bool ok1 = true;

        private void button1_Click(object sender, EventArgs e)
        {
            ok1 = true;
            SelectEmail();

            foreach(string s in email)
            {
                if (txtEmail.Text != s) 
                {
                    ok = true;
                }

                if (txtEmail.Text == s) 
                {
                    ok = false;
                    break;
                }
            }

            if (txtAdresa.Text == "")
            {
                ok1 = false;
            }

            if (txtEmail.Text == "")
            {
                ok1 = false;
            }

            if (txtNume.Text == "")
            {
                ok1 = false;
            }

            if (txtParola.Text == "")
            {
                ok1 = false;
            }

            if (txtPrenume.Text == "")
            {
                ok1 = false;
            }

            if (txtReParola.Text == "")
            {
                ok1 = false;
            }

            if (ok == true && ok1 == true)
            {
                InsertDate();
                txtAdresa.Text = "";
                txtEmail.Text = "";
                txtNume.Text = "";
                txtParola.Text = "";
                txtPrenume.Text = "";
                txtReParola.Text = "";
            }

            if (ok == false && ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email folosit\nVa rugam reintroduceti emailul");
                ok = true;
                txtEmail.Text = "";
            }

        }
    }



}
