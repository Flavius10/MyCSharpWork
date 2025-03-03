using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(100, 200);

            using(Graphics g = Graphics.FromImage(bmp))
            {
                e.Graphics.DrawEllipse(new Pen(Color.Red), new RectangleF(100, 100, 100, 100));
            }
        }
    }
}
