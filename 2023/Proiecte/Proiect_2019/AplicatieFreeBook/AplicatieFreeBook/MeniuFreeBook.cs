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
using System.Windows.Forms.DataVisualization.Charting;

namespace AplicatieFreeBook
{
    public partial class MeniuFreeBook : Form
    {
        public string email = "";

        public MeniuFreeBook(string email)
        {
            InitializeComponent();
            this.email = email;

            lblEmail.Text = email;

            Imprumut(lblEmail.Text);

            comboBox1.Items.Add("2017");
            comboBox1.Items.Add("2018");
            comboBox1.Items.Add("2019");
            comboBox1.Items.Add("2023");

        }

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FreeBook.mdf;Integrated Security=True";

        public void SelectAll()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM carti";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            dgwCarti.Columns.Add("IdCarte", "IdCarte");
            dgwCarti.Columns.Add("Titlu", "Titlu");
            dgwCarti.Columns.Add("Autor", "Autor");
            dgwCarti.Columns.Add("Gen", "Gen");

            while(dr.Read())
            {
                if (nume_carti.Contains(dr[0].ToString()) == false)
                {
                    dgwCarti.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        public void SelectAllI()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM imprumut";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            //dataGridView1.DataSource = dt;

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        List<string> nume_carti = new List<string>();   

        public void Imprumut(string nume)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT id_carte FROM imprumut WHERE email = @nume";
            SqlCommand cmd = new SqlCommand (query, con);
            cmd.Parameters.AddWithValue("@nume", nume);
            
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                nume_carti.Add(dr[0].ToString());
            }

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public void InsertDateImprumut(int id, string emaill, string dt)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO imprumut(id_carte, email, data_imprumut) VALUES (@id, @email, @data)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@data", dt);

            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        //ION ion@yahoo.com
        //ION nae@yahoo.com
        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {   
            SelectAll();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgwCarti.Columns.Add(btn);
            btn.HeaderText = "Imprumuta carte";

            btn.UseColumnTextForButtonValue = true;
            SelectAllCarti();
            // SelectAllImprumut();

            Chart();
           
        }
        int cnt = 0;
        bool ok = false;

        private void dgwCarti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwCarti = (DataGridView)sender;

            if (dgwCarti.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (ok == false)
                {
                    InsertDateImprumut(Int32.Parse(dgwCarti.CurrentRow.Cells["IdCarte"].Value.ToString()), lblEmail.Text, DateTime.Now.ToString("dd/MM/yyyy"));
                    ++i;
                    dgwCartiImprumutate.Rows.Add(i, dgwCarti.CurrentRow.Cells["Titlu"].Value.ToString(), dgwCarti.CurrentRow.Cells["Autor"].Value.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.AddDays(30).ToString("dd/MM/yyyy"));
                    k = i;
                    dgwCartiImprumutate.Rows[k - 1].DefaultCellStyle.BackColor = Color.Green;
                    cnt++;

                    pbNrCarti.Increment(33);

                }
                else
                {
                    MessageBox.Show("Nu mai puteti imprumuta carti\nAti atins numarul maxim de imprumuturi(3)");
                }
            }

            if (cnt == 1)
                lblDisponibilitate.Text = "Disponibilitate imprumuturi 1 / 3"; 
            
            if (cnt == 2)
                lblDisponibilitate.Text = "Disponibilitate imprumuturi 2 / 3";

            if (cnt == 3)
            {
                lblDisponibilitate.Text = "Disponibilitate imprumuturi 3 / 3";
                ok = true;
            }
        }

        ///Carti imprumutate 
        
        int i = 0;
        int k = 0;
        int j = 0;

