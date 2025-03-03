using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatorie_in_timp_si_spatiu
{
    public partial class Traseu : Form
    {
        public int id = TuristValidare.traseu_val;
        public string port = TuristValidare.port;
        public Traseu()
        {
            InitializeComponent();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            FormLogare fm = new FormLogare();
            fm.ShowDialog();

        }

        int[] poz_x = { 80, 45, 22, 100 , 240, 470, 750, 710, 645, 525, 360, 330, 185};
        int[] poz_y = { 265, 360, 435, 570, 530, 545, 510, 380, 325, 195, 235, 225, 35};

        public string[] s;
        public string coordonate;

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2015\Calatorie_in_timp_si_spatiu\Calatorie_in_timp_si_spatiu\DBTimpSpatiu.mdf;Integrated Security=True";
        public string cu = "";

        public string SelectCoordonate(string nume)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Pozitie_X, Pozitie_Y FROM Porturi WHERE Nume_port = @nume";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                coordonate = "";
                coordonate += dr[0].ToString() + ' ' + dr[1].ToString() + '\n';
                
            }

            return coordonate;
        }

        public void Split()
        {
            char[] c = { ',' , ' ' };
            s = port.Split(c, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < s.Length; i++)
            {
                cu += SelectCoordonate(s[i]);
            }
        }

        string[] porturi = {"Constanta", "Varna", "Burgas", "Instambul", "Kozlu", "Samsun", "Batumi", "Sockumi", "Sochi",
        "Anapa", "Yalta", "Sevastopol", "Odessa"};

        public void SalvareCoordonate1(int id, int x, int y)
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

        public void StergeDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "DELETE FROM Porturi";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();
        }

        private void Traseu_Load(object sender, EventArgs e)
        {  
            
            for (int i = 0; i < 13; ++i)
            {
                SalvareCoordonate1(i + 1, poz_x[i], poz_y[i]);
            }

            Split();
           // StergeDate();

        }

        public int x;
        public int y;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            for (int i = 0; i < s.Length - 1; ++i)
            {   
                g.DrawLine(Pens.Red, new Point(poz_x[i], poz_y[i]), new Point(poz_x[i + 1], poz_y[i + 1]));
                x = poz_x[s.Length - 1];
                y = poz_y[s.Length - 1];
            }

           g.DrawLine(Pens.Red, new Point(poz_x[0], poz_y[0]), new Point(x, y));

        }
    }
}
