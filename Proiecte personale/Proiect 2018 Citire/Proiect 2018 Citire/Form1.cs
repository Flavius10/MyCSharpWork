using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2018_Citire
{
    public partial class Form1 : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private string filePath = string.Empty;
        List<string> fisier = new List<string>();
        int utilizator = 0;
        int item = 0;
        int eva = 0;

        List<string> utilizatori = new List<string>();
        List<string> itemi = new List<string>();
        List<string> evaluari = new List<string>();

        public Form1()
        {
            InitializeComponent();
            filePath = Path.Combine(path, "date.txt");
            CitesteDate();
            SalveazaIndexi();
            SalveazaText();
        }

        private void CitesteDate()
        {
            using(StreamReader sr = new StreamReader(filePath))
            {
                string line = "";
                string[] s;
                char[] split = { ';' };

                while((line = sr.ReadLine()) != null)
                {
                    s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < s.Length; i++)
                    {
                        fisier.Add(s[i]);
                    }
                }

            }
        }

        private void SalveazaIndexi()
        {
            for (int i = 0; i < fisier.Count; i++)
            {
                if (fisier[i] == "Utilizatori:")
                {
                    utilizator = i;
                }

                if (fisier[i] == "Itemi:")
                {
                    item = i;
                }

                if (fisier[i] == "Evaluari:")
                {
                    eva = i;
                }
            }
        }

        private void SalveazaText()
        {
            for (int i = 0; i < fisier.Count; ++i)
            {
                if (i > utilizator && i < item)
                    utilizatori.Add(fisier[i]);
                if (i > item && i < eva)
                    itemi.Add(fisier[i]);
                if(i > eva)
                    evaluari.Add(fisier[i]);
            }

            for (int i = 0; i < evaluari.Count; i += 3)
            {
                richTextBox1.Text += evaluari[i] + ' ';
            }

            //for (int i = 0; i < itemi.Count; ++i)
            //{
            //    richTextBox1.Text += itemi[i] + ' ';
            //}

            //for (int i = 0; i < utilizatori.Count; ++i)
            //{
            //    richTextBox1.Text += utilizatori[i] + ' ';
            //}

        }
    }
}
