using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMINISTRATOR
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2011\Partea II\ADMINISTRATOR\ADMINISTRATOR\Administrator.mdf;Integrated Security=True";
     

        public void SeAfla()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT Utilizator FROM Inregistrari";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }

            dr.Close();

            conn.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SeAfla();
        }

        //pt a afisa toate datele cand s-au conectat useri
        public void ConnectUser()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Data WHERE Utilizator = @Utilizator";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Utilizator", comboBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectUser();
        }
    }
}
