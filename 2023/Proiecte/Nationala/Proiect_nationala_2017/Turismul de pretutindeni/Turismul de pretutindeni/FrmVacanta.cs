using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turismul_de_pretutindeni
{
    public partial class FrmVacanta   : Form
    {
        Timer timer = new Timer();
        private string pozitie = "";
        private string email = "";
        Random r = new Random();
        private string files = "";

        private string path = Directory.GetCurrentDirectory();
        private string filePath = "";

        public FrmVacanta(string pozitie, string email)
        {
            InitializeComponent();
            filePath = Path.Combine(path, "Imagini");

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;

            this.pozitie = pozitie;
            this.email = email;

            menuStrip1.Items[2].Text = email;

            if (pozitie == "Admin")
            {
                menuStrip1.Items[0].Text = "Admin";
                menuStrip1.Items[0].Enabled = true;
            }
            else
            {
                menuStrip1.Items[0].Enabled = false;
            }

            btnStanga.BackgroundImageLayout = ImageLayout.Stretch;
            btnDreapta.BackgroundImageLayout = ImageLayout.Stretch;

            GetFiles();
            pbSlideShow.Image = Image.FromFile(files);
            pbSlideShow.SizeMode = PictureBoxSizeMode.StretchImage;

            CitesteDate();
        }

        bool ok = false;


        private void GetFiles()
        {
            var file = Directory.GetFiles(filePath);
            files = file[4];
        }

        private void GetFilesStanga(int cnt)
        {
            var file = Directory.GetFiles(filePath);
            files = file[cnt];
        }

        private void GetFiles0()
        {
            ok = true;
            var file = Directory.GetFiles(filePath);
            files = file[7];
        }

        private void GetFiles1()
        {
            var file = Directory.GetFiles(filePath);
            files = file[1];
        }

        private void GetFiles2()
        {
            var file = Directory.GetFiles(filePath);
            files = file[0];
        }

        private void GetFiles3()
        {
            var file = Directory.GetFiles(filePath);
            files = file[2];
        }

        private void GetFiles5()
        {
            var file = Directory.GetFiles(filePath);
            files = file[5];
        }

        private void GetFiles6()
        {
            var file = Directory.GetFiles(filePath);
            files = file[6];
        }

        private void GetFiles7()
        {
            var file = Directory.GetFiles(filePath);
            files = file[3];
        }

        private int cnt = 0;
        private int cnt1 = 0;

        private void SchimbaImagini()
        {
            if (cnt == 0)
            {
                GetFiles0();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt == 1)
            {
                GetFiles1();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt == 2)
            {
                GetFiles2();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt == 3)
            {
                GetFiles3();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt == 4)
            {
                GetFiles5();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt == 5)
            {
                GetFiles6();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt == 6)
            {
                GetFiles7();
                pbSlideShow.Image = Image.FromFile(files);
                cnt = -1;
            }
            cnt++;
            cnt1 = cnt + 1;
        }

        private void btnDreapta_Click(object sender, EventArgs e)
        {
            SchimbaImagini();
        }

        private void btnStanga_Click(object sender, EventArgs e)
        {
            if (cnt1 == 2)
            {
                GetFiles7();
                pbSlideShow.Image = Image.FromFile(files);
                cnt1 = 9;
            }

            if (cnt1 == 3)
            {
                GetFiles0();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt1 == 4)
            {
                GetFiles1();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt1 == 5)
            {
                GetFiles2();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt1 == 6)
            {
                GetFiles3();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt1 == 7)
            {
                GetFiles5();
                pbSlideShow.Image = Image.FromFile(files);
            }

            if (cnt1 == 8)
            {
                GetFiles6();
                pbSlideShow.Image = Image.FromFile(files);
            }


            cnt1--;
        }

        int cnt_citire = 0;
        private void CitesteDate()
        {
            StreamReader sr = new StreamReader("Vacante.txt");

            string line = "";
            string[] s;
            char[] split = {'|'};
            string adu = "";
            string antalya = "";
            string Bodrum = "";
            string cluj = "";
            string Sibiu = "";
            string Sicilia = "";
            string tenerife = "";

            while((line = sr.ReadLine()) != null) 
            {
                cnt_citire++;
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                if(cnt_citire == 1)
                {
                    tenerife = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' +  s[1].ToString();
                }

                if (cnt_citire == 2)
                {
                    antalya = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' + s[1].ToString();
                }

                if (cnt_citire == 3)
                {
                    adu = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' + s[1].ToString();
                }

                if (cnt_citire == 4)
                {
                    Bodrum = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' + s[1].ToString();
                }

                if (cnt_citire == 5)
                {
                    Sibiu = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' + s[1].ToString();
                }

                if (cnt_citire == 6)
                {
                    Sicilia = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' + s[1].ToString();
                }

                if (cnt_citire == 7)
                {
                    cluj = s[0].ToString() + '\n' + s[2].ToString() + '\n' + s[3].ToString() + '\n' + s[1].ToString();
                }    
            } 
        }

        private void cbAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Interval = 2000;
            timer.Tick += TimerTick;   
        }

        private void TimerTick(object sender, EventArgs e)
        {
            SchimbaImagini();
            if (cbAutoPlay.Checked == false)
            {
                timer.Enabled = false;
            }
        }

    }
}
