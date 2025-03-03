using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calatorie_in_timp_si_spatiu
{
    public partial class Administrare : Form
    {

        private string path;
        private string filePath;
        public int i = 0;
        public Administrare()
        {
            InitializeComponent();
            path = Directory.GetCurrentDirectory();
            filePath = Path.Combine(path, "Harta_Distantelor.txt");
        }


        int[] a = new int[27];
        int p = 0;
        bool ok = false;


        public void btnInitializare_Click(object sender, EventArgs e)
        {
            ok = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ok)
            {
                a[++p] = e.X;
                a[++p] = e.Y;
            }
        }
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBTimpSpatiu.mdf;Integrated Security=True";

        public void SalvareCoordonate(int id, int x, int y)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "UPDATE Porturi SET Pozitie_X = @poz_x, Pozitie_Y = @poz_y WHERE ID_Port = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@poz_x", x);
            cmd.Parameters.AddWithValue("@poz_y", y);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        public void Rezolva()
        {
            for (int i = 0; i < p; ++i)
            {
                int x = (int)a[i];
                int y = (int)a[i + 1];
                i++;
                SalvareCoordonate(i, x, y);
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            Rezolva();
        }

        string[] porturi = {"Constanta", "Varna", "Burgas", "Instambul", "Kozlu", "Samsun", "Batumi", "Sockumi", "Sochi",
        "Anapa", "Yalta", "Sevastopol", "Odessa"};

        public void ActuazlizareDistante(int id, int id_port, string nume, int s)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Distante(ID_Port, ID_Port_Destinatie, Nume_Port_Destinatie, Distanta) VALUES (@id_port, @id_port_dest, @nume, @dist)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id_port", id);
            cmd.Parameters.AddWithValue("@id_port_dest", id_port);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@dist", s);
            cmd.ExecuteNonQuery();  

            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }


        public void StergeDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "DELETE FROM Distante";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();
        }


        public void StergeDateCroaziere()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "DELETE FROM Croaziere";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();
        }


        public void Update(int a)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Distante SET Distanta = @distanta";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@distanta", 1);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void SelectAll()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Distante";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
          //  dataGridView1.DataSource = dt;
            dr.Close();
            conn.Dispose();
            cmd.Dispose();
            conn.Close();
        }

       public string[] s;

       public void CitesteDate()
        {
            StergeDate();
            StreamReader sr = new StreamReader(filePath);
            string line = ""; 
            char[] ch = { ' ' };
            int k = 1;

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(ch, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < 13; ++i)
                {
                    int a = Int32.Parse(s[i]);
                    ActuazlizareDistante(k, i + 1, porturi[i], a);
                }
                k++;
            }
        }


        private void btnActualizare_Click(object sender, EventArgs e)
        {
            CitesteDate();
            //SelectAll();
        }

        private void btnListaCroaziere_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            ListaCroaziere lc = new ListaCroaziere();
            lc.ShowDialog();
        }

        public void InsereazaDate3(int tp, string list, int pret)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Croaziere(Tip_Croaziera, Lista_Porturi, Pret) VALUES (@tc, @lp, @p)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tc", tp);
            cmd.Parameters.AddWithValue("@lp", list);
            cmd.Parameters.AddWithValue("@p", pret);

            cmd.ExecuteNonQuery();

            conn.Close();
            cmd.Dispose();
            conn.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            StergeDateCroaziere();
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            char[] ch = { ' ' };

            string port = "";
            int cnt_porturi = 0;
            int poz_inceput = 1;
            int i = 0;
            int poz_port_plecare = 0;
            int suma = 0;

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(ch, StringSplitOptions.RemoveEmptyEntries);
                    port += porturi[poz_port_plecare] + ", ";

                    for (i = poz_inceput; i < 13; ++i)
                    {
                        port += porturi[i] + ", ";
                        suma += 2 * Int32.Parse(s[i]);
                        cnt_porturi++;

                        if(cnt_porturi == 2)
                        { 
                            port += porturi[poz_port_plecare];
                            InsereazaDate3(3, port, suma);
                        }

                        if(cnt_porturi == 4)
                        {
                            port += porturi[poz_port_plecare];
                            InsereazaDate3(5, port, suma);
                        }

                        if (cnt_porturi == 7)
                        {
                            port += porturi[poz_port_plecare];
                            InsereazaDate3(7, port, suma);
                        }
                    }
                    
                    poz_inceput++;
                    suma = 0;
                    cnt_porturi = 0;

                    port = "";
            }
        }

    }
}
