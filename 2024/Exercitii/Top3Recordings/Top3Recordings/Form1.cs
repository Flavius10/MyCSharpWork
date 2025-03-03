using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top3Recordings
{
    public partial class MainPage : Form
    {
        private string dataBaseConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Inforamtii.mdf;Integrated Security=True";

        public MainPage()
        {
            InitializeComponent();
            SelectAll();
        }

        private void SelectAll()
        {
            SqlConnection conn = new SqlConnection(dataBaseConnection);
            conn.Open();

            string query = "SELECT TOP 3 * FROM Date ORDER BY Puncte DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(reader);

            dgwDate.DataSource = dt;

            conn.Close();
            cmd.Dispose();
            reader.Close();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            FormaIntroducereDate fid = new FormaIntroducereDate();
            this.Hide();
            fid.ShowDialog();
            this.Close();
        }
    }
}
