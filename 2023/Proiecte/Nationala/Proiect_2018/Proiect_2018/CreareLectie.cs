using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2018
{
    public partial class CreareLectie : Form
    {
        public CreareLectie()
        {
            InitializeComponent();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }
    }
}
