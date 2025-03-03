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


namespace Proiect_2018
{
    public partial class VizualizareLectii : Form
    {
        string path = Directory.GetCurrentDirectory();
        string lectia = string.Empty;
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CentenarDB.mdf;Integrated Security=True";
        int id = 0;
        string regiune = string.Empty;
        string data;
        string nume;
        string email;

        public VizualizareLectii()
        {
            InitializeComponent();
            lbLectii.Items.Add("lectia1");
            lbLectii.Items.Add("lectia2");
            lbLectii.Items.Add("lectia3");

            pbImagine.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lbLectii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLectii.SelectedIndex == 0)
            {
                path = string.Empty;
                path = Path.Combine(path, @"Resurse_C#\ContinutLectii\lectia1.bmp");
                lectia = "lectia1";
            }

            if (lbLectii.SelectedIndex == 1)
            {
                path = string.Empty;
                path = Path.Combine(path, @"Resurse_C#\ContinutLectii\lectia2.bmp");
                lectia = "lectia2";
            }
                
            if (lbLectii.SelectedIndex == 2)
            {
                path = string.Empty;
                path = Path.Combine(path, @"Resurse_C#\ContinutLectii\lectia3.bmp");
                lectia = "lectia3";
            }
               
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            pbImagine.Image = Image.FromFile(path);
            CitesteIdCititor(lectia);
            CitesteDateUtilizator(id);

            richTextBox1.Text = nume + '\n' + email + '\n' + regiune + '\n' + data;
;        }

        public void CitesteIdCititor(string lectia)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT IdUtilizator, Regiune, DataCreare FROM Lectii WHERE NumeImagine = @lectia";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@lectia", lectia);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                id = Int32.Parse(dr[0].ToString());
                regiune = dr[1].ToString();
                data = dr[2].ToString();
            }

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();

        }

        public void CitesteDateUtilizator(int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Nume, Email FROM Utilizatori WHERE IdUtilizator = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                nume = dr[0].ToString();
                email = dr[1].ToString();
            }

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }
    }
}
