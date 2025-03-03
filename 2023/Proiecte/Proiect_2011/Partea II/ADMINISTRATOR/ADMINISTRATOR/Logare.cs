using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADMINISTRATOR
{
    public partial class Logare : Form
    {
        public static string txt;

        public Logare()
        {
            InitializeComponent();

            lblDateNow.Text = DateTime.Now.ToString();

        }

        public void IncarcaText()
        {
            Admin a = new Admin();
            string a_text;
            a_text = textBox1.Text;
        }


        string connStr1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2011\Partea II\ADMINISTRATOR\ADMINISTRATOR\Administrator.mdf;Integrated Security=True;";
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2011\Partea II\ADMINISTRATOR\ADMINISTRATOR\Administrator.mdf;Integrated Security=True;";
        string data = DateTime.Now.ToString();  
        

        public void AfiseazaUtilizatori()
        { 

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string query = "INSERT INTO Data VALUES (@utilizatori, @data)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@utilizatori", textBox1.Text);
            cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString());

            cmd.ExecuteNonQuery();
        }

        public void SeAfla()
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Inregistrari WHERE Utilizator = @Utilizator AND Parola = @Parola", conn);
            
            cmd.Parameters.AddWithValue("@Utilizator", textBox1.Text);
            cmd.Parameters.AddWithValue("@Parola", textBox2.Text);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                if (textBox1.Text.StartsWith("u"))
                {
                    User user = new User();
                    user.Show();
                }
                else if (textBox1.Text.StartsWith("a"))
                {
                    Admin a = new Admin();
                    a.Show();
                }

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                label1.Text = "Logare nereusita";
                textBox1.Text = "";
                textBox2.Text = "";
            }
                
            cmd.Dispose();

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lblDateNow_Click(object sender, EventArgs e)
        {
        }

        private void bntLog_Click(object sender, EventArgs e)
        {
            AfiseazaUtilizatori();
            SeAfla();
        }
    }
}
