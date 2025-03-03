using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    { 
        public string msg = "";
        public Form1()
        {
            InitializeComponent();
            Font labelFont = new Font("Arial", 25);

            label1.Font = labelFont;
            label2.Font = labelFont;

            msg += "Nume: " + textBox1.Text + '\n' + "Nr de telefon: " + textBox2.Text;

            Font tb = new Font("Arial", 15);

            label3.Font = labelFont;
            
        }

        
    
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex - 1 >= 0)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex + 1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }

            richTextBox3.Text += msg_suma + '\n' + msg_total1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string msg1 = "";
        public string msg_total = "";
        public string msg_suma = "";
       
        public int suma = 0;
        public int total = 0;
        public string msg_total1 = "";
        int suma_totala = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Margherita"))
                suma += 27;

            else if (comboBox1.SelectedItem.Equals("Marinara"))
                suma += 28;

            else if (comboBox1.SelectedItem.Equals("Prosciutto e funghi"))
                suma += 29;

            else if (comboBox1.SelectedItem.Equals("Quattro Stagioni"))
                suma += 26;


            else if (comboBox1.SelectedItem.Equals("Capricciosa"))
                suma += 30;

            else if (comboBox1.SelectedItem.Equals("Diavola"))

                suma += 31;


            else if (comboBox1.SelectedItem.Equals("Boscaiola"))
                suma += 28;


            else if (comboBox1.SelectedItem.Equals("Frutti di Mare"))
                suma += 35;


            else if (comboBox1.SelectedItem.Equals("PIZZA CU ALUAT DIN BRANZA"))
                suma += 25;
              

            msg1 += comboBox1.Text + '\n' + "Suma: " + " " + suma.ToString() + '\n';

            msg_suma += msg1;

           richTextBox2.Text = msg1;
        }

        public string msg_ketchup = "";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            total += 3;
            msg_suma += "Sosuri: " + total.ToString() + '\n';
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            total += 4;
            msg_suma += "Sosuri: " + total.ToString() + '\n';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            total += 12;
            msg_suma += "Transport: " + total.ToString() + '\n';
            suma_totala += suma + total;
            msg_total1 +="Suma totala de plata:" + suma_totala.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
