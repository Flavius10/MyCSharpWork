using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            users.Add(new User("Gigi", "gigi@gmail.com", "gigi", 10000));
            users.Add(new User("Gigi", "gigi@gmail.com", "gigi", 10000));
            users.Add(new User("Gigi", "gigi@gmail.com", "gigi", 10000));
            users.Add(new User("Gigi", "gigi@gmail.com", "gigi", 10000));
            users.Add(new User("Flavius", "flaviusa1010@gmail.com", "Flavius", 100000));

            InitializeComponent();

            dataGridView1.DataSource = users;
            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Salary";
            label1.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
