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

namespace GOOD_FOOD
{
    public partial class Autentificare_client : Form
    {
        public Autentificare_client()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";

        bool ok_email = false;
        bool ok_password = false;   

        public void SelectEmailParola()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT parola, email FROM Clienti";
            SqlCommand cmd = new SqlCommand(query, con);    
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                if (dr[0].ToString() == txtParola.Text)
                {
                    ok_password = true;
                }

                if (dr[1].ToString() == txtEmail.Text)
                {
                    ok_email = true;
                }

            }
        }

        private void btnIntra_Click(object sender, EventArgs e)
        {
            ok_password = false;
            ok_email = false;

            SelectEmailParola();

            if (ok_password  && ok_email)
            {
                this.Hide();
                Optiuni o = new Optiuni(txtEmail.Text);
                o.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Eroare autentificare!");
                txtEmail.Text = "";
                txtParola.Text = "";
            }
        }
    }
}
