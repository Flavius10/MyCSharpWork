using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.TreeView tw = new System.Windows.Forms.TreeView();    
            
            tw.Location = new System.Drawing.Point(12, 12);
            tw.Size = new System.Drawing.Size(153, 153);

            tw.Nodes.Add("Baietii");

            tw.Nodes[0].Nodes.Add("Marius");
            tw.Nodes[0].Nodes.Add("Valentin");

            tw.Nodes[0].Nodes[0].Nodes.Add("Ocupatie");
            tw.Nodes[0].Nodes[0].Nodes.Add("Hobby");

            tw.Nodes[0].Nodes[1].Nodes.Add("Varsta");
            tw.Nodes[0].Nodes[1].Nodes.Add("Scoala");


            this.Controls.Add(tw);

        }
    }
}
