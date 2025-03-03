using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Subiectul20 : Form
    {
        public Subiectul20()
        {
            InitializeComponent();
        }

        private void Subiectul20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazieDataSet.Magazin' table. You can move, or remove it, as needed.
            this.magazinTableAdapter.Fill(this.magazieDataSet.Magazin);

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            magazinTableAdapter.InsertProducts(txtDenumire.Text, int.Parse(txtPret.Text), dtpData.Value.ToString());
            this.magazinTableAdapter.Fill(this.magazieDataSet.Magazin);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            this.magazinTableAdapter.FillByPrice(magazieDataSet.Magazin, int.Parse(txtPrice.Text));
        }
    }
}
