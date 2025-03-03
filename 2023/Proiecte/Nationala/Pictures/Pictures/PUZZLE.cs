using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictures
{
    public partial class PUZZLE : Form
    {
        public PUZZLE()
        {
            InitializeComponent();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Hide();
            _9_elemente el = new _9_elemente();
            el.ShowDialog();
            this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _4_elemente el = new _4_elemente();
            el.ShowDialog();
            this.Close();
        }
    }
}
