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
using System.Xml.Linq;

namespace AplicatieFreeBook
{
    public partial class FreeBookHome : Form
    { 
        public string path = Directory.GetCurrentDirectory();
        public string filePathCarti = "";
        string filePathUtilizatori = "";
        string filePathImprumut = "";

        public FreeBookHome()
        {
            InitializeComponent();
            filePathCarti = Path.Combine(path, "carti.txt");
            filePathUtilizatori = Path.Combine(path, "utilizatori.txt");
            filePathImprumut = Path.Combine(path, "imprumuturi.txt");
        }

       

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FreeBook.mdf;Integrated Security=True";

        public void InsertCarti(string titlu, string autor, string gen)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO carti(titlu, autor, gen) VALUES (@titlu, @autor, @gen)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@titlu", titlu);
            cmd.Parameters.AddWithValue("@autor", autor);
            cmd.Parameters.AddWithValue("@gen", gen);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void InsertUtilizator(string email, string parola, string nume, string prenume)
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

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void InsertImprumut(int id_c, string email, DateTime dt)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO imprumut(id_carte, email, data_imprumut) VALUES (@id_carte, @email, @data_imprumut)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id_carte", id_carte);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@data_imprumut", dt);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        int id_carte = 0;

        public int SelectIdCarte(string nume_carte)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT id_carte FROM carti WHERE titlu = @nume_carte";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume_carte", nume_carte);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                id_carte = Int32.Parse(dr[0].ToString());  
            }
            
            return id_carte;
        }

        public void SelectAll()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM imprumut";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader(); 

            DataTable dt = new DataTable();
            dt.Load(dr);
            //dataGridView1.DataSource = dt;
            
            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void RetrageDateCarti()
        {
            StreamReader sr = new StreamReader(filePathCarti);
            string line = "";
            string[] s;

            char[] split = { '*' };

            while((line = sr.ReadLine()) != null) 
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 2; i < s.Length; i++)
                {
                    InsertCarti(s[i - 2], s[i - 1], s[i]);
                }
            }
        }

        public void RetrageDateUtilizatori()
        {
            StreamReader sr = new StreamReader (filePathUtilizatori);
            string line = "";
            string[] s;

            char[] split = {'*'};

            while((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 3; i < s.Length; ++i)
                {
                    InsertUtilizator(s[i - 3], s[i - 2], s[i - 1], s[i]);
                }
            }
        }

        int id_c;

        public void RetrageDateImprumut()
        {
            StreamReader sr = new StreamReader(filePathImprumut);
            string line = "";
            string[] s;

            char[] split = {'*'};

            while ((line = sr.ReadLine()) != null)
            {
                id_c = 0;
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                id_c = SelectIdCarte(s[0].ToString());

                InsertImprumut(id_c, s[1].ToString(), DateTime.Parse(s[2].ToString()));
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {    
            RetrageDateCarti();
            RetrageDateUtilizatori();
            RetrageDateImprumut();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreeazaContFreeBook cfb = new CreeazaContFreeBook();
            cfb.ShowDialog();
            this.Close();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogareFreeBook lfb = new LogareFreeBook();
            lfb.ShowDialog();
            this.Close();
        }
    }
}
