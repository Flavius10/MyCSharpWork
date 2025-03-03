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

namespace Tester
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            unu1.Visible = false;
            doi2.Visible = false;
            trei3.Visible = false;
            patru4.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogare fl = new FormLogare();   
            fl.ShowDialog();
            this.Close();
        }

        public string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Folders\Info\C#\Proiect_2012\Partea I\Tester\Tester\Cerinte.mdf;Integrated Security=True;";
        public int id_cerinta = 1;
        public int punctaj = 0;
        public int numar;
        public int punctaj1 = 0;

        public void Cerinta()
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            

                string query = "SELECT Cerinta, Raspuns1, Raspuns2, Raspuns3, Raspuns4, RaspunsCorect, Punctaj, CR FROM Cerinte WHERE IdCerinta = @idcerinta";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idcerinta", id_cerinta);

                SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int nr = Int32.Parse(dr.GetValue(7).ToString());
                int rsp_corect = Int32.Parse(dr.GetValue(5).ToString());
                punctaj1 = Int32.Parse(dr.GetValue(6).ToString());
                numar = rsp_corect;
                txtCerinta.Text = dr.GetValue(0).ToString();
                if (nr == 0)
                {
                    grpPrimaIntrebare.Visible = false;
                    grpRadio.Visible = true;

                    unu1.Visible = true;
                    doi2.Visible = true;
                    trei3.Visible = true;
                    patru4.Visible = true;

                    unu.Visible = false;
                    doi.Visible = false;
                    trei.Visible = false;
                    patru.Visible = false;

                    unu1.Text = dr.GetValue(1).ToString();
                    doi2.Text = dr.GetValue(2).ToString();
                    trei3.Text = dr.GetValue(3).ToString();
                    patru4.Text = dr.GetValue(4).ToString();
                }
                else if (nr == 1)
                {
                    grpPrimaIntrebare.Visible = true;
                    grpRadio.Visible = false;

                    unu.Visible = true;
                    doi.Visible = false;
                    trei.Visible = false;
                    patru.Visible = false;

                    unu1.Visible = false;
                    doi2.Visible = false;
                    trei3.Visible = false;
                    patru4.Visible = false;

                    unu.Text = dr.GetValue(1).ToString();
                    doi.Text = dr.GetValue(2).ToString();
                    trei.Text = dr.GetValue(3).ToString();
                    patru.Text = dr.GetValue(4).ToString();
                }

            }            

            cmd.Dispose();

            conn.Dispose();
            conn.Close();
            
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            Cerinta();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnValidare.Enabled = true;

            unu.Checked = false;
            doi.Checked = false;
            trei.Checked = false;
            patru.Checked = false;

            unu1.Checked = false;
            doi2.Checked = false;
            trei3.Checked = false;
            patru4.Checked = false;

            id_cerinta++;
            Cerinta();
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            unu.Checked = false;
            doi.Checked = false;
            trei.Checked = false;
            patru.Checked = false;

            unu1.Checked = false;
            doi2.Checked = false;
            trei3.Checked = false;
            patru4.Checked = false;


            id_cerinta--;
            Cerinta();
        }

        private void btnValidare_Click(object sender, EventArgs e)
        {

            if (unu.Checked == true && numar == 1)
            {
                punctaj += punctaj1;
            }
            else if (doi.Checked == true && numar == 2)
            {
                punctaj += punctaj1;
            }
            else if (trei.Checked && numar == 3)
            {
                punctaj += punctaj1;
            }
            else if (patru.Checked && numar == 4)
            {
                punctaj += punctaj1;
            }
            else
                punctaj += 0;




            if (unu1.Checked == true && numar == 1)
            {
                punctaj += punctaj1;
            }
            else if (doi2.Checked == true && numar == 2)
            {
                punctaj += punctaj1;
            }
            else if (trei3.Checked == true && numar == 3)
            {
                punctaj += punctaj1;
            }
            else if (patru4.Checked && numar == 4)
            {
                punctaj += punctaj1;
            }
            else
                punctaj += 0;

            btnValidare.Enabled = false;
        }

        private void btnFinalizareTest_Click(object sender, EventArgs e)
        {
            lblPunctaj.Text = "Ati obtinut " + punctaj.ToString() + " de puncte";
            btnNext.Visible = false;
            btnPrevious.Visible = false;
        
        }
    }
}
