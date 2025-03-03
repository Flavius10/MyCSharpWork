using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2019
{
    public partial class StartBiblioteca : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True";

        public StartBiblioteca()
        {
            InitializeComponent();

            CitestDateCarti();
            CitestDateUtilizatori();
            CitesteDateImprumuturi();
            CitesteDateRezervari();
        }
//carti
        private void CitestDateCarti()
        {
            StreamReader sr = new StreamReader("carti.txt");
            string line;
            string[] s;

            char[] split = { ';' };

            while((line = sr.ReadLine()) != null) 
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                string titlu = s[0].ToString();
                string autor = s[1].ToString();
                int nr_pag = Int32.Parse(s[2].ToString());

                InsertCarte(titlu, autor, nr_pag);
            }
        }

        private void InsertCarte(string titlu, string autor, int nr_pag)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Carti(Titlu, Autor, Nrpag) VALUES (@titlu, @autor, @nrpag)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@titlu", titlu);
            cmd.Parameters.AddWithValue("@autor", autor);
            cmd.Parameters.AddWithValue("@nrpag", nr_pag);

            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
        }
//utilizatori
        private void CitestDateUtilizatori()
        {
            StreamReader sr = new StreamReader("utilizatori.txt");
            string line;
            string[] s;

            char[] split = { ';' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                int tip = Int32.Parse(s[0].ToString());
                string nume = s[1].ToString();
                string email = s[2].ToString();
                string parola = "";
                
                if (s.Length == 4)
                {
                    parola = s[3].ToString();
                }

                if (s.Length == 4)
                    InsertUtilizatori(tip, nume, email, parola);
                else
                    InsertUtilizatori(tip, nume, email, parola);

            }
        }

        private void InsertUtilizatori(int tip, string nume, string email, string parola)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(TipUtilizator, NumePrenume, Email, Parola) VALUES (@tip, @nume, @email, @parola)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@tip", tip);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);

            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
        }
//imprumuturi

        private void CitesteDateImprumuturi()
        {
            StreamReader sr = new StreamReader("imprumuturi.txt");
            string line;
            string[] s;
            char[] split = { ';' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                int id_cit = Int32.Parse(s[0].ToString());
                int id_carte = Int32.Parse(s[1].ToString());
                DateTime date = DateTime.ParseExact(s[2].ToString(), "MM/dd/yyyy hh/mm/ss tt", CultureInfo.InvariantCulture);
                DateTime date1;

                if (s[3].ToString() != "NULL")
                {
                    date1 = DateTime.ParseExact(s[3].ToString(),"MM/dd/yyyy hh/mm/ss tt", CultureInfo.InvariantCulture);
                    InsertImprumuturi(id_cit, id_carte, date, date1);
                }

                if (s[3].ToString() == "NULL")
                {
                    InsertImprumuturi1(id_cit, id_carte, date);
                }

            }
        }

        private void InsertImprumuturi(int id_cit, int id_carte, DateTime data1, DateTime data2)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Imprumuturi(IdCititor, IdCarte, DataImprumut, DataRestituire) VALUES (@id, @id1, @data, @data1)";
            SqlCommand cmd = new SqlCommand(query, con);
      
            cmd.Parameters.AddWithValue("@id", id_cit);
            cmd.Parameters.AddWithValue("@id1", id_carte);
            cmd.Parameters.AddWithValue("@data", data1);
            cmd.Parameters.AddWithValue("@data1", data2);

            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
        }

        private void InsertImprumuturi1(int id_cit, int id_carte, DateTime data1)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Imprumuturi(IdCititor, IdCarte, DataImprumut) VALUES (@id, @id1, @data)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", id_cit);
            cmd.Parameters.AddWithValue("@id1", id_carte);
            cmd.Parameters.AddWithValue("@data", data1);

            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
        }

//rezervari
        private void CitesteDateRezervari()
        {
            StreamReader sr = new StreamReader("rezervari.txt");
            string line;
            string[] s;
            char[] split = { ';' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                int id_cit = Int32.Parse(s[0].ToString());
                int id_carte = Int32.Parse(s[1].ToString());
                DateTime date = DateTime.ParseExact(s[2].ToString(), "MM/dd/yyyy hh/mm/ss tt", CultureInfo.InvariantCulture);
                int status = Int32.Parse(s[3].ToString());

                InsertRezervari(id_cit, id_carte, date, status);
            }
        }
        private void InsertRezervari(int id_cit, int id_carte, DateTime data1, int status)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Rezervari(IdCititor, IdCarte, DataRezervare, StatusRezervare) VALUES (@id_cit, @id_carte, @data, @status)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id_cit", id_cit);
            cmd.Parameters.AddWithValue("@id_carte", id_carte);
            cmd.Parameters.AddWithValue("@data", data1);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
        }

        private void btn_Logare_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogareBiblioteca lb = new LogareBiblioteca();
            lb.ShowDialog();
            this.Close();
        }
    }
}
