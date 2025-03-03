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

namespace Bursa_Nume_Prenume
{
    public partial class Grafic_profit : Form
    {
        public Grafic_profit()
        {
            InitializeComponent();
        }

        public int y;



        private void Grafic_profit_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(Pens.Blue, new Point(50, 40), new Point(50, 400));
            g.DrawLine(Pens.Blue, new Point(50, 400), new Point(600, 400));

            string[] a = {"Azomed", "Tepra", "Raddin","Nelacom","Daleprod"};
            int xp = 50;
            int yp = 400;

            for (int i = 0; i < 5; ++i)
            {
                y = SelecteazaProfit(a[i]);

                if (y < 0)
                    y += -2 * y;
                if (y / 10 > 100)
                    y /= 10;

                g.DrawLine(Pens.Red, new Point(xp, yp), new Point(xp + 50, y));
                xp += 50;
                yp = y;
            }
        }

        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2014\Bursa_Nume_Prenume\Bursa_Nume_Prenume\DBBursa.mdf;Integrated Security=True";
        string[] a = { "Azomed", "Tepra", "Raddin", "Nelacom", "Daleprod" };

        public int SelecteazaProfit(string b)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT Profit_Pierdere_total FROM Actiunile_mele WHERE Denumire = @denumire";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@denumire", b);

            SqlDataReader dr = cmd.ExecuteReader(); 
            while(dr.Read()) 
            {
                y = Int32.Parse(dr["Profit_Pierdere_total"].ToString());
            }

            return y;

        }
    }
}
