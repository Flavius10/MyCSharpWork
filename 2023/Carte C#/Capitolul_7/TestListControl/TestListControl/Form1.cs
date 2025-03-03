using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Elev[] el;

        class Elev
        {
            public string nume;
            public Elev(string nume)
            {
                this.nume = nume;
            }

            public string Nume
            {
                get { return nume; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] copii = {"Ionel", "Viorel", "Alinel", "Dorel"};

            checkedListBox1.DataSource = copii;
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Nume";

            listBox1.Items.AddRange(new object[] {"UNU", "DOI", "TREI", new Elev("Nelutu")});
        }

        private void comboButton_Click(object sender, EventArgs e)
        {
            comboBox1.BeginUpdate();

            for (int i = 0; i < 20; ++i)
                comboBox1.Items.Add("Itemul" + i);
            comboBox1.EndUpdate();
        }

        private void checkListButton1_Click(object sender, EventArgs e)
        {
            string[] copii = { "Ionel", "Viorel", "Alinel", "Dorel" };

            checkedListBox1.DataSource = copii;
        }

        private void checkListButton2_Click(object sender, EventArgs e)
        {
            el = new Elev[] { new Elev("Marius"),
                             new Elev("Lenuta")};

            checkedListBox1.DataSource = el;

            checkedListBox1.DisplayMember = "Nume";
        }
    }
}
