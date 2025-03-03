using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ButtonMatrix
{
    public partial class MainForm : Form
    {
       
        private int n, m;
        private Button[,] btn;
        private TableLayoutPanel tbl;

        private int nrsol;
        private int[,] L;
        private int[,] x;
        private int i1, j1, i2, j2;
        private readonly int[] di = { -1, 0, 1, 0 };
        private readonly int[] dj = { 0, 1, 0, -1 };
        private Color backgroundColor = Color.FromArgb(255, 204, 153);
        private Color wallColor = Color.FromArgb(77, 38, 0);
        private Color pathColor = Color.Red;

        public MainForm()
        {
            InitializeComponent();
            
            ReadData();
            CreateGUI();
        }

        // se va executa pe alt thread
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Back(i1, j1, 1);
        }

        // se va executa pe threadul GUI
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UserState us = (UserState)e.UserState;

            if (us != null) // updatez un buton
            {
                int i = us.I;
                int j = us.J;
                int k = us.K;
                Color c = us.C;
                btn[i, j].BackColor = c;
                btn[i, j].Text = k == 0 ? string.Empty : k.ToString();
                btn[i, j].Update();
            }
            else  //Updatez label
            {
                nrsol++;
                lblSol.Text = nrsol.ToString();
            }
        }

        // se executa pe threadul GUI, dupa terminarea threadului copil
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        // pe GUI
        private void btnStart_Click(object sender, EventArgs e)
        {
            nrsol = 0;
            lblSol.Text = "0";
            if (bw.IsBusy) return;  // daca mergea, nu-l mai pornesc odata
            bw.RunWorkerAsync(); // lanseaza in executie noul thread
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy)
                bw.CancelAsync();  // opreste threadul copil
        }

        private bool Ok(int i, int j)
        {
            if (i < 0 || i >= n || j < 0 || j >= m)
                return false;
            if (L[i, j] == 1) return false;
            if (x[i, j] != 0) return false;
            return true;
        }

        void Back(int i, int j, int k)
        {
            if (bw.CancellationPending) return;
            if (!Ok(i, j)) return;
            x[i, j] = k;
            bw.ReportProgress(10, new UserState(i, j, k, pathColor));
            Thread.Sleep(300);
            if (i == i2 && j == j2)
            {
                bw.ReportProgress(10, null);  // null inseamna ca updatex numai lblSol
                Thread.Sleep(1500);
            }
            else
                for (int d = 0; d < 4; ++d)
                {
                    int iv = i + di[d];
                    int jv = j + dj[d];
                    Back(iv, jv, k + 1);
                }
            x[i, j] = 0;
            bw.ReportProgress(10, new UserState(i, j, 0, backgroundColor));
            Thread.Sleep(300);
        }


        private void ReadData()
        {
            StreamReader sr = new StreamReader("labirint.in");
            string line = sr.ReadLine();
            char[] sep = { ' '};
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

        private void CreateGUI()
        {
            btn = new Button[n, m];
            tbl = new TableLayoutPanel()
            {
                RowCount = n,
                ColumnCount = m,
                Dock = DockStyle.Fill
            };

            int H = panel.Height;
            int W = panel.Width;
            int lat = Math.Min(H, W) / Math.Max(n, m);

            for (int j = 0; j < m; j++)
                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, lat));

            for (int i = 0; i < n; i++)
            {
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, lat));
                for (int j = 0; j < m; ++j)
                {
                    btn[i, j] = new Button()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = L[i, j] == 0 ? backgroundColor : wallColor,
                        FlatStyle = FlatStyle.Flat,
                        Margin = new Padding(0),
                        Font = new Font(new FontFamily("Arial"), 14, FontStyle.Bold)
                    };
                    tbl.Controls.Add(btn[i, j]);
                }
            }
            panel.Controls.Add(tbl);
        }

    }
}
