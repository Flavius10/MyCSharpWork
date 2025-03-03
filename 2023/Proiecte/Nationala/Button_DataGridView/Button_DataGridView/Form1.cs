using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_DataGridView
{
    public partial class Form1 : Form
    {

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BazaDate.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            CitesteUtilizatori();
            SelectAll();
        }

        private void CitesteUtilizatori()
        {
            StreamReader sr = new StreamReader("utilizatori.txt");
            string[] s;
            string line = sr.ReadLine();
            char[] split = { ';' };

            s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

            string nume = s[0];
            string email = s[1];
            string parola = s[2];

            InsertDate(nume, email, parola);
        }

        public void InsertDate(string nume, string email, string parola)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(Nume, Email, Parola) VALUES (@nume, @email, @parola)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void SelectAll()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Apasa";
            btn.UseColumnTextForButtonValue = true;
            btn.Text = "Apasa";

            dataGridView1.Columns.Add(btn);

            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgw = (DataGridView)sender;

            if (dgw.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string nume = dgw.CurrentRow.Cells["Nume"].Value.ToString();
                string email = dgw.CurrentRow.Cells["Email"].Value.ToString();
                string parola = dgw.CurrentRow.Cells["Parola"].Value.ToString();

                MessageBox.Show("Nume: " + nume + '\n' + "Email: " + email + '\n' + "Parola: " + parola, "Date", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Gradient gradient = new Gradient();
                gradient.ShowDialog();
                this.Close();
            }
        }
    }
}
