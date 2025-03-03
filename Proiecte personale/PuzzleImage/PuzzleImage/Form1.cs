using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog = null;
        Image image;
        PictureBox picBoxWhole = null;

        private void buttonImageBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog == null)
                openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textboxImagePath.Text = openFileDialog.FileName;
                image = CreatBitmapImage(Image.FromFile(openFileDialog.FileName));

                if (picBoxWhole == null)
                {
                    picBoxWhole = new PictureBox();
                    picBoxWhole.Height = groupboxPuzzle.Height;
                    picBoxWhole.Width = groupboxPuzzle.Width;
                    groupboxPuzzle.Controls.Add(picBoxWhole);
                }
            }

            picBoxWhole.Image = image;
        }

        private Bitmap CreatBitmapImage(Image image)
        {
            Bitmap objBmpImage = new Bitmap(groupBox1.Width, groupboxPuzzle.Height);

            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, groupboxPuzzle.Width, groupboxPuzzle.Height));
            objGraphics.Flush();

            return objBmpImage;
        }

        PictureBox[] picBoxes = null;
        Image[] images = null;
        const int LEVEL_1_NUM = 4;
        const int LEVEL_2_NUM = 16;
        const int LEVEL_3_NUM = 25;
        const int LEVEL_4_NUM = 36;
        int current_level = 0;

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            current_level = LEVEL_1_NUM;
            labelStatus.Text = "Level 1 is ongoing...";
            int[] indice = PlayLevel1();

            shuffle(ref indice);

            for (int i = 0; i < current_level; ++i)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];
            }
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            current_level = LEVEL_2_NUM;
            labelStatus.Text = "Level 2 is ongoing...";
            int[] indice = PlayLevel2();

            shuffle(ref indice);

            for (int i = 0; i < current_level; ++i)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];
            }
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            current_level = LEVEL_3_NUM;
            labelStatus.Text = "Level 3 is ongoing...";
            int[] indice = PlayLevel3();

            shuffle(ref indice);

            for (int i = 0; i < current_level; ++i)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];
            }
        }

        private void btnLevel4_Click(object sender, EventArgs e)
        {
            current_level = LEVEL_4_NUM;
            labelStatus.Text = "Level 4 is ongoing...";
            int[] indice = PlayLevel4();

            shuffle(ref indice);

            for (int i = 0; i < current_level; ++i)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];
            }
        }

        private int[] PlayLevel1()
        {
            if (picBoxWhole != null)
            {
                groupboxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }

            if (picBoxes == null)
            {
                images = new Image[LEVEL_1_NUM];
                picBoxes = new PictureBox[LEVEL_1_NUM];
            }

            int numRow = (int)Math.Sqrt(current_level);
            int numCol = numRow;
            int unitX = groupboxPuzzle.Width / numRow;
            int unitY = groupboxPuzzle.Height / numCol;
            int[] indice = new int[current_level];


            for (int i = 0; i < current_level; ++i)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                ((MyPictureBox)picBoxes[i]).Index = i;

                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);

                picBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));
                if (!groupboxPuzzle.Controls.Contains(picBoxes[i]))
                {
                    groupboxPuzzle.Controls.Add(picBoxes[i]);
                }
            }

            return indice;
        }
        private int[] PlayLevel2()
        {
            if (picBoxWhole != null)
            {
                groupboxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }

            if (picBoxes == null)
            {
                images = new Image[LEVEL_2_NUM];
                picBoxes = new PictureBox[LEVEL_2_NUM];
            }

            int numRow = (int)Math.Sqrt(current_level);
            int numCol = numRow;
            int unitX = groupboxPuzzle.Width / numRow;
            int unitY = groupboxPuzzle.Height / numCol;
            int[] indice = new int[current_level];


            for (int i = 0; i < current_level; ++i)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                ((MyPictureBox)picBoxes[i]).Index = i;

                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);

                picBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));
                if (!groupboxPuzzle.Controls.Contains(picBoxes[i]))
                {
                    groupboxPuzzle.Controls.Add(picBoxes[i]);
                }
            }

            return indice;
        }
        private int[] PlayLevel3()
        {
            if (picBoxWhole != null)
            {
                groupboxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }

            if (picBoxes == null)
            {
                images = new Image[LEVEL_3_NUM];
                picBoxes = new PictureBox[LEVEL_3_NUM];
            }

            int numRow = (int)Math.Sqrt(current_level);
            int numCol = numRow;
            int unitX = groupboxPuzzle.Width / numRow;
            int unitY = groupboxPuzzle.Height / numCol;
            int[] indice = new int[current_level];


            for (int i = 0; i < current_level; ++i)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                ((MyPictureBox)picBoxes[i]).Index = i;

                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);

                picBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));
                if (!groupboxPuzzle.Controls.Contains(picBoxes[i]))
                {
                    groupboxPuzzle.Controls.Add(picBoxes[i]);
                }
            }

            return indice;
        }
        private int[] PlayLevel4()
        {
            if (picBoxWhole != null)
            {
                groupboxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }

            if (picBoxes == null)
            {
                images = new Image[LEVEL_4_NUM];
                picBoxes = new PictureBox[LEVEL_4_NUM];
            }

            int numRow = (int)Math.Sqrt(current_level);
            int numCol = numRow;
            int unitX = groupboxPuzzle.Width / numRow;
            int unitY = groupboxPuzzle.Height / numCol;
            int[] indice = new int[current_level];


            for (int i = 0; i < current_level; ++i)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                ((MyPictureBox)picBoxes[i]).Index = i;

                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);

                picBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));
                if (!groupboxPuzzle.Controls.Contains(picBoxes[i]))
                {
                    groupboxPuzzle.Controls.Add(picBoxes[i]);
                }
            }

            return indice;
        }

        private void CreateBitmapImage(Image image, Image[] images, int index, int numRow, int numCol, int unitX, int unitY)
        {
            images[index] = new Bitmap(unitX, unitY);
            Graphics objGraphics = Graphics.FromImage(images[index]);
            objGraphics.Clear(Color.White);

            objGraphics.DrawImage(image, new Rectangle(0, 0, unitX, unitY),
                                         new Rectangle(unitX * (index % numCol), unitY * (index / numCol), unitX, unitY), GraphicsUnit.Pixel);

            objGraphics.Flush();
        }

        private void shuffle(ref int[] array)
        {
            Random rnd = new Random();
            int n = array.Length;

            while(n > 1)
            {
                int k = rnd.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        private MyPictureBox firstBox = null;
        private MyPictureBox secondBox = null;

        public void OnPuzzleClick(object sender, EventArgs e)
        {
            if (firstBox == null)
            {
                firstBox =(MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if(secondBox == null)
            {
                secondBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
                secondBox.BorderStyle = BorderStyle.FixedSingle;
                SwitchImages(firstBox, secondBox); 
                firstBox = null;
                secondBox = null;
            }
            //else
            //{
            //    firstBox = secondBox;
            //    firstBox.BorderStyle = BorderStyle.Fixed3D;
            //    secondBox = (MyPictureBox)sender;
            //    secondBox.BorderStyle = BorderStyle.FixedSingle;
            //    SwitchImages(firstBox, secondBox);
            //}
        }

        private void SwitchImages(MyPictureBox pictureBox, MyPictureBox pictureBox2)
        {
            int tmp = pictureBox2.ImageIndex;
            pictureBox2.Image = images[pictureBox.ImageIndex];
            pictureBox2.ImageIndex = pictureBox.ImageIndex;
            pictureBox.Image = images[tmp];
            pictureBox.ImageIndex = tmp;

            if (isSuccessful())
            {
                labelStatus.Text = "Well Done!";
            }
        }

        private bool isSuccessful()
        {
            for (int i = 0;i < current_level; i++)
            {
                if (((MyPictureBox)picBoxes[i]).ImageIndex != ((MyPictureBox)picBoxes[i]).Index)
                    return false;
            }
            return true;
        }
    }
}
