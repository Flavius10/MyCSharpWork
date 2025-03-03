using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace TURISMUL_DURABIL
{
    public partial class TurismForm : Form
    {
        public TurismForm()
        {
            InitializeComponent();
        }

        public static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Folders\Info\C#\Proiect_2017\TURISMUL DURABIL\TURISMUL DURABIL\Turism.mdf"";Integrated Security=True";


        public void Sterge()
        {
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Imagini", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand("DELETE FROM Planificari", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();  

            cmd = new SqlCommand("DELETE FROM Localitati", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            con.Close();

        }

        public static void Initializare()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            StreamReader st = new StreamReader(Application.StartupPath + @"\..\..\planificari.txt");

            string sir;
            char[] split = { '*' };

            con.Open();

            DateTime dt1, dt2;

            while ((sir = st.ReadLine()) != null)
            {
                string[] siruri = sir.Split(split);
                cmd = new SqlCommand("INSERT INTO Localitati(nume) VALUES (@localitate)", con);
                cmd.Parameters.AddWithValue("localitate", siruri[0].Trim());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT IDLocalitate FROM Localitati WHERE nume = @nume", con);
                cmd.Parameters.AddWithValue("nume", siruri[0].Trim());
                

                int idlocalitate = Convert.ToInt32(cmd.ExecuteScalar());
                int nrzile;

                switch(siruri[1].Trim())
                {
                    case "ocazional":
                        string d1 = siruri[2], d2 = siruri[3];
                            dt1 = Convert.ToDateTime(d1.Trim(), System.Globalization.CultureInfo.GetCultureInfo("fr-FR"));
                            dt2 = Convert.ToDateTime(d2.Trim(), System.Globalization.CultureInfo.GetCultureInfo("fr-FR"));
                        int i = 4;

                        while( i < siruri.Length )
                        {
                            cmd = new SqlCommand(@"INSERT INTO Imagini(IDLocalitate, CaleFisier) VALUES(@IDLocalitate, @CaleFisier)", con);
                            cmd.Parameters.AddWithValue("IDLocalitate", idlocalitate);
                            cmd.Parameters.AddWithValue("CaleFisier", siruri[i].Trim());
                            cmd.ExecuteNonQuery();
                            i++;
                        }

                        cmd = new SqlCommand(@"INSERT INTO Planificari(idlocalitate, frecventa, datastart, datastop) VALUES (@idlocalitate, @frecventa, @datastart, @datastop)", con);
                        cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                        cmd.Parameters.AddWithValue("frecventa","ocazional");
                        cmd.Parameters.AddWithValue("datastart", dt1);
                        cmd.Parameters.AddWithValue("datastart", dt1);
                        cmd.Parameters.AddWithValue("datastop", dt2);
                        cmd.ExecuteNonQuery();
                            break;



                    case "anual":
                        nrzile = int.Parse(siruri[2]);
                        i = 3;
                        while( i < siruri.Length )
                        {
                            cmd = new SqlCommand("INSERT INTO Planificari(idlocalitate, calefisier) VALUES (@idlocalitate,@calefisier)", con);
                            cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                            cmd.Parameters.AddWithValue("calefisier", siruri[i].Trim());
                            cmd.ExecuteNonQuery();
                            i++;
                        }

                        cmd = new SqlCommand(@"INSERT INTO Planificari(idlocalitate, frecventa, ziua) VALUES (@idlocalitate, @frecventa, @ziua)", con);
                        cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                        cmd.Parameters.AddWithValue("frecventa", "anual");
                        cmd.Parameters.AddWithValue("ziua", nrzile);
                        cmd.ExecuteNonQuery();

                        break;
                    case "lunar":
                        nrzile = int.Parse(siruri[2]);
                        i = 3;
                        while (i < siruri.Length)
                        {
                            cmd = new SqlCommand("INSERT INTO Planificari(idlocalitate, calefisier) VALUES (@idlocalitate,@calefisier)", con);
                            cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                            cmd.Parameters.AddWithValue("calefisier", siruri[i].Trim());
                            cmd.ExecuteNonQuery();
                            i++;
                        }

                        cmd = new SqlCommand(@"INSERT INTO Planificari(idlocalitate, frecventa, ziua) VALUES (@idlocalitate, @frecventa, @ziua)", con);
                        cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                        cmd.Parameters.AddWithValue("frecventa", "lunar");
                        cmd.Parameters.AddWithValue("ziua", nrzile);
                        cmd.ExecuteNonQuery();
                        break;
                }
            }
            MessageBox.Show("Initializarea a fost initiata cu succes");
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Sterge();
            Initializare();
        }
    }
}
