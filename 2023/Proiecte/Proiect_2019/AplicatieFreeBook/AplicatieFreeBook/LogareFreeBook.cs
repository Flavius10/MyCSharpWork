using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook
{
    public partial class LogareFreeBook : Form
    {
        public LogareFreeBook()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FreeBook.mdf;Integrated Security=True";

        List<string> email = new List<string>();
        List<string> parola = new List<string>();

        public string SelectEmail()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT email FROM utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                email.Add(dr[0].ToString());
            }

            return email.ToString();
        }

        public string SelectParola()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT parola FROM utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                parola.Add(dr[0].ToString());
            }

            return parola.ToString();
        }

        bool ok_logare = false;
        bool ok_parola = false;
        bool ok_email = false;

        private void button1_Click(object sender, EventArgs e)
        {
            ok_logare = false;
            ok_parola = false;
            ok_email = false;

            SelectEmail();
            SelectParola();

            foreach(string em in email)
            {
                if (txtEmail.Text == em.ToString())
                {
                    ok_email = true;     
                }
            }

            foreach(string p in parola)
            {
                if (txtParola.Text == p.ToString())
                {
                    ok_parola = true;
                }
            }

            if (ok_email == true && ok_parola == true)
            {
                ok_logare = true;
            }

            if (ok_logare == true)
            {
                this.Hide();
                MeniuFreeBook mfb = new MeniuFreeBook(txtEmail.Text);
                mfb.ShowDialog();
                this.Close();
            }
        }
    }
}
