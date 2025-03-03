using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Alexa_Flavius_Catalin
{
    public partial class Drogherie : Form
    {
        public Drogherie()
        {
            InitializeComponent();
        }

        private void Drogherie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmacieDBDataSet.Medicamente' table. You can move, or remove it, as needed.
            this.medicamenteTableAdapter.Fill(this.farmacieDBDataSet.Medicamente);

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = int.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("ID-ul trebuie sa fie un numar natural", "ID gresit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int pret = 0;

            try
            {
                pret = int.Parse(txtPretNou.Text);
            }
            catch
            {
                MessageBox.Show("Pretul trebuie sa fie un numar natural", "Pret gresit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.medicamenteTableAdapter.UpdatePrice(pret, id);
            this.medicamenteTableAdapter.Fill(this.farmacieDBDataSet.Medicamente);
        }

        private void btnCompensat_Click(object sender, EventArgs e)
        {
            this.medicamenteTableAdapter.FillByCompensat(this.farmacieDBDataSet.Medicamente, 0);
        }
    }
}
