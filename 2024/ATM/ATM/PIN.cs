using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class PIN : Form
    {
        private int cnt = 0;

        public PIN()
        {
            InitializeComponent();
        }

        private void Oprire(int cnt)
        {
            if (cnt == 4)
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn0.Enabled = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPin.Text += 1;
            cnt++;
            Oprire(cnt);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPin.Text += 2;
            cnt++;
            Oprire(cnt);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPin.Text += 3;
            cnt++;
            Oprire(cnt);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPin.Text += 4;
            cnt++; 
            Oprire(cnt);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPin.Text += 5;
            cnt++;
            Oprire(cnt);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPin.Text += 6;
            cnt++;
            Oprire(cnt);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPin.Text += 7;
            cnt++;
            Oprire(cnt);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPin.Text += 8;
            cnt++;
            Oprire(cnt);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPin.Text += 9;
            cnt++;
            Oprire(cnt);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPin.Text += 0;
            cnt++;
            Oprire(cnt);
        }
    }
}
