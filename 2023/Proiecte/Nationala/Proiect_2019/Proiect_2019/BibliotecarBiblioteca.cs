using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2019
{
    public partial class BibliotecarBiblioteca : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteca.mdf;Integrated Security=True";
        private string nume;
        private int id;
        private string path = Directory.GetCurrentDirectory();
        private string filePath = "";
        private bool ok_radiobutton = false;
        private bool ok = true;
        private int tip = 0;
        private int id_max = 0;

        public BibliotecarBiblioteca(string email)
        {
            InitializeComponent();
            string email_ut = email;
            AflaDate(email_ut);
            lblNume.Text = "Bibliotecar = " + nume;
            string dt = DateTime.Now.ToString();
            lblDate.Text = dt;

            filePath = Path.Combine(path, @"ONTI_C#_2019_resurse\Imagini\utilizatori\" + id.ToString() + ".jpg");
            pbPoza.Image = Image.FromFile(filePath);    
            pbPoza.SizeMode = PictureBoxSizeMode.StretchImage;

            tabPage3.Enabled = false;
            btnInregistreaza.Enabled = false;
        }


        //Inregistreaza utilizator
        private void AflaDate(string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT IdUtilizator, NumePrenume FROM Utilizatori WHERE Email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Int32.Parse(dr[0].ToString());
                nume = dr[1].ToString();
            }

            dr.Close();

            string query1 = "SELECT IdUtilizator FROM Utilizatori";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while(dr1.Read())
            {
                id_max = Int32.Parse(dr1[0].ToString());
            }

            cmd.Dispose();
            con.Close();
        }

        private void btnIncarca_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPG(*.jpg) | *.jpg";
            openFileDialog.InitialDirectory = @"|DataDirectory|\ONTI_C#_2019_resurse\Imagini\altele";
            openFileDialog.Title = "Alege imagine";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPozaCont.Image = Image.FromFile(openFileDialog.FileName);
                pbPozaCont.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rbCit_CheckedChanged(object sender, EventArgs e)
        {
            ok_radiobutton = false;
            if (rbCit.Checked)
            {
                txtParola.Enabled = false;
                txtResetare.Enabled = false;
                ok_radiobutton = true;
            }

            bool ok1 = Inregistrare();
            if (ok1 == true)
                btnInregistreaza.Enabled = true;
            tip = 2;
        }

        private void rbBib_CheckedChanged(object sender, EventArgs e)
        {
            ok_radiobutton = false;
            if ( rbBib.Checked)
            {
                txtParola.Enabled = true;
                txtResetare.Enabled = true;
                ok_radiobutton = true;
            }

            bool ok1 = Inregistrare();
            if (ok1 == true)
                btnInregistreaza.Enabled = true;

            tip = 1;
        }

        private bool ValidateEmail(string email)
        {
            string trimmedemail = email.Trim();

            if (trimmedemail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var adress = new MailAddress(email);
                return trimmedemail == adress.Address;
            }
            catch
            {
                return false;
            }
        }

        private bool NumePrenume()
        {
            if (txtNume.Text == string.Empty)
                return false;
            else
                return true;
        }

        private bool RescrieParola()
        {
            if (txtResetare.Text == txtParola.Text)
                return true;
            else
                return false;
        }

        private bool Parola()
        {
            if (txtParola.Text == string.Empty)
                return false;
            else
                return true;
        }

        private bool Inregistrare()
        {
            ok = true;
            if (!ValidateEmail(txtEmail.Text))
                ok = false;
            if (!ok_radiobutton)
                ok = false;
            if (!Parola())
                ok = false;
            if (!RescrieParola())
                ok = false;
            if (!NumePrenume())
                ok = false;

            return ok;
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            bool ok1 = Inregistrare();
            if (ok1 == true)
                btnInregistreaza.Enabled = true;
            else
                btnInregistreaza.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool ok1 = Inregistrare();
            if (ok1 == true)
                btnInregistreaza.Enabled = true;
            else
                btnInregistreaza.Enabled = false;
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            bool ok1 = Inregistrare();
            if (ok1 == true)
                btnInregistreaza.Enabled = true;
            else
                btnInregistreaza.Enabled = false;
        }

        private void txtResetare_TextChanged(object sender, EventArgs e)
        {
            bool ok1 = Inregistrare();
            if (ok1 == true)
                btnInregistreaza.Enabled = true;
            else
                btnInregistreaza.Enabled = false;
        }

        private void InsertIntoBibliotecar(int tip, string nume, string email, string parola)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(TipUtilizator, NumePrenume, Email, Parola) VALUES (@tip, @nume, @email, @parola)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tip", tip);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@parola", parola);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private void InsertIntoCititor(int tip, string nume, string email)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "INSERT INTO Utilizatori(TipUtilizator, NumePrenume, Email) VALUES (@tip, @nume, @email)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tip", tip);
            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        private string ParolaCriptata(string parola_curenta)
        {
            string parola_criptata = "";
            char cod;

            foreach (char car in parola_curenta)
            {
                cod = car;

                if (Char.IsDigit(car))
                {
                    cod = (char)('9' - car + '0');
                }

                if (Char.IsLetter(car))
                {
                    if (Char.IsLower(car))
                    {
                        cod = (char)(car + 1);

                        if (car == 'z')
                            cod = 'a';
                    }
                    else
                    {
                        cod = (char)(car - 1);

                        if (car == 'A')
                            cod = 'Z';
                    }
                }

                parola_criptata += cod;
            }

            return parola_criptata;
        }

        private void btnInregistreaza_Click(object sender, EventArgs e)
        {
            if (tip == 1)
                InsertIntoBibliotecar(1, txtNume.Text, txtEmail.Text, ParolaCriptata(txtParola.Text));
            else
                InsertIntoCititor(2, txtNume.Text, txtEmail.Text);


             SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Images(*.jpg) | *.jpg";
            ImageFormat format = ImageFormat.Jpeg;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPozaCont.Image.Save(saveFileDialog.FileName, format);
            }


            txtEmail.Text = string.Empty;
            txtParola.Text = string.Empty;
            txtNume.Text = string.Empty;
            txtResetare.Text = string.Empty;

            rbBib.Checked = false;
            rbCit.Checked = false;

            pbPozaCont.Image = null;

            CitesteDate();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgwCititor.Columns.Add(btn);
            btn.HeaderText = "Afiseaza";

            btn.UseColumnTextForButtonValue = true;
            btn.Text = "Afiseaza";

        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtParola.Text = string.Empty;
            txtNume.Text = string.Empty;
            txtResetare.Text = string.Empty;

            rbBib.Checked = false;
            rbCit.Checked = false;

            pbPozaCont.Image = null;
        }


        //Afisare Cititor

        private void CitesteDate()
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT IdUtilizator, NumePrenume, Email FROM Utilizatori";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader(); 

            DataTable dataTable = new DataTable();

            dataTable.Load(dr);
            dgwCititor.DataSource = dataTable;

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        private void dgwCititor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwCititori = (DataGridView)sender;

            if (dgwCititori.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                tabPage3.Focus();
                tabPage3.Enabled = true;
                nume_utilizator = dgwCititori.CurrentRow.Cells["NumePrenume"].Value.ToString();
                id_cititor = Int32.Parse(dgwCititori.CurrentRow.Cells["IdUtilizator"].Value.ToString());
                SelecteazaCarti(id_cititor);
                pbCititor.SizeMode = PictureBoxSizeMode.StretchImage;
                pbCititor.Image = Image.FromFile(@"ONTI_C#_2019_resurse\Imagini\utilizatori\" + id_cititor.ToString() + ".jpg");
                label2.Text = "IdCititor: " + id_cititor.ToString() + ", Nume si prenume = " + ' ' + nume_utilizator.ToString();


                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dgwImprumuturi.Columns.Add(btn);
                btn.HeaderText = "Restituie";

                btn.UseColumnTextForButtonValue = true;
                btn.Text = "Restituie";
            }
        }

        string nume1;
        string nume_utilizator;
        int id_cititor;
        private void button1_Click(object sender, EventArgs e)
        {
            nume1 = txtNumePrenume.Text;
            SelectCititor(nume1);
        }

        private void SelectCititor(string text)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT IdUtilizator, NumePrenume, Email FROM Utilizatori WHERE NumePrenume LIKE @text + '%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@text", text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();

            dataTable.Load(dr);
            dgwCititor.DataSource = dataTable;

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }

        // cerinta 7

        private void SelecteazaCarti(int id)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT IdImprumut, IdCarte, DataImprumut, DataRestituire FROM Imprumuturi WHERE IdCititor = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();

            dataTable.Load(dr);
            dgwImprumuturi.DataSource = dataTable;

            dr.Close();
            cmd.Dispose();
            con.Dispose();
            con.Close();
        }
    }
}
