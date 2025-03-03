using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOOD_FOOD
{
    public partial class GoodFoodStart : Form
    {
        public GoodFoodStart()
        {
            InitializeComponent();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creare_cont_client ccc = new Creare_cont_client();
            ccc.ShowDialog();
            this.Close();
        }

        private void btnautentificare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificare_client ac = new Autentificare_client();
            ac.ShowDialog();
            this.Close();
        }
    }
}
