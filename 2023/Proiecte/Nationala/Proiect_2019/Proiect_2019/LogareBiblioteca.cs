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

namespace Proiect_2019
{
    public partial class LogareBiblioteca : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True";
        private bool ok = false;

        public LogareBiblioteca()
        {
            InitializeComponent();
            txtEmail.Text = "tutor@gmail.com";
            txtParola.Text = "stcnq";
        }

        private void btn_Renunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartBiblioteca sb = new StartBiblioteca();
            sb.ShowDialog();
            this.Close();
        }

        private void CitesteDate(string email, string parola)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Email, Parola FROM Utilizatori";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.Read())
            {
                if (dr[0].ToString() == txtEmail.Text && dr[1].ToString() == ParolaCriptata(txtParola.Text)) 
                {
                    ok = true;
                }  
            }

            dr.Close();
            sqlCommand.Dispose();
            con.Close();
        }

        private string ParolaCriptata(string parola_curenta)
        {
            string parola_criptata = "";
            char cod;

            foreach(char car in parola_curenta)
            {
                cod = car;

                if (Char.IsDigit(car))
                {
                    cod = (char)('9' - car + '0');
                }

                if (Char.IsLetter(car))
                {
                    if (Char.IsLower(car))
                    {
                        cod = (char)(car + 1);

                        if (car == 'z')
                            cod = 'a';
                    }
                    else
                    {
                        cod = (char)(car - 1);

                        if (car == 'A')
                            cod = 'Z';
                    }
                }

                parola_criptata += cod; 
            }

            return parola_criptata;
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            CitesteDate(txtEmail.Text, txtParola.Text);
            if (ok == true)
            {
                this.Hide();
                BibliotecarBiblioteca bb = new BibliotecarBiblioteca(txtEmail.Text);
                bb.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email si/ sau parola invalida!", "GRESIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Text = string.Empty;
                txtParola.Text = string.Empty;
            }

            //stcnq
        }
    }
}
