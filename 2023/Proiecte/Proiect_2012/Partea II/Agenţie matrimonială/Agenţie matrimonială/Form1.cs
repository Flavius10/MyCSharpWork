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

namespace Agenţie_matrimonială
{
    public partial class FormMatrimoniale : System.Windows.Forms.Form
    {
        public FormMatrimoniale()
        {
            InitializeComponent();
            if (varsta_medie == 0 && nr_barbati == 0)
                btnVarsta.Visible = false;
            else
                btnVarsta.Visible = true;

            SelectAllMatr();
        }

        int nr_barbati = 0;
        int varsta_medie = 0;
        public string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2012\Partea II\Agenţie matrimonială\Agenţie matrimonială\Matrimoniale.mdf;Integrated Security=True";

        public void SelectAllMatr()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            varsta_medie += Int32.Parse(txtVarsta.Text); 
            nr_barbati++;

            string query = "SELECT * FROM Matrimoniale";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;
            dr.Close();

            con.Close();
            con.Dispose();
            cmd.Dispose();

        }

        public void AdaugaMatr()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "INSERT INTO Matrimoniale VALUES (@nume, @prenume, @varsta, @sex, @ocupatie)";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@nume", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenume", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@varsta", txtVarsta.Text);  
            cmd.Parameters.AddWithValue("@sex", txtSex.Text);
            cmd.Parameters.AddWithValue("@ocupatie", txtOcupatie.Text);

            cmd.ExecuteNonQuery();

            SelectAllMatr();
        }

        public void SelecteazaMtr()
        {
            SqlConnection con = new SqlConnection (connString);
            con.Open();

            string query = "SELECT * FROM Matrimoniale WHERE Id = @id";
            SqlCommand cmd = new SqlCommand (query, con);

            cmd.Parameters.AddWithValue("@id", txtId.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable(); 
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            reader.Close();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public bool ok = true;

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtNume.Text == string.Empty)
            {
               ok = false;
            }

            if (txtPrenume.Text == string.Empty)
            {
                ok = false;
            }

            if (txtVarsta.Text == string.Empty)
            {
                ok = false;
            }

            if (txtSex.Text == string.Empty)
            {
                ok = false;
            }

            if (txtOcupatie.Text == string.Empty)
            {
                ok = false;
            }


            if (ok == true)
            {
                AdaugaMatr();
                txtNume.Text = "";
                txtPrenume.Text = "";
                txtVarsta.Text = "";
                txtSex.Text = "";
                txtOcupatie.Text = "";
                MessageBox.Show("Operatia de adaugare s-a finalizat cu succes");
            }
            else
            {
                MessageBox.Show("Date invalide. Verificati campurile incomplete");
                ok = true;
                txtNume.Text = "";
                txtPrenume.Text = "";
                txtVarsta.Text = "";
                txtSex.Text = "";
                txtOcupatie.Text = "";
            }
        }

        private void btnVarsta_Click(object sender, EventArgs e)
        {
            lblVarstaMedie.Text = "Media varstei " + (varsta_medie / nr_barbati).ToString();
        }

        private void btnVarsta_Leave(object sender, EventArgs e)
        {
            lblVarstaMedie.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelecteazaMtr();
        }

        public void EditMtr()
        {
            var con = new SqlConnection(connString);
            con.Open();

            string query = "UPDATE Matrimoniale SET Nume = @nume, Prenume = @prenume, Varsta = @varsta, Sex = @sex, Ocupatie = @ocupatie WHERE Id = @Id";

            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", txtNume.Text);
            cmd.Parameters.AddWithValue("@prenume", txtPrenume.Text);
            cmd.Parameters.AddWithValue("@varsta", txtVarsta.Text);
            cmd.Parameters.AddWithValue("@sex", txtSex.Text);
            cmd.Parameters.AddWithValue("@ocupatie", txtOcupatie.Text);
            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));

            cmd.ExecuteNonQuery();
        }

        public void StergeMtr()
        {
            var con = new SqlConnection(connString);
            con.Open();

            string query = "DELETE FROM Matrimoniale WHERE Id = @id";

            var cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Int32.Parse(txtId.Text));

            cmd.ExecuteNonQuery();
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            EditMtr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StergeMtr();
        }
    }
}
