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

namespace Desenare
{
    public partial class Desnenare : Form
    {
        public Desnenare()
        {
            InitializeComponent();
        }

        private void Desnenare_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Image img = Bitmap.FromFile("5.jpg");
            int x = 333, y = 150;
            int L = img.Width;
            Draw(3, x, y, L, img, e);

            RectangleF r = new RectangleF(100, 100, 100, 100);
            e.Graphics.DrawEllipse(new Pen(Color.Red), r);
        }

        Bitmap CropFrom(Image img, RectangleF source)
        {

            Bitmap bmp = new Bitmap((int)source.Width, (int)source.Height);

            using(Graphics g = Graphics.FromImage(bmp))
            {
                RectangleF r = new RectangleF(0, 0, bmp.Width, bmp.Width);
                g.DrawImage(img, r, source, GraphicsUnit.Pixel);
            }

            return bmp;
        }

        private void Draw(int k, float x, float y, float L, Image img, PaintEventArgs e)
        {
            if (k == 0)
                return;

            e.Graphics.DrawImage(img, x, y, L, L);
            Bitmap img1 = CropFrom(img, new RectangleF(0, 0, L / 2, L / 2));
            Draw(k - 1, x - L / 4, y - L / 4, L / 2, img1, e);

            Bitmap img2 = CropFrom(img, new RectangleF(L / 2, 0, L / 2, L / 2));
            Draw(k - 1, x + 3 * L / 4, y - L / 4, L / 2, img2, e);

            Bitmap img3 = CropFrom(img, new RectangleF(0, L / 2, L / 2, L / 2));
            Draw(k - 1, x - L / 4, y + 3 * L / 4, L / 2, img3, e);

            Bitmap img4 = CropFrom(img, new RectangleF(L / 2, L / 2, L / 2, L / 2));
            Draw(k - 1, x + 3 * L / 4, y + 3 * L / 4, L / 2, img4, e);
        }
    }
}
