using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialoguriPredefinite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Deschide fisier";

            openFileDialog1.Filter = "Fisiere Rich Text (*.rtf)| *.rtf|Fisiere text(*.txt)|*.txt";
            openFileDialog1.FileName = "";

            openFileDialog1.InitialDirectory = "MyDocuments";

            openFileDialog1.CheckFileExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void salveazaCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salveaza fisierul";

            saveFileDialog1.DefaultExt = ".rtf";

            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void setarePaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;

            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;

            pageSetupDialog1.AllowMargins = true;
            pageSetupDialog1.AllowPaper = true;
            pageSetupDialog1.AllowOrientation = true;
            pageSetupDialog1.ShowNetwork = true;
            pageSetupDialog1.EnableMetric = false;
            pageSetupDialog1.ShowHelp = false;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void previzualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void culoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
