using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BrushesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Red, 3);

            int x = 10, y = 10, width = 200, height = 100;
            Rectangle r = new Rectangle(x, y, width, height);   

            SolidBrush s = new SolidBrush(Color.Aquamarine);

            e.Graphics.FillEllipse(s, r);

            y = 120;
            r = new Rectangle(x, y, width, height);

            HatchBrush h = new HatchBrush(HatchStyle.DiagonalCross,
                                            Color.Azure, Color.Black);

            e.Graphics.FillEllipse(h, r);

            y = 230;
            r = new Rectangle(x, y, width, height);

            LinearGradientBrush lg = new LinearGradientBrush(r, Color.Aqua,
                            Color.BlueViolet, LinearGradientMode.Horizontal);

            e.Graphics.FillEllipse(lg, r);

            x = 230; y = 15; width= 250; height = 310;

            r = new Rectangle(x, y, width, height);

            TextureBrush t = new TextureBrush(Image.FromFile("floare.jpg"));

            e.Graphics.FillRectangle(t, r);

            p.Dispose();
        }
    }
}
