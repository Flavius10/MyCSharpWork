using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2018
{
    public partial class Centenar_Start : Form
    {
        Button btn;
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CentenarDB.mdf;Integrated Security=True";
        public Centenar_Start()
        {
            InitializeComponent();
            CitesteDateUtilizatori();
            CitesteDateLectii();

            if (FormaLogare.logat == true)
            {
                btn = new Button();
                btn.Text = "CreareLectie";
                btn.Location = new Point(200, 160);
            }
        }

        private void CitesteDateUtilizatori()
        {
            StreamReader sr = new StreamReader("utilizatori.txt");
            string line;
            string[] s;
            char[] split = { '*' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                string nume = s[0].ToString();
                string parola = s[1].ToString();
                string email = s[2].ToString();

                IntroduceUtilizatori(nume, parola, email);

            }
        }

        private void IntroduceUtilizatori(string nume, string parola, string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(Nume, Parola, Email) VALUES (@nume, @parola, @email)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        private void CitesteDateLectii()
        {
            StreamReader sr = new StreamReader("lectii.txt");
            string line;
            string[] s;
            char[] split = { '*' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                int id_ut = int.Parse(s[0]);
                string titlu;
                string regiune;
                string nume;
                DateTime data;
                if (s.Length == 5)
                {
                    titlu = s[1].ToString();
                    regiune = s[2].ToString();
                    nume = s[3].ToString();
                    data = DateTime.ParseExact(s[4].ToString(), "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                }
                else
                {
                    titlu = null;
                    regiune = s[1].ToString();
                    nume = s[2].ToString();
                    data = DateTime.ParseExact(s[3].ToString(), "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                }

                IntroduceLectii(id_ut, titlu, regiune, data, nume);

                
            }
        }

        private void IntroduceLectii(int id_ut, string titlu, string regiune, DateTime data, string nume)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Lectii(IdUtilizator, TitluLectie, Regiune, DataCreare, NumeImagine) VALUES (@id_ut, @titlu, @regiune, @data, @nume)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id_ut", id_ut);
            cmd.Parameters.AddWithValue("@titlu", titlu);
            cmd.Parameters.AddWithValue("@regiune", regiune);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@nume", nume);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void btnLectii_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizualizareLectii vl = new VizualizareLectii();
            vl.ShowDialog();
            this.Close();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaLogare fl = new FormaLogare();
            fl.ShowDialog();
            this.Close();
        }
    }
}
