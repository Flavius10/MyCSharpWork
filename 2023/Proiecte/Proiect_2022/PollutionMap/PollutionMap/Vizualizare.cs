using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PollutionMap
{
    

    public partial class Vizualizare : Form
    {
        public Vizualizare()
        {
            InitializeComponent();

            cmbFiltru.Items.Add("Niciun filtru");
            cmbFiltru.Items.Add("Valoarea < 20");
            cmbFiltru.Items.Add("20 <= Valoarea <= 40");   
            cmbFiltru.Items.Add("Valoarea > 40");

        }


        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Poluare.mdf;Integrated Security=True";
        private string nume_harta = "";
        
        private string SelectAll(int id)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT NumeHarta FROM Harti WHERE IdHarta = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                nume_harta = dr[0].ToString();
            }

            return nume_harta;
        }
        

        private void Vizualizare_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; ++i)
            {
                cmbHarta.Items.Add(SelectAll(i));
            }
            pbHarti.Invalidate();
            
        }


        //Selecteaza Imagini de harti dupa comboBox.Items
        private string path = "";

        public string SelecteazaFisier(string nume)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT FisierHarta FROM Harti WHERE NumeHarta = @nume";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nume", nume);

            SqlDataReader dr = cmd.ExecuteReader(); 

            while(dr.Read())
            {
                path = dr[0].ToString();
            }

            return path;    
        }

        public string path_poza = "";
        public string path_curent = Directory.GetCurrentDirectory();
        public string filePath = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            path_poza += @"Harti\" + SelecteazaFisier(cmbHarta.Text);

            filePath = Path.Combine(path_curent, path_poza);
            pbHarti.ImageLocation = filePath;
            pbHartiTraseu.ImageLocation = filePath;
            filePath = "";
            path_poza = "";
        }


        //cerinta 5

        private string date_cerc = "";

        public string SalveazaDate(int id, DateTime data)
        {
            SqlConnection con = new SqlConnection(connStr); 
            con.Open();

            string query = "SELECT PozitieX, PozitieY, ValoareMasurare, DataMasurare FROM Masurare WHERE IdHarta = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DateTime data_d = DateTime.Parse(dr[3].ToString());


                if (data_d.Year == data.Year && data_d.Month == data.Month && data_d.Day == data.Day) 
                {
                    date_cerc += dr[0].ToString() + ' ' + dr[1].ToString() + ' ' + dr[2].ToString() + ' ';
                }
                
            }

            return date_cerc;
        }

        private string[] data_cerc;
        bool ok_niciunFiltru = false;
        bool ok_Filtru20 = false;
        bool ok_Filtru2040 = false;
        bool ok_Filtru40 = false;
        
        DateTime dt;


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {   
            dt = dateTimePicker1.Value;
            pbHarti.Invalidate();
        } 
        
        private void btnFiltrare_Click(object sender, EventArgs e)
        {
            if (cmbFiltru.Text == "Niciun filtru")
            {
                pbHarti.Invalidate();
                ok_Filtru20 = false;
                ok_Filtru2040 = false;
                ok_Filtru40 = false;

                ok_niciunFiltru = true;
               
            }

            if (cmbFiltru.Text == "Valoarea < 20")
            {
                pbHarti.Invalidate();
                ok_Filtru2040 = false;
                ok_Filtru40 = false;
                ok_niciunFiltru = false;

                ok_Filtru20 = true;
            }

            if (cmbFiltru.Text == "20 <= Valoarea <= 40")
            {
                pbHarti.Invalidate();
                ok_Filtru20 = false;
                ok_Filtru40 = false;
                ok_niciunFiltru = false;

                ok_Filtru2040 = true;
            }

            if (cmbFiltru.Text == "Valoarea > 40")
            {
                pbHarti.Invalidate();
                ok_Filtru20 = false;
                ok_Filtru2040 = false;
                ok_niciunFiltru = false;

                ok_Filtru40 = true;
            }
        }

        private void pbHarti_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.Blue);
            Brush brush = new SolidBrush(Color.Blue);


            if (cmbHarta.Text == "Harta Bucuresti")
                SalveazaDate(1, dt);
            if (cmbHarta.Text == "Harta Cluj-Napoca")
                SalveazaDate(2, dt);
            if (cmbHarta.Text == "Harta Constanta")
                SalveazaDate(3, dt);
            if (cmbHarta.Text == "Harta Iasi")
                SalveazaDate(4, dt);
            if (cmbHarta.Text == "Harta Sibiu")
                SalveazaDate(5, dt);

            data_cerc = date_cerc.Split(' ');


            if (ok_niciunFiltru == true)
            {
                int j = 2;

                for (int i = 1; i < data_cerc.Length; i++)
                {
                    if (Int32.Parse(data_cerc[j].ToString()) < 20)
                    {
                        p = new Pen(Color.Green);
                        brush = new SolidBrush(Color.Green);
                    }

                    if (Int32.Parse(data_cerc[j].ToString()) >= 20 && Int32.Parse(data_cerc[j].ToString()) <= 40)
                    {
                        p = new Pen(Color.Yellow);
                        brush = new SolidBrush(Color.Yellow);
                    }

                    if (Int32.Parse(data_cerc[j].ToString()) > 40)
                    {
                        p = new Pen(Color.Red);
                        brush = new SolidBrush(Color.Red);
                    }

                    e.Graphics.DrawEllipse(p, Int32.Parse(data_cerc[i - 1].ToString()), Int32.Parse(data_cerc[i].ToString()), 20, 20);
                    e.Graphics.DrawString(data_cerc[j].ToString(), this.Font, brush, Int32.Parse(data_cerc[i - 1].ToString()) + 2, Int32.Parse(data_cerc[i].ToString()) + 3);

                    i += 2;
                    j += 3;
                }
            }

            if (ok_Filtru20 == true)
            {

                for (int j = 2; j < data_cerc.Length; j += 3)
                {
                    if (Int32.Parse(data_cerc[j].ToString()) < 20)
                    {
                        p = new Pen(Color.Green);
                        brush = new SolidBrush(Color.Green);

                        e.Graphics.DrawEllipse(p, Int32.Parse(data_cerc[j - 2].ToString()), Int32.Parse(data_cerc[j - 1].ToString()), 20, 20);
                        e.Graphics.DrawString(data_cerc[j].ToString(), this.Font, brush, Int32.Parse(data_cerc[j - 2].ToString()) + 2, Int32.Parse(data_cerc[j - 1].ToString()) + 3);

                    }
                }
            }

            if (ok_Filtru2040 == true)
            {
                for (int j = 2; j < data_cerc.Length; j += 3)
                {
                    if (Int32.Parse(data_cerc[j].ToString()) >= 20 && Int32.Parse(data_cerc[j].ToString()) <= 40)
                    {
                        p = new Pen(Color.Yellow);
                        brush = new SolidBrush(Color.Yellow);

                        e.Graphics.DrawEllipse(p, Int32.Parse(data_cerc[j - 2].ToString()), Int32.Parse(data_cerc[j - 1].ToString()), 20, 20);
                        e.Graphics.DrawString(data_cerc[j].ToString(), this.Font, brush, Int32.Parse(data_cerc[j - 2].ToString()) + 2, Int32.Parse(data_cerc[j - 1].ToString()) + 3);

                    }
                }
            }

            if (ok_Filtru40 ==  true)
            {
                for (int j = 2; j < data_cerc.Length; j += 3)
                {
                    if (Int32.Parse(data_cerc[j].ToString()) > 40)
                    {
                        p = new Pen(Color.Red);
                        brush = new SolidBrush(Color.Red);

                        e.Graphics.DrawEllipse(p, Int32.Parse(data_cerc[j - 2].ToString()), Int32.Parse(data_cerc[j - 1].ToString()), 20, 20);
                        e.Graphics.DrawString(data_cerc[j].ToString(), this.Font, brush, Int32.Parse(data_cerc[j - 2].ToString()) + 2, Int32.Parse(data_cerc[j - 1].ToString()) + 3);

                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbHarti.Invalidate();
            cmbFiltru.SelectedItem = "Niciun filtru";
            ok_niciunFiltru = true;

            ok_Filtru20 = false;
            ok_Filtru2040 = false;
            ok_Filtru40 = false;

        }
        bool ok_punct = false;
        int x;
        int y;
        int id_harta = 0;

        private void pbHarti_MouseClick(object sender, MouseEventArgs e)
        {
            ok_punct = false;

            x = e.X;
            y = e.Y;

            for (int i = 1; i < data_cerc.Length; i++)
            {
                if (x == Int32.Parse(data_cerc[i - 1]) && y == Int32.Parse(data_cerc[i]))
                {
                    ok_punct = true;
                }
                i++;
            }


            if (cmbHarta.Text == "Harta Bucuresti")
                id_harta = 1;
            if (cmbHarta.Text == "Harta Cluj-Napoca")
                id_harta = 2;
            if (cmbHarta.Text == "Harta Constanta")
                id_harta = 3;
            if (cmbHarta.Text == "Harta Iasi")
                id_harta = 4;
            if (cmbHarta.Text == "Harta Sibiu")
                id_harta = 5;



            if (ok_punct == false)
            {
                this.Hide();
                AdaugaMasurare a = new AdaugaMasurare( id_harta,x, y, dateTimePicker1.Value);
                a.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Acest punct este deja ales'\nVa rugam alegeti alt punct");
        } 

        int x1 = 0, y1 = 0;
        int x2 = 0, y2 = 0; 

        private void pbHartiTraseu_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Pen pen = new Pen(Color.Red);
            Graphics g =  pbHartiTraseu.CreateGraphics();

            for (int j = 2; j < data_cerc.Length; j += 3) 
            {
                if (Int32.Parse(data_cerc[j]) > maxi)
                {
                    maxi = Int32.Parse(data_cerc[j]);
                    m = j;
                    x1 = Int32.Parse(data_cerc[j - 2]);
                    y1 = Int32.Parse(data_cerc[j - 1]);
                }
            }

            for (int j = 2; j < data_cerc.Length; j += 3)
            {
                if (Int32.Parse(data_cerc[j]) > maxi2 && Int32.Parse(data_cerc[j]) < maxi)
                {
                    maxi2 = Int32.Parse(data_cerc[j]);
                    m2 = j;
                    x2 = Int32.Parse(data_cerc[j - 2]);
                    y2 = Int32.Parse(data_cerc[j - 1]);
                }
            }


            for (int i = 1; i < data_cerc.Length; ++i)
            {

                if ((e.X - Int32.Parse(data_cerc[i - 1].ToString()) <= 15) && (e.Y - Int32.Parse(data_cerc[i].ToString()) <= 15))
                {
                    g.DrawLine(pen, Int32.Parse(data_cerc[i - 1].ToString()), Int32.Parse(data_cerc[i].ToString()), x2, y2);
                    break;
                }

                i += 2;
            }

            //richTextBox1.Text += x_data.ToString() + ' ' + y_data.ToString();

            MessageBox.Show("x = " + x + " y = " + y);
            
            g.DrawLine(pen, x1, y1, x2, y2); 
        }


        private void pbHartiTraseu_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            Pen p = new Pen(Color.Blue);
            Brush brush = new SolidBrush(Color.Blue);

            int j = 2;

            for (int i = 1; i < data_cerc.Length; i++)
            {
                if (Int32.Parse(data_cerc[j].ToString()) < 20)
                {
                    p = new Pen(Color.Green);
                    brush = new SolidBrush(Color.Green);
                }

                if (Int32.Parse(data_cerc[j].ToString()) >= 20 && Int32.Parse(data_cerc[j].ToString()) <= 40)
                {
                    p = new Pen(Color.Yellow);
                    brush = new SolidBrush(Color.Yellow);
                }

                if (Int32.Parse(data_cerc[j].ToString()) > 40)
                {
                    p = new Pen(Color.Red);
                    brush = new SolidBrush(Color.Red);
                }

                e.Graphics.DrawEllipse(p, Int32.Parse(data_cerc[i - 1].ToString()), Int32.Parse(data_cerc[i].ToString()), 20, 20);
                e.Graphics.DrawString(data_cerc[j].ToString(), this.Font, brush, Int32.Parse(data_cerc[i - 1].ToString()) + 2, Int32.Parse(data_cerc[i].ToString()) + 3);

                i += 2;
                j += 3;
            }

            
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int maxi = 0;
        int maxi2 = 0;
        int m, m2 = 0;


    }
}
