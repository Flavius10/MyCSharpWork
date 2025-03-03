using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen p = new Pen(Color.Red, 3);

            g.DrawLine(p, new Point(20, 30), new Point(280, 30));

            g.DrawArc(p, 50, 50, 200, 100, 0, 360);

            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Rectangle r = new Rectangle(new Point(50, 50),
                                        new Size(200, 100));

            g.DrawRectangle(p, r);

            p.Dispose();
        }
    }
}
