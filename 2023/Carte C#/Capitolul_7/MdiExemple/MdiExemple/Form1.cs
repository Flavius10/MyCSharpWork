using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int nr = 0;

        private void CreateChild()
        {
            Form f = new Form();
            nr++;
            TextBox tx = new TextBox();
            f.Controls.Add(tx);
            

            f.Text = "Documentul" + nr;

            f.MdiParent = this;

            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChild();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                nr = 0;
            CreateChild();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.WindowState = FormWindowState.Maximized;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Esti sigur ca vrei sa parasesti aplicatia?",
                "Avertizare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                nr = 0;
            CreateChild();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.WindowState = FormWindowState.Maximized; 
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                f.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
