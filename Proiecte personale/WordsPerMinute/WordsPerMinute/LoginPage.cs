using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBA_Central.CustomControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WordsPerMinute
{
    public partial class LoginPage : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private string filePath = string.Empty;
        private string connStr = @"Server=DESKTOP-L0DRJ0P;Database=Users;Trusted_Connection=True";
        private string parola = string.Empty;
        private string nume = string.Empty;
        private string language = string.Empty;     
        private string nume_logare = string.Empty;

        TextBox txt_parola;
        TextBox txt_nume;

        ComboBox lblanguage;

        bool ok_nume = false;
        bool ok_parola = false;
        bool ok_complet = false;

        RoundButton btn_logare;

        int i = 0;

        public LoginPage()
        {
            InitializeComponent();
            Design();
        }

        private void SelectDataForCheck()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SelectAllUsers";
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            parola = dr["Parola"].ToString();
                            nume = dr["Nume"].ToString();

                            if(parola == txt_parola.Text && nume == txt_nume.Text)
                            {
                                ok_parola = true;
                                ok_nume = true;
                            }
                        }
                    }
                }
            }
        } // selecteaza toate datele pentru a le verifica

        private void Design()
        {
            filePath = Path.Combine(path, "Loggo.png");

            this.Width = 400;
            this.Height = 600;

            Color back_color = Color.FromArgb(162, 163, 187);
            Color p = Color.FromArgb(179, 183, 238);
            Color btn = Color.FromArgb(251, 249, 255);

            Panel background = new Panel
            {
                Width = this.Width,
                Height = this.Height,
                BackColor = back_color,
            };

            Panel pl = new Panel
            {
                Width = 7,
                Height = this.Height,
                BackColor = p,
                Location = new Point(0, 0)
            };

            Panel pr = new Panel
            {
                Width = 7,
                Height = this.Height,
                BackColor = p,
                Location = new Point(377, 0)
            };

            this.Controls.Add(background);
            background.Paint += PaintImage;
            background.Controls.Add(pl);
            background.Controls.Add(pr);

            Label nume_label = new Label
            {
                Text = "Nume:",
                Size = new Size(110, 30),
                BackColor = Color.Transparent,
                Location = new Point(5,150),
                Font = new Font("Arial", 20, FontStyle.Italic),
            };

            txt_nume = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(130, 150),
                Font = new Font("Arial", 15, FontStyle.Regular),
                Text = ""
            };

            background.Controls.Add(nume_label);
            background.Controls.Add(txt_nume);

            Label parola_label = new Label
            {
                Text = "Parola:",
                Size = new Size(110, 30),
                BackColor = Color.Transparent,
                Location = new Point(5, 230),
                Font = new Font("Arial", 20, FontStyle.Italic),
            };

            txt_parola = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(130, 230),
                Font = new Font("Arial", 15, FontStyle.Regular),
                PasswordChar = '*',
                Text = ""
            };

            background.Controls.Add(parola_label);
            background.Controls.Add(txt_parola);

            RoundButton btn_visual = new RoundButton
            {
                Width = 30,
                Height = 30,
                BackColor = btn,
                Location = new Point(340, 230),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Italic),
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1,
                Text = "V"
            };

            background.Controls.Add(btn_visual);
            btn_visual.Click += ButtonVisual;

            btn_logare = new RoundButton
            {
                Width = 200,
                Height = 60,
                BackColor = btn,
                Location = new Point(100, 360),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 25, FontStyle.Italic),
                Text = "Logare",
                BorderRadius = 20,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            RoundButton btn_inregistrare = new RoundButton
            {
                Width = 150,
                Height = 30,
                BackColor = btn,
                Location = new Point(125, 430),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 15, FontStyle.Italic),
                Text = "Nu am cont",
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            background.Controls.Add(btn_logare);
            background.Controls.Add(btn_inregistrare);
            btn_inregistrare.Click += InregistrareClick;
            btn_logare.Click += ButtonLogare;

            Label descriere = new Label
            {
                Text = " Pregătește-te pentru o experiență plină de adrenalină" +
                " în care vei trebui să scrii cuvinte rapid și corect " +
                "pentru a câștiga puncte prețioase. Cu cât scrii mai rapid," +
                " cu atât vei acumula mai multe puncte!",
                Size = new Size(background.Width - 30, 100),
                Location = new Point(10, 470),
                Font = new Font("Arial", 12, FontStyle.Regular)
            };

            lblanguage = new ComboBox
            {
                Size = new Size(150, 70),
                Location = new Point(125, 300),
                Font = new Font("Arial", 12, FontStyle.Regular),
            };

            lblanguage.KeyDown += EnterPress;

            Label combo_language_label = new Label
            {
                Size = new Size(150, 70),
                Location = new Point(25,300),
                Font = new Font("Arial", 12, FontStyle.Regular),
                Text = "Alegeti limba:"
            };

            lblanguage.Items.Add("Romana");
            lblanguage.Items.Add("Engleza");

            background.Controls.Add(descriere);
            background.Controls.Add(lblanguage);
            background.Controls.Add(combo_language_label);

            txt_nume.KeyDown += TextBox_KeyDown;
            txt_parola.KeyDown += TextBox_KeyDown;
            lblanguage.KeyDown += TextBox_KeyDown;

            if (txt_nume.Text != string.Empty && txt_parola.Text != string.Empty && lblanguage.SelectedItem != null)
                ok_complet = true;

        }// face butoanele, TextBox-urile si label-urile

        private void PaintImage(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile(filePath);
            Rectangle r = new Rectangle(0, -50, 400, 300);
            e.Graphics.DrawImage(img, r);
        }// deseneaza loggo-ul pe panel

        private void InregistrareClick(object sender, EventArgs e)
        {
            InregistrarePage ip = new InregistrarePage();
            this.Hide();
            ip.ShowDialog();
            this.Close();
        } // intra pe pagina de inregistrare

        private void ButtonLogare(object sender, EventArgs e)
        {
            SelectDataForCheck();

            if (!ok_parola || !ok_nume)
            {
                MessageBox.Show("Datele introduse sunt incorecte!!!", "Date incorecte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nume.Text = string.Empty;   
                txt_parola.Text = string.Empty;
            }

            if(ok_parola && ok_nume)
            {
                language = lblanguage.SelectedItem.ToString();
                nume_logare = txt_nume.Text;
                TryYourFingers tyf = new TryYourFingers(language, nume_logare);
                this.Hide();
                tyf.ShowDialog();
                this.Close();
            }
                
        } // face ca pagina de joc sa apara 
                                                                 //  daca datele sunt corecte
        private void ButtonVisual(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 1)
                txt_parola.PasswordChar = '\0';
            else
                txt_parola.PasswordChar = '*';
        } // face ca sa vedem informatia din text-boxul
                                                                 // specific parolei
        private void  EnterPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_logare.Focus();
                ButtonLogare(sender, e);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the next control
                SelectNextControl((Control)sender, true, true, true, true);

                // If the focused control is a button, trigger its click event
                if (ActiveControl is Button)
                {
                    if(ok_complet)
                    {
                        TryYourFingers tyf = new TryYourFingers(language, nume_logare);
                        this.Hide();
                        tyf.ShowDialog();
                        this.Close();
                        Button btn = (Button)ActiveControl;
                        btn.PerformClick();
                    }

                }
            }
        }
    }
}
