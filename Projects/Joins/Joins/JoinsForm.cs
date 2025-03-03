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

namespace Joins
{
    public partial class JoinsForm : Form
    {

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrdersClientsDB.mdf;Integrated Security=True";
        public JoinsForm()
        {
            InitializeComponent();
            //SelectAllData();
        }

        private void SelectAllData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Orders";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr =  cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable(); 
                        dt.Load(dr);
                        dgwTestJoins.DataSource = dt;
                    }
                }
            }
        }

        private void InnerJoin()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT c.CustomerID,o.OrderID, c.CustomerName " +
                    "FROM Orders AS o " +
                    "INNER JOIN Customers AS c ON c.CustomerID = o.CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgwTestJoins.DataSource = dt;
                    }
                }
            }
        }

        private void btnINNER_Click(object sender, EventArgs e)
        {
            InnerJoin();
        }

        private void LeftJoin()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT c.CustomerID, c.CustomerName, o.OrderID, o.OrderDate " +
                    "FROM Orders AS o " +
                    "LEFT JOIN Customers AS c ON c.CustomerID = o.CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgwTestJoins.DataSource = dt;
                    }
                }
            }
        }

        private void btnLEFT_Click(object sender, EventArgs e)
        {
            LeftJoin();
        }

        private void RightJoin()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT c.CustomerID, c.CustomerName, o.OrderID, o.OrderDate " +
                    "FROM Orders AS o " +
                    "RIGHT JOIN Customers AS c " +
                    "ON c.CustomerID = o.CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgwTestJoins.DataSource = dt;
                    }
                }
            }
        }

        private void btnRIGHT_Click(object sender, EventArgs e)
        {
            RightJoin();
        }

        private void FullJoin()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT c.CustomerID, c.CustomerName, o.OrderID, o.OrderDate " +
                    "FROM Orders AS o FULL JOIN Customers AS c " +
                    "ON c.CustomerID = o.CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgwTestJoins.DataSource = dt;
                    }
                }
            }
        }

        private void btnFULLJOIN_Click(object sender, EventArgs e)
        {
            FullJoin();
        }
    }
}
