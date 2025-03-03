using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Calatorie_in_timp_si_spatiu
{
    public partial class TuristValidare : Form
    {
        private string path;
        private string filePath; 
        public TuristValidare()
        {
            InitializeComponent();
            cmbZile.Items.Add("3 zile");
            cmbZile.Items.Add("5 zile");
            cmbZile.Items.Add("8 zile");

            cmbZile.SelectedItem = "3 zile";

            path = Directory.GetCurrentDirectory();
            filePath = Path.Combine(path, "Harta_Distantelor.txt");
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBTimpSpatiu.mdf;Integrated Security=True";

        public void SelectAll(int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Croaziere WHERE Tip_Croaziera = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dgwDate.DataSource = dt;

            dr.Close();
            con.Close();
            con.Dispose();
            cmd.Dispose();
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

        string[] s;
        string[] porturi = {"Constanta", "Varna", "Burgas", "Instambul", "Kozlu", "Samsun", "Batumi", "Sockumi", "Sochi",
        "Anapa", "Yalta", "Sevastopol", "Odessa"};


        private void TuristValidare_Load(object sender, EventArgs e)
        {
            StergeDateCroaziere();
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            char[] ch = { ' ' };

            string port = "";
            string port1 = "";
            string port2 = "";
            int cnt_porturi1 = 0;
            int cnt_porturi2 = 0;
            int cnt_porturi3 = 0;
            int poz_inceput = 1;
            int i = 0;
            int poz_port_plecare = 0;
            int suma = 0;

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(ch, StringSplitOptions.RemoveEmptyEntries);
                port += porturi[poz_port_plecare] + ", ";
                port1 += porturi[poz_port_plecare] + ", ";
                port2 += porturi[poz_port_plecare] + ", ";

                for (i = poz_inceput; i < 13; ++i)
                {
                    port += porturi[i] + ", ";
                    port1 += porturi[i] + ", ";
                    port2 += porturi[i] + ", ";
                    suma += 2 * Int32.Parse(s[i]);
                    cnt_porturi1++;
                    cnt_porturi2++;
                    cnt_porturi3++;

                    if (cnt_porturi1 == 2)
                    {
                        port += porturi[poz_port_plecare];
                        InsereazaDate3(3, port, suma);
                    }

                    if (cnt_porturi2 == 4)
                    {
                        port1 += porturi[poz_port_plecare];
                        InsereazaDate3(5, port1, suma);
                    }

                    if (cnt_porturi3 == 7)
                    {
                        port2 += porturi[poz_port_plecare];
                        InsereazaDate3(7, port2, suma);
                    }
                }

                poz_inceput++;
                suma = 0;
                cnt_porturi1 = 0;
                cnt_porturi2 = 0;
                cnt_porturi3 = 0;

                port = "";
                port1 = "";
                port2 = "";
            }
        }

        private void cmbZile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZile.SelectedIndex == 0)
            {
                SelectAll(3);
            }

            if (cmbZile.SelectedIndex == 1)
            {
                SelectAll(5);
            }
            if (cmbZile.SelectedIndex == 2)
            {
                SelectAll(7);
            }
        }


        public void Update(int pas, string ds, string df, int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Croaziere SET Data_Start = @ds, Data_Final = @df, Nr_Pasageri = @pas WHERE ID_Croaziera = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ds", ds);
            cmd.Parameters.AddWithValue("@df", df);
            cmd.Parameters.AddWithValue("@pas", pas);
            cmd.Parameters.AddWithValue("@id", id);
            
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public static string port = "";

        public string SelectFrom(int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Lista_Porturi FROM Croaziere WHERE ID_Croaziera = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                port = dr["Lista_Porturi"].ToString();
            }

            return port;

            con.Close();
            cmd.Dispose();
            con.Dispose();

        }

        public int pas = 0;
        public static int traseu_val = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBox1.Text);
            traseu_val = id;
            pas++;
            SelectFrom(id);
            Update(pas , dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), id);

            if (cmbZile.SelectedIndex == 0)
            {
                SelectAll(3);
            }

            if (cmbZile.SelectedIndex == 1)
            {
                SelectAll(5);
            }
            if (cmbZile.SelectedIndex == 2)
            {
                SelectAll(7);
            }

            this.Hide();
            this.Close();

            Traseu t = new Traseu();
            t.ShowDialog();


        }

        
    }
}
