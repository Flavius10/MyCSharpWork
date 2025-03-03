using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollutionMap
{
    public partial class AdaugaMasurare : Form
    {
        private int id_harta = 0;
        private int poz_x = 0;
        private int poz_y = 0;
        DateTime dt1 = DateTime.Now;
        public AdaugaMasurare(int id, int x, int y, DateTime dt)
        {
            InitializeComponent();
            id_harta = id;
            poz_x = x;
            poz_y = y;
            dt1 = dt;
            
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Poluare.mdf;Integrated Security=True";

        public void InsertDate(int id, int x, int y, DateTime dt)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Masurare(IdHarta, PozitieX, PozitieY, ValoareMasurare, DataMasurare) VALUES (@id, @x, @y, @valoare, @dt)";
            SqlCommand cmd  = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@x", x);
            cmd.Parameters.AddWithValue("@y", y);
            cmd.Parameters.AddWithValue("@valoare", txtValoare.Text);
            cmd.Parameters.AddWithValue("@dt", dt);

            cmd.ExecuteNonQuery();

            con.Dispose();
            con.Close();
            cmd.Dispose();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {   
            this.Hide();
            InsertDate(id_harta, poz_x, poz_y, dt1);

            Vizualizare viz = new Vizualizare();
            viz.ShowDialog();
            
            this.Close();
        }
    }
}
