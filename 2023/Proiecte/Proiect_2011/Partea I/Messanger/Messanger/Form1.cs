using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Net.Sockets;

namespace Messanger
{
    public partial class MessangerForm : Form
    {
        public MessangerForm()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            RichTextBoxMSG.Text = " ";
        }

        public string mesaj = " ";
        private void button1_Click(object sender, EventArgs e)
        {
            mesaj = "Maria: " + RichTextBoxMesaje.Text + '\n';

            Font font = new Font("Tahoma", 8, FontStyle.Regular);
            RichTextBoxMSG.SelectionFont = font;
            RichTextBoxMSG.SelectionColor = Color.Red;
            RichTextBoxMSG.SelectedText =  mesaj;

            mesaj = " ";
            RichTextBoxMesaje.Text = " "; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mesaj = "Ionel: " + RichTextBoxMesaje.Text + '\n';

            Font font = new Font("Tahoma", 8, FontStyle.Regular);
            RichTextBoxMSG.SelectionFont = font;
            RichTextBoxMSG.SelectionColor = Color.Blue;
            RichTextBoxMSG.SelectedText = mesaj;

            mesaj = " ";
            RichTextBoxMesaje.Text = " ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salveaza Fisier";

            saveFileDialog1.DefaultExt = ".rtf";

            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                RichTextBoxMSG.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxMSG.LoadFile(openFileDialog1.FileName);
            }
        }
    }
}
