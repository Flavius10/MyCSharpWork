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

namespace Calatorie_in_timp_si_spatiu
{
    public partial class ListaCroaziere : Form
    {
        public ListaCroaziere()
        {
            InitializeComponent();
            cmbCroaziera.Items.Add("3 zile");
            cmbCroaziera.Items.Add("5 zile");
            cmbCroaziera.Items.Add("8 zile");
            cmbCroaziera.SelectedItem = "3 zile";
        }

        private void btnInchidere_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();

            FormLogare fl = new FormLogare();
            fl.ShowDialog();
        }

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBTimpSpatiu.mdf;Integrated Security=True";

        private void SelectAll()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Croaziere";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCroaziere.DataSource = dt;
            dr.Close();
            conn.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void SelectTip(int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Croaziere WHERE Tip_Croaziera = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            

            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCroaziere.DataSource = dt;

            dr.Close();
            con.Dispose();
            con.Close();
            cmd.Dispose();
        }

        private void ListaCroaziere_Load(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void cmbCroaziera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCroaziera.SelectedIndex == 0) 
            {
                SelectTip(3);
            }

            if (cmbCroaziera.SelectedIndex == 1)
            {
                SelectTip(5);
            }

            if (cmbCroaziera.SelectedIndex == 2)
            {
                SelectTip(7);
            }
        }


    }
}
