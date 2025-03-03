using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TBA_Central.CustomControls;

namespace WordsPerMinute
{
    public partial class InregistrarePage : Form
    {
        private string connStr = @"Server=DESKTOP-L0DRJ0P;Database=Users;Trusted_Connection=True";
        private string path = Directory.GetCurrentDirectory();
        private string filePath = string.Empty;
        private string eyePath = string.Empty;
        private string email;
        private string parola;
        TextBox txt_nume;
        TextBox txt_parola;
        TextBox txt_email;

        bool ok_email = false;
        bool ok_parola = false;

        int i = 0;

        public InregistrarePage()
        {
            InitializeComponent();
            Design();
        }

        private void SelectAllData()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SelectAllUsers";
                    using (SqlDataReader dr =  cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            email = dr["Email"].ToString();
                            if(CheckedEmail(txt_email.Text) && txt_email.Text != email)
                            {
                                ok_email = true;
                            }
                            else
                            {
                                ok_email = false;
                            }

                            parola = txt_parola.Text;
                            if(parola.Length >= 8)
                            {
                                ok_parola = true;
                            }
                        }

                    }
                }
            }
        } // selecteaza din baza de date toate datele si le verifica

        private void InsertData(string nume, string parola, string email)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertData";

                    cmd.Parameters.AddWithValue("@nume", nume);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);
                    cmd.ExecuteNonQuery();
                }
            }
        } // insereaza date in baza de date

        private void Design()
        {
            filePath = Path.Combine(path, "Loggo.png");
            eyePath = Path.Combine(path, "Eye.png");

            this.Width = 400;
            this.Height = 600;

            Color back_color = Color.FromArgb(162, 163, 187);
            Color p = Color.FromArgb(251, 249, 255);
            Color btn = Color.FromArgb(179, 183, 238);

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
                Location = new Point(5, 150),
                Font = new Font("Arial", 20, FontStyle.Bold),
            };

            txt_nume = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(130, 150),
                Font = new Font("Arial", 15, FontStyle.Regular),
            };

            background.Controls.Add(nume_label);
            background.Controls.Add(txt_nume);

            Label parola_label = new Label
            {
                Text = "Parola:",
                Size = new Size(110, 30),
                BackColor = Color.Transparent,
                Location = new Point(5, 230),
                Font = new Font("Arial", 20, FontStyle.Bold),
            };

            txt_parola = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(130, 230),
                Font = new Font("Arial", 15, FontStyle.Regular),
                PasswordChar = '*'
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

            Label email_label = new Label
            {
                Text = "Email:",
                Size = new Size(110, 30),
                BackColor = Color.Transparent,
                Location = new Point(5, 310),
                Font = new Font("Arial", 20, FontStyle.Bold),
            };

            txt_email = new TextBox
            {
                Size = new Size(200, 30),
                Location = new Point(130, 310),
                Font = new Font("Arial", 15, FontStyle.Regular),
            };

            background.Controls.Add(email_label);
            background.Controls.Add(txt_email);

            RoundButton btn_confirma = new RoundButton
            {
                Width = 200,
                Height = 60,
                BackColor = btn,
                Location = new Point(100, 400),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 25, FontStyle.Italic),
                Text = "Confirma",
                BorderRadius = 10,
                BorderColor = Color.Black,
                BorderSize = 1
            };

            background.Controls.Add(btn_confirma);
            btn_confirma.Click += ConfirmaClick;


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

            background.Controls.Add(descriere);
        } // face butoanele, TextBox-urile si label-urile

        private void PaintImage(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile(filePath);
            Rectangle r = new Rectangle(0, -50, 400, 300);
            e.Graphics.DrawImage(img, r);
        } // deseneaza loggo-ul pe panel

        private void ConfirmaClick(object sender, EventArgs e)
        {
            SelectAllData();
            if(!ok_email)
            {
                MessageBox.Show("Email nevalid", "Nevalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Text = string.Empty;
            }  
            if(!ok_parola)
            {
                MessageBox.Show("Parola trebuie sa aiba minim 8 caractere", "Parola scurta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_parola.Text = string.Empty;
            }
            if(ok_email && ok_parola)
            {
                InsertData(txt_nume.Text, txt_parola.Text, txt_email.Text);
                LoginPage lp = new LoginPage();
                this.Hide();
                lp.ShowDialog();
                this.Close();
            }
            
        } // verifica daca datele sunt corecte si 
                                                                  // se pot introduce in baza de date

        bool CheckedEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }// verifica daca formatul emailului e valid

        private void ButtonVisual(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 1)
                txt_parola.PasswordChar = '\0';
            else
                txt_parola.PasswordChar = '*';
        }// face ca parola sa fie vizibila
    }
}
