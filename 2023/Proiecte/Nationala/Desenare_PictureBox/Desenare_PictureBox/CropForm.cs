using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenare_PictureBox
{
    public partial class CropForm : Form
    {
        string fileName = string.Empty;
        Image img;

        public CropForm()
        {
            InitializeComponent();
        }

        private void btnSelecteazaImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "JPG(*.jpg) | *.jpg";
            ofd.Title = "Alege Imaginea";
            ofd.InitialDirectory = Environment.CurrentDirectory + @"\Imagini";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagine.Image = Image.FromFile(ofd.FileName);
                fileName = ofd.FileName;
                pbImagineCrop.Paint += Drawing_Paint;
            }
            
            pbImagineCrop.Image = img;

        }

        private void Drawing_Paint(object sender, PaintEventArgs e)
        {
            Image img = Bitmap.FromFile(fileName);
            int x = 150;
            int y = 150;
            int L = img.Width;
            Draw(3, x, y, L, img, e);
        }

        Bitmap CropFrom(Image img, RectangleF source)
        {
            Bitmap bmp = new Bitmap((int)source.Width, (int)source.Height);

            using(Graphics g = Graphics.FromImage(bmp))
            {
                RectangleF r = new RectangleF(0, 0, bmp.Width, bmp.Height);
                g.DrawImage(img, r, source, GraphicsUnit.Pixel);
            }

            return bmp;
        }

        public void Draw(int k, float x, float y, float L, Image img, PaintEventArgs e)
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

        private PictureBox GetPbImagineCrop()
        {
            return pbImagineCrop;
        }

        private void btnSalveazaImaginea_Click(object sender, EventArgs e, PictureBox pbImagineCrop)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Images(*.bmp) | *.bmp";
            saveFileDialog.Title = "Salveaza Imagine";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory + @"\Imagini_Salvate\";
            ImageFormat format = ImageFormat.Bmp;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImagineCrop.Image.Save(saveFileDialog.FileName, format);
            }
        }
    }
}
