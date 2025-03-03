using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Blue, 20);

            Rectangle r = new Rectangle(new Point(50, 50),
                                        new Size(200, 100));

            e.Graphics.DrawRectangle(p, r);

            p.Dispose();
        }
    }
}
