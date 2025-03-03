using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOOD_FOOD
{
    public partial class Vizualizare_comanda : Form
    {

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";

        private string path = Directory.GetCurrentDirectory();
        private string filePath = "";
        private string id = "";
        int total1 = 0;
        int pret1 = 0;
        private string email = "";
        DateTime dt;
        private int id1 = 0;

        public Vizualizare_comanda(string necesar, string total, string pret,string id, string email, DateTime dt)
        {
            InitializeComponent();
            txtNecesar.Text = necesar;
            txtKcal.Text = total;
            txtPret.Text = pret;
            this.id = id;
            total1 = Int32.Parse(total);
            pret1 = Int32.Parse(pret);
            this.email = email;
            this.dt = dt;



            id1 = SelectIdClient(email);

            filePath = Path.Combine(path, "meniu.txt");
        }

        int cnt = 0;

        public void CitesteDate()
        {
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            string line1 = id;
            string[] s;
            string[] a = line1.Split(' ');
            char[] split = { ';' };

            dgwDate.Columns.Add("Nume produs", "Nume produs");
            dgwDate.Columns.Add("kcal", "kcal");
            dgwDate.Columns.Add("pret", "pret");
            dgwDate.Columns.Add("cantitate", "cantitate");

            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            dgwDate.Columns.Add(bt);
            bt.UseColumnTextForButtonValue = true;
            bt.Text = "Elimina";

            bt.HeaderText = "Elimina";


            while((line = sr.ReadLine()) != null) 
            { 
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 5; i < s.Length; ++i)
                {     
                    for (int j = 1; j < a.Length; ++j)
                    {
                        if ((j - 1) % 2 == 0 && s[0].ToString() == a[j - 1].ToString())
                        {
                            dgwDate.Rows.Add(s[i - 4].ToString(), s[i - 1].ToString(), s[i - 2].ToString(), a[j].ToString());
                        }
                    }
                }

            }

            for (int i = 1; i < a.Length; ++i)
            {
                InsertIntoSubcomenzi(cnt.ToString(), Int32.Parse(a[i - 1].ToString()), Int32.Parse(a[i].ToString()));
                i++;
            }

        }

        private void Vizualizare_comanda_Load(object sender, EventArgs e)
        {
            cnt++;
            CitesteDate();
            InsertIntoComenzi(id1, dt);
        }

        int kcal;
        int pret;
        int cant;

        private void dgwDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwDate = (DataGridView)sender;

            if (dgwDate.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                kcal = Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["kcal"].Value.ToString());
                pret = Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["pret"].Value.ToString());
                cant = Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["cantitate"].Value.ToString());

                total1 -= kcal * cant;
                pret1 -= pret * cant;

                txtKcal.Text = total1.ToString();
                txtPret.Text = pret1.ToString();  
                
                dgwDate.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoodFoodStart gfs = new GoodFoodStart();
            gfs.ShowDialog();
            this.Close();
        }

        int id_client = 0;

        public int SelectIdClient(string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT id_client FROM Clienti WHERE email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataReader r = cmd.ExecuteReader();

            while(r.Read())
            {
                id_client = Convert.ToInt32(r["id_client"].ToString());
            }

            return id_client;
        }

        public void InsertIntoComenzi(int id_client, DateTime dt)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Comenzi(id_client, data_comanda) VALUES (@id_client, @data)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id_client", id_client);
            cmd.Parameters.AddWithValue("@data", dt);

            cmd.ExecuteNonQuery();
            
            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public void InsertIntoSubcomenzi(string id_comanda, int id_produs, int cantitate)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Subcomenzi(id_comanda, id_produs, cantitate) VALUES (@id_comanda, @id_produs, @cantitate)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_comanda", id_comanda);
            cmd.Parameters.AddWithValue("@id_produs", id_produs);
            cmd.Parameters.AddWithValue("@cantitate", cantitate);

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }
    }
}
