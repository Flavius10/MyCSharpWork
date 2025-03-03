using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA_Central.CustomControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WordsPerMinute
{
    public partial class TryYourFingers : Form
    {
        private string connStr = @"Server=DESKTOP-L0DRJ0P;Database=Users;Trusted_Connection=True";

        private string nume_participant = string.Empty;
        private string language = string.Empty;

        private string path = Directory.GetCurrentDirectory();
        private string filePath = string.Empty;

        private string fileRomana = string.Empty;
        private string fileEngleza = string.Empty;

        List<string> romana = new List<string>();
        List<string> engleza= new List<string>();

        Label label_word;
        Label timer;
        int time = 60;
        System.Timers.Timer timer_minute = new System.Timers.Timer();

        int punctaj = 0;
        TextBox completare_cuvant;
        Random cuv = new Random();
        int nr_litere = 0;

        DataGridView dgw;
        Label limba_concurent;

        public TryYourFingers(string language, string nume)
        {
            InitializeComponent();

            this.language = language;
            this.nume_participant = nume;

            filePath = Path.Combine(path, "Loggo.png");
            fileRomana = Path.Combine(path, "RomanaCuvinteRandom.txt");
            fileEngleza = Path.Combine(path, "EnglezaCuvinteRandom.txt");

            Design();
            SelectCuvinteRomana();
            SelectCuvinteEngleza();
            SelectTopThree();
        }

        private void Design()
        {
            Color panel_left_color = Color.FromArgb(147, 149, 211);
            Color panel_right_color = Color.FromArgb(179, 183, 238);
            Color text_color = Color.FromArgb(0, 8, 7);
            Color label_color = Color.FromArgb(251, 249, 255);

            Panel panel_left = new Panel()
            {
                BackColor = panel_left_color,
                Width = 200,
                Height = this.Height,
            };

            Label nume_concurent = new Label()
            {
                BackColor = Color.Transparent,
                Width = 130,
                Height = 20,
                Location = new Point(35, 70),
                ForeColor = text_color,
                Font = new Font("Arial", 12, FontStyle.Italic),
                Text = "Nume: " + nume_participant
            };

            limba_concurent = new Label()
            {
                BackColor = Color.Transparent,
                Width = 130,
                Height = 20,
                Location = new Point(35, 100),
                ForeColor = text_color,
                Font = new Font("Arial", 12, FontStyle.Italic),
                Text = "Limba: " + language
            };

            Label lbl_top_three = new Label
            {
                BackColor = Color.Transparent,
                Width = 130,
                Height = 20,
                Location = new Point(35, 130),
                ForeColor = text_color,
                Font = new Font("Arial", 12, FontStyle.Italic),
                Text = "Top 3 scoruri"

            };


            RoundButton btn_start = new RoundButton
            {
                Width = 100,
                Height = 60,
                BackColor = label_color,
                Location = new Point(55, 370),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 17, FontStyle.Italic),
                Text = "Start!",
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            dgw = new DataGridView()
            {
                Location = new Point(25, 160),
                Size = new Size(150, 150)
            };

            this.Controls.Add(panel_left);
            panel_left.Controls.Add(nume_concurent);
            panel_left.Controls.Add(limba_concurent);
            panel_left.Controls.Add(lbl_top_three);
            panel_left.Controls.Add(dgw);
            panel_left.Paint += PaintImage;
            panel_left.Controls.Add(btn_start);
            btn_start.Click += StartButtonClick;

            Panel panel_right = new Panel
            {
                Location = new Point(200, 0),
                Size = new Size(this.Width - 200, this.Height),
                BackColor = panel_right_color,
                ForeColor = text_color,
            };

            this.Controls.Add(panel_right);

            label_word = new Label
            {
                Location = new Point(100, 20),
                Size = new Size(400, 100),
                BackColor = label_color,
                Font = new Font("Arial", 25, FontStyle.Italic),
                Text = "SPOR!",
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.Fixed3D,
            };

            timer = new Label
            {
                Location = new Point(450, 370),
                Size = new Size(100, 50),
                BackColor = label_color,
                Font = new Font("Arial", 15, FontStyle.Italic),
                Text = "1:00",
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.Fixed3D,
            };

            completare_cuvant = new TextBox
            {
                Location = new Point(150, 250),
                Size = new Size(300, 70),
                BackColor = label_color,
                Font = new Font("Arial", 25, FontStyle.Italic),
                Text = "",
                TextAlign = HorizontalAlignment.Center,
                BorderStyle = BorderStyle.Fixed3D,
            };

            RoundButton btn_reset = new RoundButton
            {
                Width = 100,
                Height = 60,
                BackColor = label_color,
                Location = new Point(30, 370),
                Size = new Size(100, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 17, FontStyle.Italic),
                Text = "Reset!",
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            RoundButton btn_schimba = new RoundButton
            {
                Width = 100,
                Height = 60,
                BackColor = label_color,
                Location = new Point(230, 370),
                Size = new Size(150, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 17, FontStyle.Italic),
                Text = "Schimba limba",
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            timer_minute.Elapsed += TimerTick;
            btn_reset.Click += ButtonResetPress;
            panel_right.Controls.Add(label_word);
            panel_right.Controls.Add(timer);
            panel_right.Controls.Add(completare_cuvant);
            panel_right.Controls.Add(btn_reset);
            panel_right.Controls.Add(btn_schimba);
            completare_cuvant.TextChanged += TextBoxCompletareChange;
            btn_schimba.Click += SchimbaLimbaButton;
        }

        private void PaintImage(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile(filePath);
            Rectangle r = new Rectangle(-50, -10, 300, 150);
            e.Graphics.DrawImage(img, r);
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            timer_minute.Interval = 1000;
            timer_minute.Start();  
            completare_cuvant.Focus();
            if (language == "Romana")
                label_word.Text = romana[cuv.Next(10, 500)].ToString();
            if (language == "Engleza")
                label_word.Text = engleza[cuv.Next(10, 500)].ToString();
        }

        private void TimerTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (time == 60)
                timer.Text = "1:00";
            else
                timer.Text = "0:" + time;

            if (time == 0)
            {
                timer_minute.Stop();
                MessageBox.Show("Ai scris " + punctaj + " cuvinte pe minut","Puntacj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InsertPunctaj(nume_participant, language, punctaj);
                completare_cuvant.Text = string.Empty;
                label_word.Text = "SPOR!";
                SelectTopThree();
            }
                
            time--;

        }

        private void SelectCuvinteRomana()
        {
            using (StreamReader sr = new StreamReader(fileRomana))
            {
                string line = "";
                string[] s;
                char[] split = { '\n' };
                while((line = sr.ReadLine()) != null)
                {
                    s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < s.Length; ++i)
                    {
                        romana.Add(s[i]);
                    }
                }
            }
        }

        private void SelectCuvinteEngleza()
        {
            using (StreamReader sr = new StreamReader(fileEngleza))
            {
                string line = "";
                string[] s;
                char[] split = { '\n' };
                while ((line = sr.ReadLine()) != null)
                {
                    s = line.Split(split, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < s.Length; ++i)
                    {
                        engleza.Add(s[i]);
                    }
                }
            }
        }

        private void ButtonResetPress(object sender, EventArgs e)
        {
            time = 60;
            timer_minute.Stop();
            timer.Text = "1:00";
            punctaj = 0;
            completare_cuvant.Text = string.Empty;
            label_word.Text = "SPOR!";
            label_word.ForeColor = Color.Black;
        }

        private void TextBoxCompletareChange(object sender, EventArgs e)
        {
            string text_lbl_world = label_word.Text;
            string completare = completare_cuvant.Text; 

            bool contains = text_lbl_world.StartsWith(completare);

            if(contains)
            {
                label_word.ForeColor = Color.Green;
            }
            else
            {
                label_word.ForeColor = Color.Red;
            }

            if (completare_cuvant.Text == "")
                label_word.ForeColor = Color.Black;


            if (text_lbl_world == completare)
            {
                punctaj++;
                if (language == "Romana")
                    label_word.Text = romana[cuv.Next(10, 500)].ToString();
                if (language == "Engleza")
                    label_word.Text = engleza[cuv.Next(10, 500)].ToString();
                completare_cuvant.Text = string.Empty;
                SelectTopThree();
            }
        }

        private void InsertPunctaj(string nume, string limba, int punctaj)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertPunctaj";

                    cmd.Parameters.AddWithValue("@un", nume);
                    cmd.Parameters.AddWithValue("@limba", limba);
                    cmd.Parameters.AddWithValue("@punctaj", punctaj);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SelectTopThree()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SelectTopThree";

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgw.DataSource = dt;
                    }
                }
            }
        }

        private void SchimbaLimbaButton(object sender, EventArgs e)
        {
            if(language == "Romana")
            {
                language = "Engleza";
                limba_concurent.Text = "Limba: Engleza";
            }    
            else if(language == "Engleza")
            {
                language = "Romana";
                limba_concurent.Text = "Limba: Romana";
            }
        }
    }
}
