using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifre_ordonate
{
    public partial class Verifica : Form
    {
        public Verifica()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            int n = Int32.Parse(txtNumar.Text);

            while(n != 0)
            {
                int nr = n % 10;
                n /= 10;

                if(nr > n % 10)
                {
                    cnt++;
                }
            }

            if (cnt == txtNumar.Text.Length)
            {
                Corect c = new Corect();
                c.ShowDialog();
            }
            else
            {
                Gresit g = new Gresit();
                g.ShowDialog();
            }
        }
    }
}
