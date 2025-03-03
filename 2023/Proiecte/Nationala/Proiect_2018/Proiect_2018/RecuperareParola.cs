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

namespace Proiect_2018
{
    public partial class RecuperareParola : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CentenarDB.mdf;Integrated Security=True";
        string email = string.Empty;
        Random r = new Random();
        string path = Directory.GetCurrentDirectory();
        int x1, x2, x3, x4,x5, x6;
        int cnt = 0;
        int[] numere = new int[]{1, 5, 6, 8, 9, 12, 13, 15, 17, 18, 19, 20};
        bool[] ok = new bool[6];
        int[] ints = new int[6];
        bool ok_imagini = true;
        bool[] ok_imagine = new bool[6];

        private void pb3_Click(object sender, EventArgs e)
        {
            pb3.BorderStyle = BorderStyle.FixedSingle;
            ok[2] = true;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            pb4.BorderStyle = BorderStyle.FixedSingle;
            ok[3] = true;
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            pb5.BorderStyle = BorderStyle.FixedSingle;
            ok[4] = true;
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            pb6.BorderStyle = BorderStyle.FixedSingle;
            ok[5] = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Centenar_Start cs = new Centenar_Start();
            cs.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDate(txtParola.Text, email);
            this.Hide();
            Centenar_Start cs = new Centenar_Start();
            cs.ShowDialog();
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 6; ++i)
            {
                if (ok[i] == true)
                {
                    for (int j = 0; j < 12; ++j)
                    {
                        if (numere[j] == ints[i])
                            ok_imagine[i] = true;
                    }
                }    
            }

            for (int i = 0; i < 6; ++i)
            {
                if (ok[i] == true)
                {
                    if (ok_imagine[i] == false)
                      ok_imagini = false;
                }
                
            }
               

            if (ok_imagini == true)
                groupBox1.Enabled = true;
        }

        private void pb2_MouseClick(object sender, MouseEventArgs e)
        {
            pb2.BorderStyle = BorderStyle.FixedSingle;
            ok[1] = true;
        }

        private void pb1_MouseClick(object sender, MouseEventArgs e)
        {
            pb1.BorderStyle = BorderStyle.FixedSingle;
            ok[0] = true;
        }

        public void UpdateDate(string parola, string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Utilizatori SET Parola = @parola WHERE Email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public RecuperareParola(string email)
        {
            InitializeComponent();
            this.email = email;
            label1.Text += this.email;
            groupBox1.Enabled = false;

            x1 = r.Next(1, 20);
            ints[0] = x1;
            path = Path.Combine(path, @"Resurse_C#\Captcha\" + x1.ToString() + ".jpg");
            pb1.Image = Image.FromFile(path);
            path = Directory.GetCurrentDirectory();

            x2 = r.Next(1, 20);
            ints[1] = x2;
            path = Path.Combine(path, @"Resurse_C#\Captcha\" + x2.ToString() + ".jpg");
            pb2.Image = Image.FromFile(path);
            path = Directory.GetCurrentDirectory();

            x3 = r.Next(1, 20);
            ints[2] = x3;
            path = Path.Combine(path, @"Resurse_C#\Captcha\" + x3.ToString() + ".jpg");
            pb3.Image = Image.FromFile(path);
            path = Directory.GetCurrentDirectory();

            x4 = r.Next(1, 20);
            ints[3] = x4;
            path = Path.Combine(path, @"Resurse_C#\Captcha\" + x4.ToString() + ".jpg");
            pb4.Image = Image.FromFile(path);
            path = Directory.GetCurrentDirectory();

            x5 = r.Next(1, 20);
            ints[4] = x5;
            path = Path.Combine(path, @"Resurse_C#\Captcha\" + x5.ToString() + ".jpg");
            pb5.Image = Image.FromFile(path);
            path = Directory.GetCurrentDirectory();

            x6 = r.Next(1, 20);
            ints[5] = x6;
            path = Path.Combine(path, @"Resurse_C#\Captcha\" + x6.ToString() + ".jpg");
            pb6.Image = Image.FromFile(path);
            path = Directory.GetCurrentDirectory();
        }
    }
}
