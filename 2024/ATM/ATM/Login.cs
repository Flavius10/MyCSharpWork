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

namespace ATM
{
    public partial class ATM : Form
    {

        private string numberOfCard;
        private string clientName;
        private string DataBaseConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|UsersDataBase.mdf;Integrated Security=True";
        private bool ok_name = false;
        private bool ok_number = false;
        private string date = "GOL";

        public ATM()
        {
            InitializeComponent();
            numberOfCard = txtCardNumber.Text;
            clientName = txtClientName.Text;
        }

        public string ClientName()
        {
            return clientName;
        }

        private void SecureLogin(string numberCard, string clientName)
        {
            SqlConnection conn = new SqlConnection(DataBaseConnection);
            conn.Open();

            string query = "SELECT * FROM Users WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", clientName);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].ToString() == clientName)
                    ok_name = true;
                if (dr[2].ToString() == numberCard)
                    ok_number = true;
            }

            dr.Close();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void OpenPin()
        {
            if (ok_number && ok_name)
            {
                PIN pin = new PIN();
                this.Hide();
                pin.ShowDialog();
                this.Close();
            }
            else if (!ok_name)
            {
                MessageBox.Show("Numele nu se afla in baza de date!", "Nume gresit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClientName.Clear();
            }
            else if (!ok_number)
            {
                MessageBox.Show("Numarul cardului este gresit", "Nr card gresit!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardNumber.Clear();
            }
            else
            {
                MessageBox.Show("Numele si numarul cardului sunt gresite!", "Nume si nr card gresite",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClientName.Clear();
                txtCardNumber.Clear();
            }
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            numberOfCard = txtCardNumber.Text;
            clientName = txtClientName.Text;
            SecureLogin(numberOfCard, clientName);
            OpenPin();

            
        }
    }
}
