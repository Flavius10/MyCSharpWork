using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA_Central.CustomControls;

namespace WindowsFormsApp1
{
    public partial class Forma : Form
    {
        Button btn = new Button();
        int cnt = 0;
        public Forma()
        {
            InitializeComponent();
            btn.Location = new Point(100, 100);
            btn.Size = new Size(200, 200);
            btn.BackColor = Color.Black;
            btn.Text = "Apasa";
            btn.Click += ButtonClick;
            this.Controls.Add(btn);
            RoundButton r_btn = new RoundButton();


            r_btn.Location = new Point(100, 300);
            r_btn.Size = new Size(100, 100);
            r_btn.BackColor = Color.Orange;
            r_btn.Text = "Buton Rotund";
            r_btn.Click += ButtonClick;
            r_btn.BorderRadius = 50;
            this.Controls.Add(r_btn);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt % 2 == 1)
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.Green;
            }
            else
            {
                btn.BackColor = Color.Yellow;
                btn.ForeColor = Color.Blue;
            }

        }

    }
}
