using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TreeViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            comboBox1.Items.AddRange(drives);
        }

        private char[] sep = new char[] { '\\' };
        private string drvLetter = null;

        private void PopulateTreeView(string path, TreeNode node)
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] auxs;

            foreach(string dir in dirs)
            {
                auxs = dir.Split(sep);  
                TreeNode tn = new TreeNode(auxs[auxs.Length - 1]);
                node.Nodes.Add(tn);
                PopulateTreeView(dir, tn);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            drvLetter = comboBox1.Items[comboBox1.SelectedIndex].ToString();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            treeView1.Nodes.Add(drvLetter);
            drvLetter += "\\";

            PopulateTreeView(drvLetter, treeView1.Nodes[0]);

            treeView1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
