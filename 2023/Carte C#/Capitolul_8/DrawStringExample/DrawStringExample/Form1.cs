using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStringExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string s = "Dau un regat pt un cal";

            Font f = new Font("Arial", 22, FontStyle.Bold);
            SolidBrush b = new SolidBrush(Color.Red);

            PointF pt = new PointF(20.0F, 30.0F);

            e.Graphics.DrawString(s, f, b, pt);

            float x = 100.0F, y = 100.0F, width = 200.0F, height = 80.0F;
            RectangleF r = new RectangleF(x, y, width, height);

            Pen p = new Pen(Color.Black);
            e.Graphics.DrawRectangle(p, x, y, width, height);

            StringFormat stF = new StringFormat();
            stF.Alignment = StringAlignment.Center;
            f = new Font("Times New roman", 24, FontStyle.Italic);

            e.Graphics.DrawString(s, f, b, r, stF);

            p.Dispose();


        }
    }
}
