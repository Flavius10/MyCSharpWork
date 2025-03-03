using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOOD_FOOD
{
    public partial class Optiuni : Form
    {
        private int varsta;
        private int inaltime;
        private int greutate;
        private int suma = 0;
        private string email = ""; 
        private string path = Directory.GetCurrentDirectory();
        private string filePath = "";
        int buget = 0;

        public Optiuni(string email)
        {
            InitializeComponent();
            this.email = email;   
            filePath = Path.Combine(path, "meniu.txt");
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GOOD_FOOD.mdf;Integrated Security=True";


        public void UpdateDate(int kcal, string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "UPDATE Clienti SET kcal_zilnice = @kcal WHERE email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kcal", kcal);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        private void SelectAll()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Clienti";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            //dataGridView1.DataSource = dt;
            dr.Close();
            conn.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        public void Suma()
        {
            suma = 0;
            varsta = Int32.Parse(txtVarsta.Text);
            inaltime = Int32.Parse(txtInaltime.Text);
            greutate = Int32.Parse(txtGreutate.Text);

            suma += varsta;
            suma += inaltime;
            suma += greutate;
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            Suma();

            if (suma < 250)
            {
                txtNecesar.Text = "1800";
                UpdateDate(Int32.Parse(txtNecesar.Text), email);
            }

            if (250 <= suma && suma <= 275)
            {
                txtNecesar.Text = "2200";
                UpdateDate(Int32.Parse(txtNecesar.Text), email);
            }
                

            if (suma > 275)
            {
                txtNecesar.Text = "2500";
                UpdateDate(Int32.Parse(txtNecesar.Text), email);
            }
            
            txtNecesar1.Text = txtNecesar.Text;
            txtNecesarMeniu.Text = txtNecesar.Text;
            //SelectAll();
        }

        //cerinta 6
        int j = 1;

        public void CitesteMeniu()
        {
            dgwDate.Columns.Clear();
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            string[] s;
            char[] split = { ';' };

            dgwDate.Columns.Add("id_produs", "id_produs");
            dgwDate.Columns.Add("denumire_produs", "denumire_produs");
            dgwDate.Columns.Add("descriere", "descriere");
            dgwDate.Columns.Add("pret", "pret");
            dgwDate.Columns.Add("kcal", "kcal");
            dgwDate.Columns.Add("felul", "felul");
            dgwDate.Columns.Add("Cantitate", "Cantitate");

            dgwDate.Columns["Cantitate"].ReadOnly = false;
            dgwDate.Columns["id_produs"].ReadOnly = true;
            dgwDate.Columns["denumire_produs"].ReadOnly = true;
            dgwDate.Columns["descriere"].ReadOnly = true;
            dgwDate.Columns["pret"].ReadOnly = true;
            dgwDate.Columns["felul"].ReadOnly = true;
            dgwDate.Columns["kcal"].ReadOnly = true;

            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.UseColumnTextForButtonValue = true;
            bt.Text = "Adauga";
            dgwDate.Columns.Add(bt);

            bt.HeaderText = "Adauga";

            while ((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 5; i < s.Length; i++) 
                {
                    dgwDate.Rows.Add(s[i - 5].ToString(), s[i - 4].ToString(), s[i - 3].ToString(), s[i - 2].ToString(), s[i - 1].ToString(), s[i].ToString().Length, 1);
                }

                j++;
            }
        }

        private void Optiuni_Load(object sender, EventArgs e)
        {
            CitesteMeniu();
        }

        int total_kcal = 0;
        int cant = 0;
        int kcal = 0;
        int pret_total = 0;
        int pret = 0;
        string id = "";

        private void dgwDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwDate = (DataGridView) sender;

            if (dgwDate.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["Cantitate"].Value.ToString()) < 0)
                {
                    MessageBox.Show("Cantitate negativa");
                    dgwDate.Rows[e.RowIndex].Cells["Cantitate"].Value = 1;
                }

                id += dgwDate.Rows[e.RowIndex].Cells["id_produs"].Value.ToString() + ' ' + dgwDate.Rows[e.RowIndex].Cells["cantitate"].Value.ToString() + ' ';
                chart1.Series["Comanda"].Points.AddXY(dgwDate.Rows[e.RowIndex].Cells["denumire_produs"].Value.ToString(), dgwDate.Rows[e.RowIndex].Cells["kcal"].Value.ToString());

                cant = Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["Cantitate"].Value.ToString());
                kcal = Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["kcal"].Value.ToString());
                pret = Int32.Parse(dgwDate.Rows[e.RowIndex].Cells["pret"].Value.ToString());

                total_kcal += cant * kcal;
                pret_total += pret * cant;
                
                txtPret.Text = pret_total.ToString();
                txtKcal.Text = total_kcal.ToString();

            }
        }


        private void btnComanda_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            this.Hide();
            Vizualizare_comanda vc = new Vizualizare_comanda(txtNecesar1.Text, txtKcal.Text, txtPret.Text, id, email, dt);
            vc.ShowDialog();
            this.Close();
        }

        private void txtBuget_TextChanged(object sender, EventArgs e)
        {
            buget = Int32.Parse(txtBuget.Text);
            sum = buget;
        }

        //cerinta 8
            string felul1 = "";
            string felul2 = "";
            string felul3 = "";

        public void GenerareMeniu()
        {
            dgwGenerare.Columns.Clear();
            StreamReader sr = new StreamReader(filePath);

            string line = "";
            string[] s;
            char[] split = { ';' };


            dgwGenerare.Columns.Add("Felul 1", "Felul 1");
            dgwGenerare.Columns.Add("Felul 2", "Felul 2");
            dgwGenerare.Columns.Add("Felul 3", "Felul 3");
            dgwGenerare.Columns.Add("Total Kcal", "Total Kcal");
            dgwGenerare.Columns.Add("Pret total", "Pret total");                 
   
            DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
            bt.UseColumnTextForButtonValue = true;
            bt.Text = "Alege";
            
            dgwGenerare.Columns.Add(bt);
            bt.HeaderText = "Alege";
            

            while((line =  sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 0; i < s.Length; ++i)
                {    
                    if (Int32.Parse(s[0].ToString()) <= 5)
                    {
                        felul1 += s[1].ToString() + ';' + s[3].ToString() + ';' + s[4].ToString() + ';';
                        break;
                    }

                    if (Int32.Parse(s[0].ToString()) > 5 &&Int32.Parse(s[0].ToString()) <= 21)
                    {
                        felul2 += s[1].ToString() + ';' + s[3].ToString() + ';' + s[4].ToString() + ';';
                        break;
                    }

                    if (Int32.Parse(s[0].ToString()) == 27 || Int32.Parse(s[0].ToString()) == 26)
                    {
                        felul2 += s[1].ToString() + ';' + s[3].ToString() + ';' + s[4].ToString() + ';';
                        break;
                    }

                    if (Int32.Parse(s[0].ToString()) > 21 && Int32.Parse(s[0].ToString()) <= 25)
                    {
                        felul3 += s[1].ToString() + ';' + s[3].ToString() + ';' + s[4].ToString() + ';';
                        break;
                    }
                }
            }
        }

        int sum = 0;
        int total_kal = 0;
        int pret_total1 = 0;
        int suma_buget = 0;
        int pret_fel1 = 0;
        int pret_fel2 = 0;
        int pret_fel3 = 0;
        int total_kcal1 = 0;
        int kcal_fel1 = 0;
        int kcal_fel2 = 0;
        int kcal_fel3 = 0;

        public void GenerareMeniu1()
        {
            suma_buget = 0;
            string[] felul11;
            string[] felul22;
            string[] felul33;

            felul33 = felul3.Split(';');
            felul22 = felul2.Split(';');
            felul11 = felul1.Split(';');

            dgwDate.Rows.Add(felul11[0].ToString(), felul11[1].ToString(), felul11[2].ToString());


            for (int i = 2; i < felul11.Length; i++)
            {
                pret_fel1 = Int32.Parse(felul11[i - 1].ToString());
                kcal_fel1 = Int32.Parse(felul11[i].ToString());

                for (int j = 2; j < felul22.Length; j++)
                {
                    pret_fel2 = Int32.Parse(felul22[j - 1].ToString());
                    kcal_fel2 = Int32.Parse(felul22[i].ToString());

                    for (int k = 2; k < felul33.Length; k++)
                    {
                        pret_fel3 = Int32.Parse(felul33[k - 1].ToString());
                        kcal_fel3 = Int32.Parse(felul33[k].ToString());

                       if (pret_fel1 + pret_fel2 + pret_fel3 <= buget)
                       {
                            suma_buget = pret_fel1 + pret_fel2 + pret_fel3;
                            total_kcal1 = kcal_fel1 + kcal_fel2 + kcal_fel3;

                            dgwGenerare.Rows.Add(felul11[i - 2].ToString(), felul22[j - 2].ToString(), felul33[k - 2].ToString(), total_kcal1, suma_buget);
                            
                       }
                        k += 2;
                    }
                    j += 2;
                }
                i += 2;
            }

        }

        private void btnGenereaza_Click(object sender, EventArgs e)
        {
            GenerareMeniu();
            GenerareMeniu1();
        }

        private void dgwGenerare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwGenerare = (DataGridView) sender;

            if (dgwGenerare.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show("Comanda trimisa!");
                this.Hide();
                GoodFoodStart gfs = new GoodFoodStart();
                gfs.ShowDialog();
                this.Close();
            }
        }
    }
}
