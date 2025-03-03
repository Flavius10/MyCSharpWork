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

namespace PollutionMap
{
    public partial class Autentificare : Form
    {
        private string filePath = "";
        private string path = "";
        private string filePath_masurare = "";

        public Autentificare()
        {
            InitializeComponent();
            lblNume.BackColor = Color.Transparent;
            lblParola.BackColor = Color.Transparent;

            path = Directory.GetCurrentDirectory();
            filePath = Path.Combine(path, "harti.txt");
            filePath_masurare = Path.Combine(path, "masurari.txt");
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Poluare.mdf;Integrated Security=True";

        public void InsereazaHarti(string nume, string fisier)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Harti(NumeHarta, FisierHarta) VALUES (@nume, @fisier)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@fisier", fisier);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public void InsereazaMasurare(int id_harta, int x, int y, int val, DateTime data)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Masurare(IdHarta, PozitieX, PozitieY, ValoareMasurare, DataMasurare) VALUES (@id_harta, @x, @y, @val, @data)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id_harta", id_harta);
            cmd.Parameters.AddWithValue("@x", x);
            cmd.Parameters.AddWithValue("@y", y);
            cmd.Parameters.AddWithValue("@val", val);
            cmd.Parameters.AddWithValue("@data", data);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public void RetrageDateHarti()
        {
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            string[] s;
            char[] split = { '#' };

            while ((line = sr.ReadLine()) != null) 
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < s.Length; i++)
                {
                    InsereazaHarti(s[i - 1], s[i]);
                }
            }
        }

        public int cnt = 0;

        private void RetrageDateMasurare()
        {
            StreamReader sr = new StreamReader(filePath_masurare);
            string line = "";
            string[] sa;
            char[] split = { '#' };

            while ((line = sr.ReadLine()) != null)
            {
                sa = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 4; i < sa.Length; i++)
                {

                    if (sa[0] == "Harta Bucuresti")
                    {
                        int x = Int32.Parse(sa[1]);
                        int y = Int32.Parse(sa[2]);
                        int val = Int32.Parse(sa[3]);
                        DateTime dt = DateTime.ParseExact(sa[4], "dd/MM/yyyy HH:mm", null);
                        InsereazaMasurare(1, x, y, val, dt);
                    }

                    if (sa[0] == "Harta Cluj-Napoca")
                    {
                        int x = Int32.Parse(sa[1]);
                        int y = Int32.Parse(sa[2]);
                        int val = Int32.Parse(sa[3]);
                        DateTime dt = DateTime.ParseExact(sa[4], "dd/MM/yyyy HH:mm", null);
                        InsereazaMasurare(2, x, y, val, dt);
                    }

                    if (sa[0] == "Harta Constanta")
                    {
                        int x = Int32.Parse(sa[1]);
                        int y = Int32.Parse(sa[2]);
                        int val = Int32.Parse(sa[3]);
                        DateTime dt = DateTime.ParseExact(sa[4], "dd/MM/yyyy HH:mm", null);
                        InsereazaMasurare(3, x, y, val, dt);
                    }

                    if (sa[0] == "Harta Iasi")
                    {
                        int x = Int32.Parse(sa[1]);
                        int y = Int32.Parse(sa[2]);
                        int val = Int32.Parse(sa[3]);
                        DateTime dt = DateTime.ParseExact(sa[4], "dd/MM/yyyy HH:mm", null);
                        InsereazaMasurare(4, x, y, val, dt);
                    }

                    if (sa[0] == "Harta Sibiu")
                    {
                        int x = Int32.Parse(sa[1]);
                        int y = Int32.Parse(sa[2]);
                        int val = Int32.Parse(sa[3]);
                        DateTime dt = DateTime.ParseExact(sa[4], "dd/MM/yyyy HH:mm", null);
                        InsereazaMasurare(5, x, y, val, dt);
                    }
                }
            }
        }

        public bool ok = false;

        public bool SelectUtilizator(string nume, string parola)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT IdUtilizator FROM Utilizatori WHERE NumeUtilizator = @nume AND Parola = @parola";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@parola", parola);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ok = true;
            }

            return ok;
        }

        public void UpdateData(DateTime data, string nume)
        {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                string query = "UPDATE Utilizatori SET UltimaUtilizare = @data WHERE NumeUtilizator = @nume";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                con.Dispose();
        }

        private void Logare_Load(object sender, EventArgs e)
        {
            RetrageDateMasurare();  
            RetrageDateHarti();
        }

        private void btnContNou_Click(object sender, EventArgs e)
        {
            
            Inregistrare inr = new Inregistrare();
            this.Hide();
            inr.ShowDialog();
            this.Close();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (SelectUtilizator(txtNume.Text, txtParola.Text))
            {
                UpdateData(DateTime.Now, txtNume.Text);
                Vizualizare v = new Vizualizare();
                this.Hide();
                v.ShowDialog();
                this.Close();   
            }
            else
            {
                MessageBox.Show("Nume de utilizator si/ sau parola invalida!");
                txtNume.Text = "";
                txtParola.Text = "";
            }

        }
    }
}
