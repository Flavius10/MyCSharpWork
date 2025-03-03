using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Background_Maker
{
    public partial class Background_Maker : Form
    {
        private TableLayoutPanel table;
        private Button[,] btn;
        int n, m;


        private int nrsol;
        private int[,] x;
        private int[,] L;
        private int i1, j1, i2, j2;
        private int[] dx = { -1, 0, 1, 0 };
        private int[] dy = { 0, 1, 0, -1 };

        private Color background = Color.FromArgb(255, 204, 153);
        private Color wallColor = Color.FromArgb(77, 38, 0);
        private Color pathcolor = Color.Red;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Back(i1, j1, 1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UserState us = (UserState)e.UserState;

            if (us != null)
            {
                int i = us.I;
                int j = us.J;
                int k = us.K;
                Color c = us.C;

                btn[i, j].BackColor = c;
                btn[i, j].Text = k == 0 ? string.Empty : k.ToString();
                btn[i, j].Update();
            }
            else
            {
                nrsol++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nrsol = 0;
            if (backgroundWorker1.IsBusy)
                return;
            backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }

        public Background_Maker()
        {
            InitializeComponent();

            ReadData();
            CreateGUI();
        }

        private void ReadData()
        {
            StreamReader sr = new StreamReader("labirint.in");
            string line = sr.ReadLine();
            char[] sep = { ' ' };
            string[] s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(s[0]);
            m = int.Parse(s[1]);
            L = new int[n, m];
            x = new int[n, m];

            line = sr.ReadLine();
            s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            i1 = int.Parse(s[0]); i1--;
            j1 = int.Parse(s[1]); j1--;
            i2 = int.Parse(s[2]); i2--;
            j2 = int.Parse(s[3]); j2--;

            for (int i = 0; i < n; ++i)
            {
                line = sr.ReadLine();
                s = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; ++j)
                    L[i, j] = int.Parse(s[j]);
            }
            sr.Close();

        }

        private bool OK(int i, int j)
        {
            if (i < 0 || i >= n || j < 0 || j >= m)
                return false;
            if (L[i, j] == 1) return false;
            if (x[i, j] != 0) return false;
            return true;
        }

        private void Back(int i, int j, int k)
        {
            if (backgroundWorker1.CancellationPending) return;
            if (!OK(i, j)) return;
            x[i, j] = k;
            backgroundWorker1.ReportProgress(10, new UserState(i, j, k, pathcolor));
            Thread.Sleep(300);
            if (i == i2 && j == j2)
            {
                backgroundWorker1.ReportProgress(10, null);  // null inseamna ca updatex numai lblSol
                Thread.Sleep(1500);
            }
            else
                for (int d = 0; d < 4; ++d)
                {
                    int iv = i + dx[d];
                    int jv = j + dy[d];
                    Back(iv, jv, k + 1);
                }
            x[i, j] = 0;
            backgroundWorker1.ReportProgress(10, new UserState(i, j, 0, background));
            Thread.Sleep(300);
        }

        private void CreateGUI()
        {
            btn = new Button[n, m];
            table = new TableLayoutPanel()
            {
                RowCount = n,
                ColumnCount = m,
                Dock = DockStyle.Fill
            };

            int H = panel1.Height;
            int W = panel1.Width;
            int lat = Math.Min(H, W) / Math.Max(n, m);

            for (int j = 0; j < m; j++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, lat));

            for (int i = 0; i < n; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, lat));
                for (int j = 0; j < m; ++j)
                {
                    btn[i, j] = new Button()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = L[i, j] == 0 ? background : wallColor,
                        FlatStyle = FlatStyle.Flat,
                        Margin = new Padding(0),
                        Font = new Font(new FontFamily("Arial"), 14, FontStyle.Bold)
                    };
                    table.Controls.Add(btn[i, j]);
                }
            }
            panel1.Controls.Add(table);
        }
    }
}
