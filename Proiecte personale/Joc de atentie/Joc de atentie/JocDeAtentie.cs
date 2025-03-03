using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joc_de_atentie
{
    public partial class JocDeAtentie : Form
    {

        Random r = new Random();
        public List<int> randomList = new List<int>(10);
        public int a;
        public int control_cnt = -1;
        private int secunde = 0;
        private int[] numere_salvate = new int[10];
        private int nr = 0;
        public int butoane_apasate = 0;
        private bool ok_cerinte = true;
        private int secunde_final = 0;

        public JocDeAtentie()
        {
            InitializeComponent();
            for (int i = 0; i < 1000; ++i)
            {
                a = r.Next(1, 10);
                if (!randomList.Contains(a))
                {
                    randomList.Add(a);
                }
            }

            timerAscunde.Start();
        }

        private void JocDeAtentie_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                
                if (control is Button)
                {
                   control_cnt++;
                   control.Text = randomList[control_cnt].ToString();
                }
            }
        }

        private void timerAscunde_Tick(object sender, EventArgs e)
        {
            secunde++;

            if (secunde == 20)
            {
                timerCastig.Start();
                timerAscunde.Stop();
                Ascunde();
            }
        }

        private void Ascunde()
        {
            foreach(Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Tag = control.Text;
                    control.Text = "";
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (timerAscunde.Enabled == false)
            {
                butoane_apasate++;
                var button = (Button)sender;

                button.Enabled = false;
                numere_salvate[++nr] = Int32.Parse(button.Tag.ToString());
            }

        }

        private void Verifica()
        {
            for (int i = 1; i <= 9; ++i)
            {
                if (numere_salvate[i] != i)
                {
                    ok_cerinte = false;
                }
            }
        }

        private void timerCastig_Tick(object sender, EventArgs e)
        {
            secunde_final++;
            if (butoane_apasate == 9)
            {
                Verifica();
                timerCastig.Stop();

                if (ok_cerinte == true)
                {
                    MessageBox.Show("Ati terminat jocul in " + secunde_final.ToString(), "CASTIGAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ai ratat, nu esti suficient de atent!", "FI MAI ATENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}