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

namespace Bursa_Nume_Prenume
{
    public partial class Actiunile_mele : Form
    {
        public int e;
        public Actiunile_mele()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2014\Bursa_Nume_Prenume\Bursa_Nume_Prenume\DBBursa.mdf;Integrated Security=True";

        public void ScrieDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Actiunile_mele";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();

            con.Close();
            cmd.Dispose();
            con.Dispose();
        }

        public void InsertDate(string a, int b, int c, int d)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Actiunile_mele (Denumire, Numar_Actiuni, Valoare_actiune_INITIAL, Valoare_actiune_momentana, Valoarea_cu_care_a_crescut_acțiunea_momentan, Total_Valoare_Inițial, Total_valoare_momentană, Profit_Pierdere_momentană, Profit_Pierdere_total) VALUES (@denumire, @nr_act, @val, @val_mom,@valoare, @tvi, @tvm, @pm, @pt)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@denumire", a);
            cmd.Parameters.AddWithValue("@nr_act", b);
            cmd.Parameters.AddWithValue("@val", c);
            cmd.Parameters.AddWithValue("@val_mom", c);
            cmd.Parameters.AddWithValue("@tvi", c * b);
            cmd.Parameters.AddWithValue("@valoare", d);
            cmd.Parameters.AddWithValue("@tvm", c * b);
            cmd.Parameters.AddWithValue("@pm", b * d);
            cmd.Parameters.AddWithValue("@pt", b * d - c * b);

            cmd.ExecuteNonQuery();

        }

        public void DeleteDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "DELETE FROM Actiunile_mele";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public int Profit()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Profit_Pierdere_total FROM Actiunile_mele";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                e = Int32.Parse(dr["Profit_Pierdere_total"].ToString());
                suma += e;
            }

            return suma;

        }


        string[] a = { "Azomed", "Tepra", "Raddin", "Nelacom", "Daleprod" };
        int[] b = { 5, 15, 0, 200, 0};
        int[] c = { 25, 12, 4, 8, 7};
        public int suma = 0;
        private void Actiunile_mele_Load(object sender, EventArgs e)
        {
            ScrieDate();
            textBox1.Text = (formPrincipalBusra.suma).ToString();
        }

    }
}
