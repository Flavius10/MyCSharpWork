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

namespace Top3Recordings
{
    public partial class FormaIntroducereDate : Form
    {

        private string dataBaseConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Inforamtii.mdf;Integrated Security=True";
        private string name;
        private string email;
        private int punctaj;


        public FormaIntroducereDate()
        {
            InitializeComponent();
        }

        private void InsertDate(string nume, string email, int punctaj)
        {
            SqlConnection conn = new SqlConnection(dataBaseConnection);
            conn.Open();

            string query = "INSERT INTO Date(Nume, Email, Puncte) VALUES (@nume, @email, @puncte)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@puncte", punctaj);

            cmd.ExecuteNonQuery();


            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            name = txtNume.Text;    
            email = txtEmail.Text;
            punctaj = Int32.Parse(txtPunctaj.Text.ToString());

            InsertDate(name, email, punctaj);

            MainPage mp = new MainPage();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }
    }
}
