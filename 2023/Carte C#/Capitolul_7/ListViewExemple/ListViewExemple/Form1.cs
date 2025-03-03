using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            listView1.LargeImageList = imageList2;

            listView1.BeginUpdate();

            listView1.Columns.Add("Carte dezv. pers", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Autor", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Editura", 110, HorizontalAlignment.Left);

            ListViewItem it1 = new ListViewItem();

            it1.ImageIndex = 0;

            it1.Text = "Rezolva ACUM";

            it1.SubItems.Add("Brian Tracy");
            it1.SubItems.Add("Curtea Veche");

            listView1.Items.Add(it1);

            ListViewItem it2 = new ListViewItem();

            it2.ImageIndex = 1;
            it2.Text = "de la idee la bani";
            it2.SubItems.Add("napoleon hill");
            it2.SubItems.Add("Curtea Veche");

            listView1.Items.Add(it2);


            listView1.EndUpdate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

            checkBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
            checkBox1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            checkBox1.Enabled = false;  
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
            checkBox1.Enabled = false;  
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            checkBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listView1.GridLines = true;
            }
            else
            {
                listView1.GridLines = false;
            }
        }
    }
}
