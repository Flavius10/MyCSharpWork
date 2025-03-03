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

namespace AplicatieFreeBook
{
    public partial class AfiseazaCarte : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private string filePath = "";

        public AfiseazaCarte(string carte)
        {
            InitializeComponent();
            int id = SelectId(carte);
            filePath = Path.Combine(path, @"cartipdf\", id.ToString() + ".pdf");

            var url = new Uri(filePath);

            webBrowser1.Navigate(url);
            
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FreeBook.mdf;Integrated Security=True";
        int id = 0;

        public int SelectId(string carte)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT id_carte FROM carti WHERE titlu = @titlu";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@titlu", carte);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                id = Convert.ToInt32(dr["id_carte"]);
            }

            return id;
        }
    }
}