        private void SelectAllCarti()
        {  
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT id_carte, titlu, autor FROM carti";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            dgwCartiImprumutate.Columns.Add("Index", "Index");
            dgwCartiImprumutate.Columns.Add("Titlu", "Titlu");
            dgwCartiImprumutate.Columns.Add("Autor", "Autor");
            dgwCartiImprumutate.Columns.Add("Data imprumut", "Data imprumut");
            dgwCartiImprumutate.Columns.Add("Data disponibilitate", "Data disponibilitate");

            while (dr.Read())
            {   
                if (nume_carti.Contains(dr[0].ToString()) == true)
                {   
                    ++i;
                    dgwCartiImprumutate.Rows.Add(i, dr[1].ToString(), dr[2].ToString());
                }
            }
            dr.Close();

            string query2 = "SELECT data_imprumut FROM imprumut WHERE email = @email";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@email", lblEmail.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                DateTime dt = DateTime.Parse(dr2[0].ToString());
                dt = dt.AddDays(30);
                
                dgwCartiImprumutate.Rows[j].Cells["Data imprumut"].Value = dr2[0];
                dgwCartiImprumutate.Rows[j].Cells["Data disponibilitate"].Value = dt;
                if (DateTime.Now > dt)
                {
                    dgwCartiImprumutate.Rows[j].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgwCartiImprumutate.Rows[j].DefaultCellStyle.BackColor = Color.Green;
                }
                ++j;
            }

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        private void dgwCartiImprumutate_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgwCartiImprumutate.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Red)
            {
                MessageBox.Show("Perioada imprumutului expirata!");
            }
            else
            {
                this.Hide();
                AfiseazaCarte ac = new AfiseazaCarte(dgwCartiImprumutate.Rows[e.RowIndex].Cells["Titlu"].Value.ToString());
                ac.ShowDialog();
                this.Close();
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Cerinta 8

        int[] cnt_imp = new int[13];

        public void SelectDate(string an)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT data_imprumut FROM imprumut";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                if (DateTime.Parse(dr[0].ToString()).Year == Int32.Parse(an)) 
                {
                    cnt_imp[DateTime.Parse(dr[0].ToString()).Month]++;
                }
            }

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        string[] anotimp = {"Ianuarie", "Februarie", "Martie", "Aprilie", "Mai", "Iunie", "Iulie", "August", "Septembrie", "Octombrie","Noiembrie", "Decembrie"};

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ChartImprumut.Series["Luna"].Points.Clear();

            for (int i = 1; i < cnt_imp.Length; i++)
            {
                cnt_imp[i] = 0;
            }

            SelectDate(comboBox1.Text); 

            for (int i = 1; i < cnt_imp.Length; i++)
            {

                string luna = anotimp[i - 1].ToString();
                string nr_imp = cnt_imp[i].ToString();

                ChartImprumut.Series["Luna"].Points.AddXY(luna, nr_imp);
            }
        }

        private string[] nume_carti1 = { "Ciuleandra", "Colt Alb", "Enigma Otiliei", "Idiotul", "Ion", "La tiganci", "Maitreyi", "Romanul adolescentului miop",
        "Patul lui Procust", "Anna Karenina", "Casa Buddenbrook", "Rosu si negru", "Marele Gatsb", "La rascruce de vanturi", "Mara", "Romeo si Julieta",
        "Ulita Copilariei", "Micul print", "Poezii", "Hansel si Grethel", "Marele plan", "Teoria Universala", "Cum vad eu lumea","Ascensiunea omului"};

        public void Chart()
        {

            chart1.Titles.Add("Carti imprumutate");

            chart1.Series["CartiImprumut"].IsValueShownAsLabel = true;
            chart1.Series["CartiImprumut"].Points.AddXY("Teoria universala", "7");
            chart1.Series["CartiImprumut"].Points.AddXY("Ion", "6");
            chart1.Series["CartiImprumut"].Points.AddXY("Marele Gatsby", "6");
            chart1.Series["CartiImprumut"].Points.AddXY("Anna Karenina", "5");

            SelectIdFromImprumut();

        }

        int[] id_carte = new int[25];

        public void SelectIdFromImprumut()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT id_carte FROM imprumut";
            SqlCommand cmd = new SqlCommand(query, con);
            
            SqlDataReader dr = cmd.ExecuteReader();  

            while(dr.Read())
            {
                id_carte[Int32.Parse(dr[0].ToString())]++; 
            }

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }
    }
}
