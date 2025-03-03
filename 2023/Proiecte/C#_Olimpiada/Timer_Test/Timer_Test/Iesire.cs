using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Test
{
    public partial class Iesire : Form
    {
        private Timer timer;

        public Iesire()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 2500;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Application.Exit();
        }
    }
}
