using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismul_de_pretutindeni
{
    public partial class FrmAutentificare : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TurismDB.mdf;Integrated Security=True";
        private bool ok_email = false;
        private bool ok_password = false;
        string email = "";
        int cnt = 0;
        private int tip = 0;

        public FrmAutentificare()
        {
            InitializeComponent();
            if (cnt == 0)
            {
                CitesteDate();
            }

            cbRetine.Checked = true;
        }

        public void CitesteDate()
        {
            StreamReader sr = new StreamReader("Email.txt");
            string line = sr.ReadLine();
            if (line != null)
            {
                txtEmail.Text = line;
            }
            else
                cnt--;

            sr.Dispose();
        }

        private void SelectFromBazaDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();    

            while(rdr.Read())
            {
                if (txtEmail.Text == rdr[3].ToString())
                {
                    ok_email = true;
                    tip = Int32.Parse(rdr[5].ToString());
                }
                if (txtParola.Text == rdr[4].ToString()) 
                    ok_password = true; 
            }

            rdr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();

        }

        private void btnAutientificare_Click(object sender, EventArgs e)
        {
            SelectFromBazaDate();

            if(ok_email && ok_password)
            {
                StreamWriter sw = new StreamWriter("Email.txt");
                sw.WriteLine(email);

                sw.Dispose();


                if (tip == 0)
                {
                    this.Hide();
                    FrmVacanta fv = new FrmVacanta("Admin", txtEmail.Text);   
                    fv.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    FrmVacanta fv = new FrmVacanta("File", txtEmail.Text);
                    fv.ShowDialog();
                    this.Close();
                }
   
            }
            else
            {
                MessageBox.Show("Eroare de autentificare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtParola.Text = "";
                cbRetine.Checked = false;
            }
        }

        private void cbRetine_CheckedChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInregistrare fi = new FrmInregistrare();
            fi.ShowDialog();
            this.Close();
        }
    }
}
