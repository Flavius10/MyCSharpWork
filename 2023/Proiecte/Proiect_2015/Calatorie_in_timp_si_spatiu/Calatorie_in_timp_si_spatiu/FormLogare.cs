using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatorie_in_timp_si_spatiu
{
    public partial class FormLogare : Form
    {
        public FormLogare()
        {
            InitializeComponent();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (txtUtilizator.Text == "Turist" && txtParola.Text == "oti2015")
            {
                Turist turist = new Turist();
                turist.Show();
            }
            else if (txtUtilizator.Text == "Administrator" && txtParola.Text == "agentie2015")
            {
                Administrator administrator = new Administrator();
                administrator.Show();
            }
        }

        
    }
}
