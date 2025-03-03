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
using System.Drawing.Drawing2D;

namespace Gradient
{
    public partial class Form1 : Form
    {
        List<PointF> points = new List<PointF>();
        private PointF[] pcts = null;

        public Form1()
        {
            InitializeComponent();
            ReadPoints();
            pcts = points.ToArray();

        }

        private void ReadPoints()
        {
            StreamReader sr = new StreamReader("RomaniaMare.txt");
            string line = "";
            string[] s;
            char[] split = { '*' };

            while((line = sr.ReadLine()) != null)
            {
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                int x = Int32.Parse(s[0]);
                int y = Int32.Parse(s[1]);
                points.Add(new PointF(x, y));
            }

            sr.Close();
            sr.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            PathGradientBrush brush = new PathGradientBrush(pcts);

            Color[] c = { Color.Red, Color.Yellow, Color.Blue};
            float[] pozition = { 0f, 0.5f, 1f};

            ColorBlend blend = new ColorBlend();
            blend.Colors = c;
            blend.Positions = pozition;
            brush.InterpolationColors = blend;

            e.Graphics.DrawClosedCurve(new Pen(Color.YellowGreen, 0.5f), pcts, 0.4f, FillMode.Alternate);
            e.Graphics.FillRectangle(brush, 0, 0, 900, 800);
        }
    }
}
