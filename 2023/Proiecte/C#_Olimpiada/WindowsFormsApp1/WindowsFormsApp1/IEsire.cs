using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IEsire : Form
    {
        private Timer timer = null;

        public IEsire()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += TimerTick;
            timer.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Application.Exit();
        }
    }
}
