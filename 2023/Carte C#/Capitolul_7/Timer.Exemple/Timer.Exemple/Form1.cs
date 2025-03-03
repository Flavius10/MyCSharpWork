using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer.Exemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int time = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            time += 2;

            label2.Text = string.Format("{0}", time);

            progressBar1.PerformStep();
            if (time == 20)
            {
                winTimer.Stop();
                progressBar1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winTimer.Enabled = true;
            if (time == 20)
            {
                time = 0;
                progressBar1.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            winTimer.Stop();
            progressBar1.Enabled = false;
            if (time == 20)
            {
                time = 0;
                progressBar1.Value = 0;
            }
        }

        private void systemTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            label5.Text = System.DateTime.Now.ToLongTimeString();
        }
    }
}
