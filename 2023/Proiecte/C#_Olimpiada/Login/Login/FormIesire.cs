using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormIesire : Form
    {

        private Timer timer = null;

        public FormIesire()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 3000;
            timer.Enabled = true;
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Application.Exit();
        }
    }
}
