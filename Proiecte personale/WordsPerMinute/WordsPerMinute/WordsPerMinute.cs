using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA_Central.CustomControls;

namespace WordsPerMinute
{
    public partial class WordsPerMinute : Form
    {       
        private string path = Directory.GetCurrentDirectory();
        private string filePath = string.Empty;

        public WordsPerMinute()
        {
            InitializeComponent();
            this.Width = 750;
            filePath = Path.Combine(path, "Loggo.png");
            Design();
        }

        private void Design()
        {
            Color plc = Color.FromArgb(0, 8, 7);
            Color prc = Color.FromArgb(162, 163, 187);
            Color btn = Color.FromArgb(179, 183, 238);

            Panel panel_left = new Panel()
            {
                Width = 150,
                Height = this.Height,
                Location = new Point(0, 0),
                BackColor = plc
            };

            Panel panel_right = new Panel()
            {
                Width = this.Width - 150,
                Height = this.Height,
                Location = new Point(150, 0),
                BackColor = prc
            };

            this.Controls.Add(panel_left);
            this.Controls.Add(panel_right);

            panel_right.Paint += PaintImage;

            RoundButton btn_Start = new RoundButton
            {
                Width = 200,
                Height = 60,
                BackColor = btn,
                Location = new Point(192, 260),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial",25, FontStyle.Bold),
                Text = "Start!",
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            panel_right.Controls.Add(btn_Start);
            btn_Start.Click += ButtonClickStart;
        }

        private void PaintImage(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile(filePath);
            Rectangle r = new Rectangle(-50, 0, 700, 500);
            e.Graphics.DrawImage(img, r);
        }

        private void ButtonClickStart(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            this.Hide();
            lp.ShowDialog();
            this.Close();
        }
    }
}
