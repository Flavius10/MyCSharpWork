using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private XmlDocument d = null;
        private XmlNodeList elevi = null;

        private void button1_Click(object sender, EventArgs e)
        {
            d = new XmlDocument();
            d.Load("Elevi.xml");

            elevi = d.SelectNodes("absolventi/elev");

            for (int i = 0; i < elevi.Count; i++)
            {
                XmlNode elev = elevi.Item(i).SelectSingleNode("nume");

                listBox1.Items.Add(elev.InnerText);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;


            elevi = d.SelectNodes("absolventi/elev");

            XmlNode scoala = elevi.Item(index).SelectSingleNode("scoala");
            textBox1.Text = scoala.InnerText;

            XmlNode clasa = elevi.Item(index).SelectSingleNode("clasa");
            textBox2.Text = clasa.InnerText;

            XmlNode profil = elevi.Item(index).SelectSingleNode("profil");
            textBox3.Text = profil.InnerText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
