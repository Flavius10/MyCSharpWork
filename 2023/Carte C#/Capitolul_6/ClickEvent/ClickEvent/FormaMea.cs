using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickEvent
{
    public partial class FormaMea : Form
    {
        public FormaMea()
        {
            InitializeComponent();
        }

        private void buton_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            MessageBox.Show("Ati facut click pe controlul: " + c.Name + " cu eticheta " + c.Text);
        }
    }
}
