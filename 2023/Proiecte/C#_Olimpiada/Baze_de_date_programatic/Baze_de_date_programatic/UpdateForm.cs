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
    public partial class UpdateForm : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Angajati.mdf;Integrated Security=True";

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Angajati SET Nume = @nume, Pozitie = @pozitie, Salariu = @salariu, Data_angajare = @data WHERE Id_angajare = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", txtNume.Text);
            cmd.Parameters.AddWithValue("@pozitie", txtPozitie.Text);
            cmd.Parameters.AddWithValue("@salariu", txtSalariu.Text);
            cmd.Parameters.AddWithValue("@data", dtpUpdate.Value);
            cmd.Parameters.AddWithValue("@id", txtId.Text);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDate();
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
