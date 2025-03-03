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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2019_nationala
{
    

    public partial class StartBiblioteca : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private string filePathCarti = "";
        private string filePathImprumuturi = "";
        private string filePathRezervari = "";
        private string filePathUtilizatori = "";
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True";
        public StartBiblioteca()
        {
            InitializeComponent();

            filePathCarti = Path.Combine(path, "carti.txt");
            filePathImprumuturi = Path.Combine(path, "imprumuturi.txt");
            filePathRezervari = Path.Combine(path, "rezervari.txt");
            filePathUtilizatori = Path.Combine(path, "utilizatori.txt");


            CitesteCarti();
            CitesteImprumuturi();
            CitesteRezervari();
            CitesteUtilizatori();


            SelectAll();
        }

        //Carti

        public void InsereazaCarti(string titlu, string autor, int nr_pag)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Carti(Titlu, Autor, Nrpag) VALUES (@titlu, @autor, @nr_pag)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@titlu", titlu);
            cmd.Parameters.AddWithValue("@autor", autor);
            cmd.Parameters.AddWithValue("@nr_pag", nr_pag);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void CitesteCarti()
        {
            StreamReader sr = new StreamReader(filePathCarti);
            string line = "";
            string[] s;
            char[] split = {';'};

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                string titlu = s[0].ToString();
                string autor = s[1].ToString();
                int nr_pag = Int32.Parse(s[2].ToString());

                InsereazaCarti(titlu, autor, nr_pag);
            }
        }

        //Imprumuturi

        public void InsereazaImprumuturi(int id_cititor, int id_carte, DateTime date, DateTime date1)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Imprumuturi(IdCititor, IdCarte, DataImprumut, DataRestituire) VALUES (@id_cit, @id_carte, @datai, @datares)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id_cit", id_cititor);
            cmd.Parameters.AddWithValue("@id_carte", id_carte);
            cmd.Parameters.AddWithValue("@datai",  date);
            cmd.Parameters.AddWithValue("@datares", date1);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void InsereazaImprumuturi1(int id_cititor, int id_carte, DateTime date)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Imprumuturi(IdCititor, IdCarte, DataImprumut) VALUES (@id_cit, @id_carte, @datai)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id_cit", id_cititor);
            cmd.Parameters.AddWithValue("@id_carte", id_carte);
            cmd.Parameters.AddWithValue("@datai", date);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void CitesteImprumuturi()
        {
            StreamReader sr = new StreamReader(filePathImprumuturi);
            string line = "";
            string[] s;
            char[] split = { ';' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                int id_cititor = Int32.Parse(s[0].ToString());
                int id_carte = Int32.Parse(s[1].ToString());
                DateTime date = DateTime.ParseExact(s[2].ToString(), "MM/dd/yyyy h/mm/ss tt", CultureInfo.InvariantCulture);
                if (s[3].ToString() != "NULL")
                {
                    DateTime date1 = DateTime.ParseExact(s[3].ToString(), "MM/dd/yyyy h/mm/ss tt", CultureInfo.InvariantCulture);
                }
                
                if (s[3].ToString() == "NULL")
                    InsereazaImprumuturi1(id_cititor, id_carte, date);
                else
                    InsereazaImprumuturi(id_cititor, id_carte, date, date);
            }
        }

        //Rezervari

        public void InsereazaRezervari(int id_cititor, int id_carte, DateTime date, int status)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Rezervari(IdCititor, IdCarte, DataRezervare, StatusRezervare) VALUES (@id_cit, @id_carte, @datai, @status)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id_cit", id_cititor);
            cmd.Parameters.AddWithValue("@id_carte", id_carte);
            cmd.Parameters.AddWithValue("@datai", date);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }



        public void CitesteRezervari()
        {
            StreamReader sr = new StreamReader(filePathRezervari);
            string line = "";
            string[] s;
            char[] split = { ';' };

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                int id_cititor = Int32.Parse(s[0].ToString());
                int id_carte = Int32.Parse(s[1].ToString());
                DateTime date = DateTime.ParseExact(s[2].ToString(), "MM/dd/yyyy hh/mm/ss tt", CultureInfo.InvariantCulture);
                int status = Int32.Parse(s[3].ToString());


                InsereazaRezervari(id_cititor, id_carte, date, status);
            }
        }


        //Utilizatori
        public void InsereazaUtilizatori(int tip, string nume, string email, string parola)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(TipUtilizator, NumePrenume, Email, PArola) VALUES (@tip, @nume, @email, @parola)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@tip", tip);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }


        public void CitesteUtilizatori()
        {
            StreamReader sr = new StreamReader(filePathUtilizatori);
            string line = "";
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
                    

                if (s.Length == 3)
                    InsereazaUtilizatori(tip, nume, email,  parola);
                else
                    InsereazaUtilizatori(tip, nume, email, "parola");
            }
        }


        public void SelectAll()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Imprumuturi";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader dr = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);
            //dataGridView1.DataSource = dt;

            dr.Dispose();
            sqlCommand.Dispose();
            con.Dispose();
            con.Close();
        }

    }
}
