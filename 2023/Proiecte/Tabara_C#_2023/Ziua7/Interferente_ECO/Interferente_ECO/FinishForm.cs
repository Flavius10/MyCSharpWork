﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interferente_ECO
{
    public partial class FinishForm : Form
    {
        public FinishForm()
        {
            InitializeComponent();
            lblMsg.BackColor = Color.Transparent;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
