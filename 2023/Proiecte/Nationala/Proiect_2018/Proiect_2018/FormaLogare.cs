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
using System.Xml.Linq;

namespace Proiect_2018
{
    public partial class FormaLogare : Form
    {
        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CentenarDB.mdf;Integrated Security=True";
        public bool ok_email = false;
        public bool ok_parola = false;
        public static bool logat = false;

        public FormaLogare()
        {
            InitializeComponent();
            txtEmail.Text = "popescu@gmail.com";
            txtParola.Text = "popIon";
        }

        private void CunoasteEmailParola(string email, string parola) 
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                if (email == dr[3].ToString()) 
                {
                    ok_email = true;
                }

                if (parola == dr[2].ToString())
                {
                    ok_parola = true;
                }
            }

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CunoasteEmailParola(txtEmail.Text, txtParola.Text);

            if (ok_email && ok_parola)
            {
                logat = true;
                this.Hide();
                Centenar_Start cs = new Centenar_Start();
                cs.ShowDialog();
                this.Close();
            }
            else
            {
                txtParola.Text = string.Empty;
                txtEmail.Text = string.Empty;
                MessageBox.Show("Eroare de autentificare!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnParola_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperareParola rp = new RecuperareParola(txtEmail.Text);
            rp.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Centenar_Start cs = new Centenar_Start();
            cs.ShowDialog();
            this.Close();
        }
    }
}
