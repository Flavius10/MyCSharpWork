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

namespace Baze_de_date_programatic
{
   
    public partial class Form1 : Form
    {
        
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Angajati.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            SelectAll();
        }

        public void SelectAll()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Angajati";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            dgwAngajati.DataSource = dt;
            
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.Text = "Update";
            bt.UseColumnTextForButtonValue = true;
            bt.HeaderText = "Update";
            
            dgwAngajati.Columns.Add(bt);

            dr.Close();
            dt.Dispose();

            con.Dispose();
            con.Close();
            cmd.Dispose();
        }

        public void InsereazaDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Angajati(Nume, Pozitie, Salariu, Data_angajare) VALUES (@nume, @pozitie, @salariu, @data)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", txtNume.Text);
            cmd.Parameters.AddWithValue("@pozitie", txtPozitie.Text);
            cmd.Parameters.AddWithValue("@salariu", txtSalariu.Text);
            cmd.Parameters.AddWithValue("@data", dgwInsereaza.Value);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        private void btnInsereaza_Click(object sender, EventArgs e)
        {
            InsereazaDate();
            SelectAll();
        }

        private void UpdateDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Angajati SET Nume = @nume, Pozitie = @pozitie, Salariu = @salariu, Data_angajare = @data WHERE Id_angajare = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", txtNumeU.Text);
            cmd.Parameters.AddWithValue("@pozitie", txtPozitieU.Text);
            cmd.Parameters.AddWithValue("@salariu", txtSalariuU.Text);
            cmd.Parameters.AddWithValue("@data", dgwUpdate.Value);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose (); 
            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDate();
            SelectAll();
        }

        private void dgwAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwAngajati = (DataGridView)sender;

            if (dgwAngajati.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                this.Hide();
                UpdateForm uf = new UpdateForm();
                uf.ShowDialog();
                this.Close();
            }
        }
    }
}
