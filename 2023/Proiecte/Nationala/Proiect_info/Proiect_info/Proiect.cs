using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Proiect_info
{
    public partial class Proiect : Form
    {
        private readonly int[] di = { -1, 0, 1, 0 };
        private readonly int[] dj = { 0, 1, 0, -1 };
        PictureBox[,] pic;
        TableLayoutPanel tbl;
        int[,] L;
        int[,] x;
        private int[,] d;
        private bool[,] obst;
        int n, m;
        int nr_rute = 0;
        int i_start, j_start;
        int i_end, j_end;
        private Color pathColor = Color.Gray;
        private Color outofrun = Color.FromArgb(0, 102, 255);
        private Color backgroundColor = Color.Gray;
        bool termina = false;
        private Color run = Color.White;
        private Timer timer = new Timer();
        private List<string> solPath;
        int index = 0;
        private string coordonate;
        int[] I, J;
        int cnt = 0;
        int idmasina = 0;
        string filePath = "";
        bool ok = false;

        public Proiect(int id, string path)
        {
            InitializeComponent();
            CitesteDate();
            CreateGUI();
            idmasina = id;
            
           MessageBox.Show("Ati ales masina numarul " + id.ToString(), "MASINA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            filePath = path;
            pic[i_start, j_start].Image = Image.FromFile(filePath);

        }

        private void CreateGUI()
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            pic = new PictureBox[n, m];


            tbl = new TableLayoutPanel()
            {
                RowCount = n,
                ColumnCount = m,
                Dock = DockStyle.Fill,
            };

            int H = panel.Height;
            int W = panel.Width;
            int lat = Math.Min(H, W) / Math.Max(n, m);

            for (int j = 0; j < m; ++j)
                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, lat));

            for (int i = 0; i < n; ++i)
            {
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, lat));

                for (int j = 0; j < m; ++j)
                {
                    pic[i, j] = new PictureBox()
                    {
                        BackColor = L[i, j] == 1 ? outofrun : pathColor,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(1),
                        Font = new Font(new FontFamily("Arial"), 14),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    tbl.Controls.Add(pic[i, j]);
                }
            }

            if (idmasina == 1)
                pic[I[cnt - 1], J[cnt - 1]].Image = Image.FromFile("1.png");
            if (idmasina == 2)
                pic[I[cnt - 1], J[cnt - 1]].Image = Image.FromFile("2.png");
            if (idmasina == 3)
                pic[I[cnt - 1], J[cnt - 1]].Image = Image.FromFile("3.png");

            pic[i_start, j_start].SizeMode = PictureBoxSizeMode.StretchImage;
            pic[i_end, j_end].Image = Image.FromFile("finish.png");
            pic[i_end, j_end].SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(tbl);
        }

        private void btn_start_Click(object sender, EventArgs e)
        { 
            nr_rute = 0;
            Back(i_start, j_start, 1);
           
        }

        private bool OK(int i, int j)
        {
            if (i < 0 || i >= n || j < 0 || j >= m) return false;
            if (L[i, j] == 1) return false;
            if (x[i, j] != 0) return false;
            if (termina == true) return false;

            return true;
        }

        int i1;

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            pic[i_start, j_start].BackColor = run;
            pic[0, 1].BackColor = run;
            Lee(i_start, j_start);

            foreach(var list in solPath)
            {
                coordonate += list.ToString();
            }

            char[] split = { ',' };
            string[] s = coordonate.Split(split, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < s.Length; i++)
            {
               
                if (i % 2 == 0)
                { 
                    cnt++;
                    I[cnt] = Int32.Parse(s[i].ToString());
                }
                    
                if (i % 2 == 1)
                    J[cnt] = Int32.Parse(s[i].ToString());
            }

            for (int i = 0; i < cnt; ++i)
            {
                pic[I[i], J[i]].BackColor = run;
            }

            i1 = cnt;

        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            Viteza();
        }

        private void Viteza()
        {
            if (textBox1.Text != "R")
            {
                if (i1 == 1)
                    timer.Enabled = false;
                else
                {
                    
                    pic[I[i1 + 1], J[i1 + 1]].Image = null;
                    if (idmasina == 1)
                        pic[I[i1], J[i1]].Image = Image.FromFile("1.png");
                    if (idmasina == 2)
                        pic[I[i1], J[i1]].Image = Image.FromFile("2.png");
                    if (idmasina == 3)
                        pic[I[i1], J[i1]].Image = Image.FromFile("3.png");

                    i1--;
                }
                if (pic[8, 9].Image != null)
                    MessageBox.Show("ATI CASTIGAT CURSA", "WIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (i1 == cnt - 1)
                    timer.Enabled = false;
                else
                {
                    if (I[i1 - 1] != 0 && J[i1 - 1] != 0)
                    {
                        pic[I[i1 - 1], J[i1  - 1]].Image = null;
                        if (idmasina == 1)
                            pic[I[i1], J[i1]].Image = Image.FromFile("1.png");
                        if (idmasina == 2)
                            pic[I[i1], J[i1]].Image = Image.FromFile("2.png");
                        if (idmasina == 3)
                            pic[I[i1], J[i1]].Image = Image.FromFile("3.png");
                    }
                    i1++;
                }
            }
        }

        private void Back(int i, int j, int k)
        {
            if (!OK(i, j)) return;
            x[i, j] = k;
            pic[i, j].BackColor = run;

            if (i == i_end && j == j_end)
            {
                WriteSol();
            }
            else
                for (int d = 0; d < 4; ++d)
                {
                    int iv = i + di[d];
                    int jv = j + dj[d];
                    Back(iv, jv, k + 1);
                }

            x[i, j] = 0;
            if (nr_rute != 24)
                pic[i, j].BackColor = backgroundColor;

            if (nr_rute == 24)
                pic[i, j].BackColor = backgroundColor;
        }

        private void WriteSol()
        {
            nr_rute++;
            label1.Text = nr_rute.ToString() + " de rute" + '\n';


            System.Threading.Thread.Sleep(250);
            panel.Refresh();
        }

        int viteza;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            
                if (textBox1.Text == "R")
                {
                    timer.Interval = 1000 / 2;
                }

                if (textBox1.Text != "R")
                {
                    viteza = Int32.Parse(textBox1.Text);
                    timer.Interval = 1000 / viteza;
                }
           
                if (textBox1.Text == null)
                    timer.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Ok(int i, int j)
        {
            return i >= 0 && i < n && j >= 0 && j < m;
        }

        private void Lee(int istart, int jstart)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    d[i, j] = int.MaxValue;
                }
            }

            int startX = istart;
            int startY = jstart;

            int finalX = i_end;
            int finalY = j_end;

            Queue<int> queueX = new Queue<int>();
            Queue<int> queueY = new Queue<int>();

            queueX.Enqueue(startX);
            queueY.Enqueue(startY);

            d[startX, startY] = 0;

            while (queueX.Count > 0)
            {
                
                int currentX = queueX.Dequeue();
                int currentY = queueY.Dequeue();

                for (int dis = 0; dis < 4; dis++)
                {
                    int nextX = currentX + di[dis];
                    int nextY = currentY + dj[dis];

                    if (Ok(nextX, nextY) && d[nextX, nextY] == int.MaxValue && obst[nextX, nextY] == false)
                    {
                        d[nextX,nextY] = d[currentX, currentY] + 1;

                        queueX.Enqueue(nextX);
                        queueY.Enqueue(nextY);
                    }
                }
            }

            if (d[finalX, finalY] != int.MaxValue)
            {
                solPath = new List<string>();
                int x = finalX;
                int y = finalY;
                solPath.Add($"{x},{y},");

                while (x != startX && y != startY)
                {
                    for (int dis = 0; dis < 4; dis++)
                    {
                        int nextX = x + di[dis];
                        int nextY = y + dj[dis];
                        if (Ok(nextX, nextY) && d[nextX, nextY] == d[x, y] - 1)
                        {
                            index++;
                            x = nextX;
                            y = nextY;
                            solPath.Insert(index, $"{x},{y},");
                            break;
                        }
                    }
                    
                }

            }
        }

        private void CitesteDate()
        {
            StreamReader sr = new StreamReader("cursa.in");
            char[] split = {' '};
            string line = sr.ReadLine();
            string[] s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

            n = int.Parse(s[0].ToString());
            m = int.Parse(s[1].ToString());
            pic = new PictureBox[n,  m];
            L = new int[n, m];
            x = new int[n, m];
            d = new int[n, m];
            obst = new bool[n, m];
            I = new int[n * m];
            J = new int[n * m];


            line = sr.ReadLine();
            s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

            i_start = int.Parse(s[0].ToString());
            j_start = int.Parse(s[1].ToString());
            i_end = int.Parse(s[2].ToString());
            j_end = int.Parse(s[3].ToString());

            for (int i = 0; i < n; ++i)
            {
                line = sr.ReadLine();
                s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < m; ++j)
                {
                    L[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (L[i, j] == 1)
                        obst[i, j] = true;
                }
            }
        }
    }
}
