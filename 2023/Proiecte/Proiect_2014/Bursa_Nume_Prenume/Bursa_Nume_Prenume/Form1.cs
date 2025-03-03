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
using System.Xml.Linq;
using System.IO;

namespace Bursa_Nume_Prenume
{
    public partial class formPrincipalBusra : Form
    {
        private Timer timer;
        public int a;
        public int b;
        string path = @"C:\\Folders\\Info\\C#\\Proiect_2014\\Bursa_Nume_Prenume";
        

        public formPrincipalBusra()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = Convert.ToInt32(nudRata.Value);
            timer.Tick += OnTick;

            btnInchideBursa.Enabled = false;
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2014\Bursa_Nume_Prenume\Bursa_Nume_Prenume\DBBursa.mdf;Integrated Security=True";


        public void AfiseazaBursa()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Actiuni";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dgBursa.DataSource = dt;
            dr.Close();

            cmd.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void UpdateDataBase(int id, int val)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Actiuni SET Valoare = @valoare WHERE IDActiune = @id_act";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@valoare", val);
            cmd.Parameters.AddWithValue("@id_act", id);
            cmd.ExecuteNonQuery();

            con.Close();
            cmd.Dispose();
            con.Dispose();
        }

        public int SelectValoare(int id)
        {
            SqlConnection con = new SqlConnection(connStr); 
            con.Open();

            string query = "SELECT Valoare FROM Actiuni WHERE IDActiune = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                a = Int32.Parse(dr["Valoare"].ToString());
                
            }

            return a;
            con.Close();
            con.Dispose();
            cmd.Dispose();

        }

        private void OnTick(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 1; i <= 5; ++i)
            {
                   int val = r.Next(-200, 200);
                   UpdateDataBase(i, val);
            }

            AfiseazaBursa();
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

        public int e;
        public int Profit()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Profit_Pierdere_total FROM Actiunile_mele";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                e = Int32.Parse(dr["Profit_Pierdere_total"].ToString());
                suma += e;
            }

            return suma;

        }

        string[] a1 = { "Azomed", "Tepra", "Raddin", "Nelacom", "Daleprod" };
        int[] b1 = { 5, 15, 0, 200, 0 };
        int[] c = { 25, 12, 4, 8, 7 };
        static public int suma = 0;

        private void btnDeschideBursa_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnInchideBursa.Enabled = true;


            DeleteDate();
            for (int i = 0; i < 5; ++i)
            {
                suma = 0;
                Random random = new Random();
                int d = random.Next(-5, 5);
                InsertDate(a1[i], b1[i], c[i], d);
                suma = Profit();
            }

        }

        private void formPrincipalBusra_Load(object sender, EventArgs e)
        {

        }

        private void nudRata_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(nudRata.Value.ToString());
        }

        int[] preturi_initiale = { 25, 12, 4, 8, 7};

        private void btnInchideBursa_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter(@"C:\\Folders\\Info\\C#\\Proiect_2014\\Bursa_Nume_Prenume\\rezultate.txt");
            timer.Stop();
            for(int i = 0; i < 5; ++i)
            {
                int b = SelectValoare(i + 1);
                int pret_final = b + preturi_initiale[i];
                File.Write("Profit/pierdere: " + pret_final.ToString() + '\n');
            }
            
            
            File.Close();
        }

        private void actiunileMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actiunile_mele am = new Actiunile_mele();
            am.ShowDialog();
        }

        private void graficProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafic_profit gp = new Grafic_profit();
            gp.ShowDialog();
        }
    }
}
